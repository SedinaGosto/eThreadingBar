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
    public partial class frmIzvjestajpoUposleniku : Form
    {
        public APIService _uposlenik = new APIService("Korisnici");
        public APIService _rezervacija = new APIService("Rezervacija");
        public APIService _termin = new APIService("Termin");
        public APIService _tretman = new APIService("Tretman");


        public frmIzvjestajpoUposleniku()
        {
            InitializeComponent();
            label3.Text = " ";
        }
        private async Task LoadIzvjestaj()
        {
       
            int ukupanbrojrezervacija = 0;
            int ukupnazarada = 0;
            int? _godina = null;
          

            List<Model.Korisnici> uposlenici = await _uposlenik.Get<List<Model.Korisnici>>(null);
            List<Model.IzvjestajpoUposleniku> izvjestaj = new List<Model.IzvjestajpoUposleniku>();

            if (int.TryParse(txtgodina.Text.ToString(), out int godinaId))
            {
                _godina = godinaId;
                label3.Text = "Izvjestaj za uposlenike za " + _godina.ToString() + ".godinu.";
            }
            else
            label3.Text = "Cjelokupni izvjestaj za uposlenike.";

            if (chartIzvjestaj.Series["Uposlenik"].Points.Count > 0)
            {
                chartIzvjestaj.Series["Uposlenik"].Points.Clear();
                chartIzvjestaj.Series["Zarada"].Points.Clear();

            }
            foreach (var u in uposlenici)
            {
                List<Model.Termin> termini = await _termin.Get<List<Model.Termin>>(new TerminSearchRequest { UposlenikId = u.KorisnikId, Rezervisan = true });
               
                foreach (var t in termini)
                {
                    var rezervacije = await _rezervacija.Get<List<Model.Rezervacija>>(new RezervacijaSearchRequest { TerminId = t.Id, Godina = _godina });
                    if (rezervacije.Count > 0)
                        ukupanbrojrezervacija++;
                    foreach(var r in rezervacije)
                    {
                        var tretman =await _tretman.GetById<Model.Tretman>(r.TretmanId);
                        ukupnazarada += tretman.Cijena;
                    }

                }
                
                chartIzvjestaj.Series["Uposlenik"].Points.AddXY(u.Ime+" "+u.Prezime, ukupanbrojrezervacija);
                chartIzvjestaj.Series["Zarada"].Points.AddXY(u.Ime + " " + u.Prezime, ukupnazarada);


                izvjestaj.Add(new Model.IzvjestajpoUposleniku { ImePrezime = u.Ime + " " + u.Prezime, Ukupanbrojrezervacija = ukupanbrojrezervacija, Ukupnozaradjeno = ukupnazarada });
                ukupanbrojrezervacija = 0;
                ukupnazarada = 0;

            }
            chartIzvjestaj.ChartAreas[0].AxisX.LabelStyle.Angle = 45;

            dgvUposlenici.AutoGenerateColumns = false;
            dgvUposlenici.DataSource = izvjestaj;

        }

        private async void btnPrikaziIzvjestaj_Click(object sender, EventArgs e)
        {
            await LoadIzvjestaj();
        }
    }
}
