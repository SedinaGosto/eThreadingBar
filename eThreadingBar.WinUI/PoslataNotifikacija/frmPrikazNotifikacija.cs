using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eThreadingBar.WinUI.PoslataNotifikacija
{
    public partial class frmPrikazNotifikacija : Form
    {
        APIService _apiService = new APIService("PoslataNotifikacija");
        APIService _tretman = new APIService("Tretman");
        APIService _termin = new APIService("Termin");
        APIService _rezervacija = new APIService("Rezervacija");
        APIService _Klijent = new APIService("Klijent");
        APIService _korisnik = new APIService("Korisnici");
        APIService _klijentNotifikacija = new APIService("KlijentNotifikacija");

        public frmPrikazNotifikacija()
        {
            InitializeComponent();
        }
        List<Model.PoslataNotifikacijaList> lista = new List<Model.PoslataNotifikacijaList>();
        List<Korisnici> k = null;
        Korisnici korisnik = null;
        private  async void frmPrikazNotifikacija_Load(object sender, EventArgs e)
        {
             await UcitajPodatke();
            Text = "Rezervacije";
            await LoadKlijenti();

        }
        private async Task LoadKlijenti()
        {
            var result = await _Klijent.Get<List<Model.Klijent>>(null);
            result.Insert(0, new Model.Klijent());
            cmbKlijent.DisplayMember = "Ime";
            cmbKlijent.ValueMember = "KlijentId";

            cmbKlijent.DataSource = result;
        }

        private async Task  UcitajPodatke()
        {

            var username = APIService.Username;
            k = await _korisnik.Get<List<Korisnici>>(new KorisniciSearchRequest { KorisnickoIme = username });
            foreach (var kor in k)
            {
                korisnik = kor;
            }
            if (korisnik != null)
            {
                var list = await _apiService.Get<List<Model.PoslataNotifikacija>>(new PoslataNotifikacijaSearchRequest { UposlenikId = korisnik.KorisnikId });
               if(lista.Count>0)
                lista.Clear();
                foreach (var notifikacija in list)
                {
                    var rezervacija = await _rezervacija.GetById<Model.Rezervacija>(notifikacija.RezervacijaId);
                    var tretman = await _tretman.GetById<Model.Tretman>(rezervacija.TretmanId);
                    var termin = await _termin.GetById<Model.Termin>(rezervacija.TerminId);
                    var klijent = await _Klijent.GetById<Model.Klijent>(rezervacija.KlijentId);

                    lista.Add(new Model.PoslataNotifikacijaList
                    {
                        RezervacijaId = notifikacija.RezervacijaId,
                        PoslataNotifikacijaId = notifikacija.Id,
                        DatumRezervacije = rezervacija.DatumRezervacije.ToShortDateString(),
                        Klijent = klijent.Ime + " " + klijent.Prezime,
                        Tretman = tretman.Naziv,
                        VrijemeTermina = termin.VrijemeTermina.Date.ToShortDateString() + termin.VrijemeTermina.TimeOfDay.ToString(),
                        KlijentId = klijent.KlijentId


                    }) ;
                }
             

                dgvNotifikacije.AutoGenerateColumns = false;
                dgvNotifikacije.DataSource = lista;
            }

        }
    
        private  void dgvNotifikacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6) 
            {
                int notifikacija = 0;
                int rezervacija = 0;
                var Notifikacija = dgvNotifikacije[0, e.RowIndex].Value;
                var id = dgvNotifikacije[1, e.RowIndex].Value;

                if (int.TryParse(Notifikacija.ToString(), out int n))
                {
                    notifikacija = n;
                }
                if (int.TryParse(id.ToString(), out int r))
                {
                    rezervacija = r;
                }

                 OznaciKaoProcitano(notifikacija, rezervacija);
               
            }
        }
        private async void OznaciKaoProcitano(int n, int r)
        {
            var Notifikacija = await _apiService.GetById<Model.PoslataNotifikacija>(n);
           var rezervacija = await _rezervacija.GetById<Model.Rezervacija>(r);
            var klijent = await _Klijent.GetById<Model.Klijent>(rezervacija.KlijentId);
            Model.PoslataNotifikacija entity = null;
           entity= await _apiService.Update<Model.PoslataNotifikacija>(n, new PoslataNotifikacijaInsertRequest
            {
                DatumSlanja = Notifikacija.DatumSlanja,
                Id = Notifikacija.Id,
                RezervacijaId = r,
                IsProcitano = true
            });
            if (entity != null)
            {
                await _klijentNotifikacija.Insert<Model.KlijentNotifikacija>(new KlijentNotifikacijaInsertRequest
                { 

                    RezervacijaId = r,
                    IsProcitano=false,
                    DatumSlanja=DateTime.Now,
       
                    KlijentId=klijent.KlijentId
                });
                DialogResult dialog = MessageBox.Show("Uspjesno ste odobrili rezervaciju!");
                if (dialog == DialogResult.OK)
                {
                    dgvNotifikacije.DataSource = null;
                   await  UcitajPodatke();
                }
            }


        }

        private async void cmbKlijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKlijent.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await Loadnotifikacije(id);
            }
        }
        private async Task Loadnotifikacije(int id)
        {
            if (id == 0)
            {
                dgvNotifikacije.AutoGenerateColumns = false;
                dgvNotifikacije.DataSource = lista;
            }
            else
            {
                List<Model.PoslataNotifikacijaList> listatemp = new List<Model.PoslataNotifikacijaList>();
                listatemp.Clear();
                foreach (var n in lista)
                {
                    if (n.KlijentId == id)
                    {
                        listatemp.Add(n);
                    }
                }
                dgvNotifikacije.AutoGenerateColumns = false;
                dgvNotifikacije.DataSource = listatemp;
            }
        }

        private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Model.Klijent)e.ListItem).Ime;
            string prezime = ((Model.Klijent)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }
    }
}
