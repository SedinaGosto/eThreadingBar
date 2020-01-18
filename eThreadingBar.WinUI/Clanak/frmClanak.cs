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

namespace eThreadingBar.WinUI.Clanak
{
    public partial class frmClanak : Form
    {
        private readonly APIService _apiService = new APIService("ClanakDesktop");

        public frmClanak()
        {
            InitializeComponent();
        }

        private async void frmClanak_Load(object sender, EventArgs e)
           
        {
            try
            {
                var search = new ClanakSearchRequest()
                {
                    Naslov = txtNaslov.Text
                };
                var result = await _apiService.Get<List<Model.Clanak>>(search);
                dgvClanak.AutoGenerateColumns = false;
                dgvClanak.DataSource = result;
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

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new ClanakSearchRequest()
            {
                Naslov = txtNaslov.Text
            };
            var result = await _apiService.Get<List<Model.Clanak>>(search);
            dgvClanak.AutoGenerateColumns = false;
            dgvClanak.DataSource = result;
        }



        private void dgvClanak_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvClanak.SelectedRows[0].Cells[0].Value;
            frmClanakDetails frmdetalji = new frmClanakDetails(int.Parse(id.ToString()));
            frmdetalji.Show();
        }

        private async void btnRfereseh_Click(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Clanak>>(null);
            dgvClanak.AutoGenerateColumns = false;
            dgvClanak.DataSource = result;
        }

        private void btnDodajClanak_Click(object sender, EventArgs e)
        {
            frmClanakDetails nova = new frmClanakDetails();
            nova.Show();
        }
    }
}
