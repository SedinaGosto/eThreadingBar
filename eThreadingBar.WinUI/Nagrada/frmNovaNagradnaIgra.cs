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
    public partial class frmNovaNagradnaIgra : Form
    {
        private readonly APIService _apiservice = new APIService("nagradnaigra");
        private readonly APIService _apiservicek = new APIService("Klijent");
        private readonly APIService _apiservicea = new APIService("Korisnici");
        private readonly APIService _apiservicen = new APIService("nagrada");


        public frmNovaNagradnaIgra()
        {
            InitializeComponent();
        }
        NagradnaIgraInsertRequest request = new NagradnaIgraInsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var kId = cmbKlijent.SelectedValue;
                var nId = cmbNagrada.SelectedValue;
                var aId = cmbAdministrator.SelectedValue;



                if (int.TryParse(kId.ToString(), out int _klijentId))
                {
                    request.KlijentId = _klijentId;
                }
                if (int.TryParse(aId.ToString(), out int _administratorId))
                {
                    request.KorisnikId = _administratorId;
                }
                if (int.TryParse(nId.ToString(), out int _nagradaId))
                {
                    request.NagradaId = _nagradaId;
                }

                request.DatumPocetka = dtpDatumpocetka.Value;
                request.DatumZavrsetka = dtpDatumZavrsetka.Value;
                request.Opis = rtxtOpis.Text;

                Model.NagradnaIgra entity = null;

                entity = await _apiservice.Insert<Model.NagradnaIgra>(request);
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    this.Close();

                }
            }
        }
        private async Task LoadKorisnici()
        {
            var result = await _apiservicek.Get<List<Model.Klijent>>(null);

            cmbKlijent.DisplayMember = "Ime";
            cmbKlijent.ValueMember = "KlijentId";
            cmbKlijent.DataSource = result;
        }
        private async Task LoadAdministrator()
        {
            var result = await _apiservicea.Get<List<Model.Korisnici>>(null);

            cmbAdministrator.DisplayMember = "Ime";
            cmbAdministrator.ValueMember = "KorisnikId";
            cmbAdministrator.DataSource = result;
        }
        private async Task LoadNagrada()
        {
            var result = await _apiservicen.Get<List<Model.Nagrada>>(null);
           
            cmbNagrada.DisplayMember = "Naziv";
            cmbNagrada.ValueMember = "NagradaId";
            cmbNagrada.DataSource = result;
        }

        private async void frmNovaNagradnaIgra_Load(object sender, EventArgs e)
        {

            await LoadAdministrator();
            await LoadKorisnici();
            await LoadNagrada();

        }

     

        private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Model.Korisnici)e.ListItem).Ime;
            string prezime = ((Model.Korisnici)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;

        }

        private void KlijentcmbFormat(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Model.Klijent)e.ListItem).Ime;
            string prezime = ((Model.Klijent)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void rtxtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtOpis.Text) || rtxtOpis.Text.Length < 3)
            {
                e.Cancel = true;
                error.SetError(rtxtOpis, "Ovo polje je obavezno i mora imati vise od 3 karaktera!");
            }
            else
            {
                error.SetError(rtxtOpis, null);
            }
        }
    }
}
