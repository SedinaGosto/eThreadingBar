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

namespace eThreadingBar.WinUI.Korisnik
{
    public partial class frmKorisnik : Form
    {
        APIService _apiService = new APIService("korisnici");

        public frmKorisnik()
        {
            InitializeComponent();
        }

        private async void frmKorisnik_Load(object sender, EventArgs e)
        {
            var list = await _apiService.Get<List<Model.Korisnici>>(null);
            dgvKorisnici.AutoGenerateColumns = false;

            dgvKorisnici.DataSource = list;
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var korisnikId = int.Parse(dgvKorisnici.SelectedRows[0].Cells[0].Value.ToString());

            frmKorisnikDetails frm = new frmKorisnikDetails(korisnikId);
            frm.Show();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime=txtPrezime.Text
               
            };

            var list = await _apiService.Get<List<Model.Korisnici>>(search);
            dgvKorisnici.AutoGenerateColumns = false;

            dgvKorisnici.DataSource = list;
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            frmNoviKorisnik novi = new frmNoviKorisnik();
            novi.Show();
        }
    }
}
