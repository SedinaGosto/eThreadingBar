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

namespace eThreadingBar.WinUI.Nagrada
{
    public partial class frmNagradnaIgraDetails : Form
    {
        private int? _id = null;
        private readonly APIService _apiservice = new APIService("nagradnaIgra");
        private readonly APIService _apiservicea = new APIService("korisnici");
        private readonly APIService _apiservicek = new APIService("klijent");
        private readonly APIService _apiservicen = new APIService("Nagrada");



        public frmNagradnaIgraDetails(int? Id = null)
        {
            InitializeComponent();
            _id = Id;
        }
        NagradnaIgraInsertRequest NagradnaIgra = new NagradnaIgraInsertRequest();
        private async void frmNagradnaIgraDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _apiservice.GetById<Model.NagradnaIgra>(_id);
                dtpDatumPocetka.Value = result.DatumPocetka;
               dtpDatumZavrsetka.Value = result.DatumZavrsetka;
                txtOpis.Text = result.Opis;
                var korsnik = await _apiservicea.GetById<Model.Korisnici>(result.KorisnikId);
                txtAdministrator.Text = korsnik.Ime + " " + korsnik.Prezime;

                var Klijent = await _apiservicek.GetById<Model.Klijent>(result.KlijentId);
                txtKlijent.Text = Klijent.Ime + " " + Klijent.Prezime;

                var nagrada = await _apiservicen.GetById<Model.Nagrada>(result.NagradaId);
                txtNagrada.Text = nagrada.Naziv;

                NagradnaIgra.NagradaId = result.NagradaId;
                NagradnaIgra.KorisnikId = result.KorisnikId;
                NagradnaIgra.KlijentId = result.KlijentId;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                NagradnaIgra.DatumPocetka = dtpDatumPocetka.Value;
                NagradnaIgra.DatumZavrsetka = dtpDatumZavrsetka.Value;
                NagradnaIgra.Opis = txtOpis.Text;


          
                Model.NagradnaIgra entity = null;
                if (_id.HasValue)
                {
                    NagradnaIgra.NagradnaIgraId = _id.Value;
                    entity = await _apiservice.Update<Model.NagradnaIgra>(_id.Value, NagradnaIgra);
                }
               
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno!");
                    this.Close();

                }
            }
        }



        private void txtOpis_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text) || txtOpis.Text.Length < 3)
            {
                e.Cancel = true;
                error.SetError(txtOpis, "Ovo polje je obavezno i mora imati vise od 3 karaktera!");
            }
            else
            {
                error.SetError(txtOpis, null);
            }
        }
    }
}
