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

namespace eThreadingBar.WinUI.Termin
{
    public partial class frmTermin : Form
    {
        private readonly APIService _korisnici = new APIService("korisnici");
        private readonly APIService _termin = new APIService("termin");
        public frmTermin()
        {
            InitializeComponent();
        }

        private async  void cmbUpolenici_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbUpolenici.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadTermini(id);
            }
        }

        private async Task LoadUposlenik()
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            result.Insert(0, new Model.Korisnici());
            cmbUpolenici.DisplayMember = "Ime";
            cmbUpolenici.ValueMember = "KorisnikId";
        
            cmbUpolenici.DataSource = result;
        }
        private async Task LoadTermini(int korisnikId)
        {
            if (korisnikId == 0)
            {
                var result = await _termin.Get<List<Model.Termin>>(null);

                dgvTermini.AutoGenerateColumns = false;
                dgvTermini.DataSource = result;
            }
            else
            {
                var result = await _termin.Get<List<Model.Termin>>(new TerminSearchRequest()
                {
                    UposlenikId = korisnikId
                });
                dgvTermini.AutoGenerateColumns = false;
                dgvTermini.DataSource = result;
            }
        }

        private async void frmTermin_Load(object sender, EventArgs e)
        {
            await LoadUposlenik();
            var result = await _termin.Get<List<Model.Termin>>(null);
           
            dgvTermini.AutoGenerateColumns = false;
            dgvTermini.DataSource = result;

        }

        private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Model.Korisnici)e.ListItem).Ime;
            string prezime = ((Model.Korisnici)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void dgvTermini_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTermini.SelectedRows[0].Cells[0].Value;
            frmTerminDetails frmdetalji = new frmTerminDetails(int.Parse(id.ToString()));
            frmdetalji.Show();
        }
    }
}
