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

namespace eThreadingBar.WinUI.ClanakKategorija
{
    public partial class frmClanakKategorija : Form
    {
        private readonly APIService _apiService = new APIService("ClanakKategorijaDesktop");

        public frmClanakKategorija()
        {
            InitializeComponent();
        }

        private async void frmClanakKategorija_Load(object sender, EventArgs e)
        {
            try
            {
                var result = await _apiService.Get<List<Model.ClanakKategorija>>(null);
                dgvClanakKategorija.AutoGenerateColumns = false;
                dgvClanakKategorija.DataSource = result;
            }
            catch(Exception)
            {
                DialogResult r = MessageBox.Show("Nemate pravo pristupa!");
                if (r == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btnNovaKtegorija_Click(object sender, EventArgs e)
        {
            frmnNovaClanakKategorija nova = new frmnNovaClanakKategorija();
            nova.Show();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.ClanakKategorija>>(null);
            dgvClanakKategorija.AutoGenerateColumns = false;
            dgvClanakKategorija.DataSource = result;
        }

        private void dgvClanakKategorija_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvClanakKategorija.SelectedRows[0].Cells[0].Value;
            frmnNovaClanakKategorija frmdetalji = new frmnNovaClanakKategorija(int.Parse(id.ToString()));
            frmdetalji.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.ClanakKategorija>>(new ClanakKategorijaSearchRequest { 
            Naziv=txtPretraga.Text
            });
            dgvClanakKategorija.AutoGenerateColumns = false;
            dgvClanakKategorija.DataSource = result;
        }
    }
}
