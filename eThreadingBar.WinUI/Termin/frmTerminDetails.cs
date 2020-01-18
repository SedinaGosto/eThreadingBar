using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;

namespace eThreadingBar.WinUI.Termin
{
    public partial class frmTerminDetails : Form
    {
        private int? _id = null;
        private readonly APIService _termin = new APIService("termin");
        private readonly APIService _korisnik= new APIService("korisnici");
        public  frmTerminDetails(int? Id = null)
        {
            InitializeComponent();
            _id = Id;

        }
        private async Task LoadKorisnici()
        {
            var result = await _korisnik.Get<List<Model.Korisnici>>(null);

            cmbKorisnik.DisplayMember = "Ime";
            cmbKorisnik.ValueMember = "KorisnikId";
            cmbKorisnik.DataSource = result;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            
                var idObj = cmbKorisnik.SelectedValue;
                TerminInsertRequest model = new TerminInsertRequest();
                if (int.TryParse(idObj.ToString(), out int uposlenikId))
                {
                    model.KorisnikId = uposlenikId;
                }
                model.VrijemeTermina = dtpVrijemeTermina.Value.Date + dtpVrijemeTermina.Value.TimeOfDay;
                model.Rezervisan = cbRezervisan.Checked;
              

                Model.Termin entity = null;
                if (_id.HasValue)
                {
                    model.Id = _id.Value;
                    entity = await _termin.Update<Model.Termin>(_id.Value, model);
                }
                else
                {
                    entity = await _termin.Insert<Model.Termin>(model); ;
                }
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    this.Close();

                }
            
        }

        private async void frmTerminDetails_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
            dtpVrijemeTermina.Format = DateTimePickerFormat.Custom;
            dtpVrijemeTermina.CustomFormat = "dd/MM/yyyy hh:mm";
            if (_id.HasValue)
            {
                var result = await _termin.GetById<Model.Termin>(_id);

                var kategorija = await _korisnik.GetById<Model.Korisnici>(result.KorisnikId);
                cmbKorisnik.SelectedIndex = cmbKorisnik.FindStringExact(kategorija.Ime + " " + kategorija.Prezime);
                dtpVrijemeTermina.Value = result.VrijemeTermina.Date + result.VrijemeTermina.TimeOfDay;
                cbRezervisan.Checked = result.Rezervisan;

            }
            else
                label1.Text = "Novi termin";
        }

        private void cmbKorisnik_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Model.Korisnici)e.ListItem).Ime;
            string prezime = ((Model.Korisnici)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }
    }
}
