using AutoMapper;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class KlijentService : BaseCRUDService<Model.Klijent, KlijentSearchRequest, Database.Klijent, KlijentInsertRequest, KlijentInsertRequest>, ICRUDService<Model.Klijent, KlijentSearchRequest, KlijentInsertRequest, KlijentInsertRequest>
    {
        public KlijentService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {
            
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

        public override List<Model.Klijent> Get(KlijentSearchRequest search)
        {
            var query = _context.Klijent.AsQueryable();


            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));

            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme == search.KorisnickoIme);

            }
            //if (search?.IsUlogeLoadingEnabled == true)
            //{
            //    query = query.Include(x => x.KorisniciUloge);
            //}


            var list = query.ToList();
            return _mapper.Map<List<Model.Klijent>>(list);
        }

        public override Model.Klijent Insert(KlijentInsertRequest request)
        {
            var entity = _mapper.Map<Database.Klijent>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Klijent.Add(entity);
            _context.SaveChanges();

            var rezultat = new Model.Klijent();
            rezultat.Ime = entity.Ime;
            rezultat.Prezime = entity.Prezime;
            rezultat.KlijentId = entity.KlijentId;
            rezultat.Email = entity.Email;
            rezultat.BrojTelefona = entity.BrojTelefona;
            rezultat.KorisnickoIme = entity.KorisnickoIme;
            rezultat.GradId = entity.GradId;
        

            return rezultat;

        }
        public override Model.Klijent Update(int id, KlijentInsertRequest request)
        {
            var entity = _context.Klijent.Find(id);
            _context.Klijent.Attach(entity);
            _context.Klijent.Update(entity);

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

            return _mapper.Map<Model.Klijent>(entity);
        }
    }
}
