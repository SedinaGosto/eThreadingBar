using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eThreadingBar.WebAPI.Services
{
    public class KorisniciService : IkorisniciService

    {
        private readonly BeautyStudio2019Context _context;
        private readonly IMapper _mapper;
        public KorisniciService(BeautyStudio2019Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Model.Korisnici Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnik.Include("KorisniciUloge.Uloga").FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }
            return null;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public   List<Model.Korisnici> Get(KorisniciSearchRequest search)
        {

            var query = _context.Korisnik.AsQueryable();
        

            if (!string.IsNullOrWhiteSpace(search?.Ime)) 
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            if(!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));

            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme==search.KorisnickoIme);

            }
           


            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }
        public  Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Korisnik.Add(entity);
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                Database.KorisniciUloge korisniciUloge = new Database.KorisniciUloge();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.DatumIzmjene = DateTime.Now;
                _context.KorisniciUloge.Add(korisniciUloge);
            }
            _context.SaveChanges();
            var rezultat = new Model.Korisnici();
            rezultat.Ime = entity.Ime;
            rezultat.Prezime = entity.Prezime;
            rezultat.KorisnikId = entity.KorisnikId;
            rezultat.Email = entity.Email;
            rezultat.Telefon = entity.Telefon;
            rezultat.Status = entity.Status;
            rezultat.KorisnickoIme = entity.KorisnickoIme;
            rezultat.Slika = entity.Slika;

            return rezultat;
        }
        public  Model.Korisnici Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnik.Find(id);
            _context.Korisnik.Attach(entity);
            _context.Korisnik.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Korisnici GetById(int id)
        {
            var entity = _context.Korisnik.Find(id);

            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}
