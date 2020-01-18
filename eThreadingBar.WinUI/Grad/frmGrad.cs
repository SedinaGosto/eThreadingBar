using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eThreadingBar.Model.Requests;

namespace eThreadingBar.WinUI.Grad
{
    public partial class frmGrad : Form
    {
        private readonly APIService _apiService = new APIService("grad");
        public frmGrad()
        {
            InitializeComponent();
        }

        private async void  btn_Prikazi_Click(object sender, EventArgs e)
        {
            var search = new GradSearchRequest()
            {
                Naziv = txtPretrazi.Text
            };
            var result = await _apiService.Get<List<Model.Grad>>(search);
            dgvGradovi.AutoGenerateColumns = false;
            dgvGradovi.DataSource = result;
        }

        private async void frmGrad_Load(object sender, EventArgs e)
        {
            var search = new GradSearchRequest()
            {
                Naziv = txtPretrazi.Text
            };
            var result = await _apiService.Get<List<Model.Grad>>(search);
            dgvGradovi.AutoGenerateColumns = false;
            dgvGradovi.DataSource = result;
        }

        private void dgvGradovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvGradovi.SelectedRows[0].Cells[0].Value;
            frmGradDetalji frmdetalji = new frmGradDetalji(int.Parse(id.ToString()));
            frmdetalji.Show();
        }
    }
}
