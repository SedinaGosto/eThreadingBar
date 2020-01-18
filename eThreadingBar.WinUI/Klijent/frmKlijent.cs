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

namespace eThreadingBar.WinUI.Klijent
{
   

    public partial class frmKlijent : Form
    {
        private readonly APIService _apiService = new APIService("Klijent");
        public frmKlijent()
        {
            InitializeComponent();
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new KlijentSearchRequest()
            {
                
                Ime=txtIme.Text,
                Prezime=txtPrezime.Text
            };

            var list = await _apiService.Get<List<Model.Klijent>>(search);
            dgvKlijenti.AutoGenerateColumns = false;

            dgvKlijenti.DataSource = list;
        }

        private void dgvKlijenti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;
            frmNoviKlijent frmdetalji = new frmNoviKlijent(int.Parse(id.ToString()));
            frmdetalji.Show();
        }

        private async void frmKlijent_Load(object sender, EventArgs e)
        {
            var list = await _apiService.Get<List<Model.Klijent>>(null);
            dgvKlijenti.AutoGenerateColumns = false;

            dgvKlijenti.DataSource = list;
        }
    }
}
