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

namespace eThreadingBar.WinUI.Izvjestaji
{
    public partial class fmrIzvjestajpoKlijentima : Form
    {
        public APIService _klijent= new APIService("Klijent");
        public APIService _rezervacije = new APIService("Rezervacija");

        
     

        public fmrIzvjestajpoKlijentima()
        {
            InitializeComponent();
        

        }
     
        private async  Task LoadKlijenti()
        {
            var result = await _klijent.Get<List<Model.Klijent>>(null);
            result.Insert(0, new Model.Klijent());
            cmbKlijenti.DisplayMember = "Ime";
            cmbKlijenti.ValueMember = "KlijentId";

            cmbKlijenti.DataSource = result;
        }


        private async Task LoadIzvjestaj(int ID,string godina)
        {
            int brojrezervacija = 0;
            int ukupnorezervacija = 0;
            lblbrojrezervacija.Text = "";
            lblUkupanbrojrezervacija.Text = " ";
            lblKlijent.Text = "";

            int _godinaid = 0;
            List<Model.IzvjestajpoKlijentu> lista = new List<Model.IzvjestajpoKlijentu>();

            Model.Klijent k = null;
            if (int.TryParse(godina.ToString(), out int godinaid))
            {
                _godinaid = godinaid;
            }

            if (ID > 0 && _godinaid > 0)
            {
                k = await _klijent.GetById<Model.Klijent>(ID);
                List<Model.Rezervacija> rezervacije = await _rezervacije.Get<List<Model.Rezervacija>>(new RezervacijaSearchRequest { KlijentId = k.KlijentId, Godina = _godinaid });
                foreach (var r in rezervacije)
                {
                    brojrezervacija++;
                }
                lista.Add(new Model.IzvjestajpoKlijentu() { ImePrezime = k.Ime + " " + k.Prezime, Brojrezervacija = brojrezervacija });

               int brojrezervacijatemp = brojrezervacija;
         
            }
            else if (ID > 0)
            {
                k = await _klijent.GetById<Model.Klijent>(ID);
                List<Model.Rezervacija> rezervacije = await _rezervacije.Get<List<Model.Rezervacija>>(new RezervacijaSearchRequest { KlijentId = k.KlijentId });
                foreach (var r in rezervacije)
                {
                    brojrezervacija++;
                }
                lista.Add(new Model.IzvjestajpoKlijentu() { ImePrezime = k.Ime + " " + k.Prezime, Brojrezervacija = brojrezervacija });


                brojrezervacija = 0;
             
            }
            else if (_godinaid > 0)
            {
                List<Model.Klijent> klijenti = await _klijent.Get<List<Model.Klijent>>(null);
                foreach (var kl in klijenti)
                {
                    List<Model.Rezervacija> rezervacije = await _rezervacije.Get<List<Model.Rezervacija>>(new RezervacijaSearchRequest { KlijentId = kl.KlijentId, Godina = _godinaid });

                    foreach (var r in rezervacije)
                    {
                        brojrezervacija++;
                    }
                    lista.Add(new Model.IzvjestajpoKlijentu() { ImePrezime = kl.Ime + " " + kl.Prezime, Brojrezervacija = brojrezervacija });
                    ukupnorezervacija += brojrezervacija;
                    

                    brojrezervacija = 0;
                }
                lblbrojrezervacija.Text = "Ukupan broj rezervacija za " + _godinaid.ToString() + ".godinu je: " + ukupnorezervacija.ToString() + ".";
                lblKlijent.Text = "Klijent " + lista[0].ImePrezime + " ima najveci broj rezervacija(" + lista[0].Brojrezervacija.ToString() + ") u " + _godinaid.ToString() + "godini.";
            }
            else
            {
                List<Model.Klijent> klijenti = await _klijent.Get<List<Model.Klijent>>(null);
                foreach (var kl in klijenti)
                {
                    List<Model.Rezervacija> rezervacije = await _rezervacije.Get<List<Model.Rezervacija>>(new RezervacijaSearchRequest { KlijentId = kl.KlijentId});

                    foreach (var r in rezervacije)
                    {
                        brojrezervacija++;
                    }
                    lista.Add(new Model.IzvjestajpoKlijentu() { ImePrezime = kl.Ime + " " + kl.Prezime, Brojrezervacija = brojrezervacija });
                    ukupnorezervacija += brojrezervacija;


                    brojrezervacija = 0;
                }
                lblbrojrezervacija.Text = "Ukupan broj rezervacija"  + " je: " + ukupnorezervacija.ToString() + ".";
                lblKlijent.Text = "Klijent " + lista[0].ImePrezime + " ima najveci broj rezervacija(" + lista[0].Brojrezervacija.ToString() + ").";


            }

            List<Model.IzvjestajpoKlijentu>sortirana = lista.OrderByDescending(x=>x.Brojrezervacija).ToList();

            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = sortirana;
        }
 

        private async void btnPrikaziIzvjestaj_Click(object sender, EventArgs e)
        {
            var idObj = cmbKlijenti.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadIzvjestaj(id, txtGodina.Text);
            }
            else

                await LoadIzvjestaj(id, txtGodina.Text);

        }

        private async void fmrIzvjestajpoKlijentima_Load(object sender, EventArgs e)
        {
            lblbrojrezervacija.Text = "";
            lblKlijent.Text = "";
            await LoadKlijenti();


        }
    }
}
