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

namespace eThreadingBar.WinUI.Tretman
{
    public partial class frmTretman : Form
    {
        private readonly APIService _apiService = new APIService("tretman");

        public frmTretman()
        {
            InitializeComponent();
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new TretmanSearchRequest()
            {
                Naziv = txtNaziv.Text
            };
            var result = await _apiService.Get<List<Model.Tretman>>(search);
            dgvTretmani.AutoGenerateColumns = false;
            dgvTretmani.DataSource = result;
        }

        private void dgvTretmani_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var TretmanId = dgvTretmani.SelectedRows[0].Cells[0].Value;
            frmTretmanDetalji frmdetalji = new frmTretmanDetalji(int.Parse(TretmanId.ToString()));
            frmdetalji.Show();
        }

        private async  void frmTretman_Load(object sender, EventArgs e)
        {
            var search = new TretmanSearchRequest()
            {
                Naziv = txtNaziv.Text
            };
            var result = await _apiService.Get<List<Model.Tretman>>(search);
            dgvTretmani.AutoGenerateColumns = false;
            dgvTretmani.DataSource = result;
        }
    }
}
