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
    public partial class frmNagrada : Form
    {
        private readonly APIService _apiService = new APIService("nagrada");
        private readonly APIService _apiServicenagradnaigra = new APIService("nagradnaigra");


        public frmNagrada()
        {
            InitializeComponent();
        }
   
        private async void frmNagrada_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadNagrada();
                var result = await _apiService.Get<List<Model.Nagrada>>(null);
                dgvNagrade.AutoGenerateColumns = false;
                dgvNagrade.DataSource = result;


                var result2 = await _apiServicenagradnaigra.Get<List<Model.NagradnaIgra>>(null);
                dgvNagradneIgre.AutoGenerateColumns = false;
                dgvNagradneIgre.DataSource = result2;
             
            }
            catch(Exception)
            {
                DialogResult r=MessageBox.Show("Nemate pravo pristupa!");
                if(r==DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        private async Task LoadNagrada()
        {
            var result = await _apiService.Get<List<Model.Nagrada>>(null);
            result.Insert(0, new Model.Nagrada());
            cmbNagrade.DisplayMember = "Naziv";
            cmbNagrade.ValueMember = "NagradaId";

            cmbNagrade.DataSource = result;
        }
        private void dgvNagrade_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvNagrade.SelectedRows[0].Cells[0].Value;
            frmNagradaDetails frmdetalji = new frmNagradaDetails(int.Parse(id.ToString()));
            frmdetalji.Show();
        }

        private void btnNovaNagrada_Click(object sender, EventArgs e)
        {
            frmNagradaDetails frmdetalji = new frmNagradaDetails();
            frmdetalji.Show();
        }

        private async void Refresh_Click(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Nagrada>>(null);
            dgvNagrade.AutoGenerateColumns = false;
            dgvNagrade.DataSource = result;

            var result2 = await _apiServicenagradnaigra.Get<List<Model.NagradnaIgra>>(null);
            dgvNagradneIgre.AutoGenerateColumns = false;
            dgvNagradneIgre.DataSource = result2;
        }

        private void btnevidentiraj_Nagradnu_Igru_Click(object sender, EventArgs e)
        {
            frmNovaNagradnaIgra frmnovaNagradnaIgra = new frmNovaNagradnaIgra();
            frmnovaNagradnaIgra.Show();
        }

        private void dgvNagradneIgre_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvNagradneIgre.SelectedRows[0].Cells[0].Value;
            frmNagradnaIgraDetails frmdetalji = new frmNagradnaIgraDetails(int.Parse(id.ToString()));
            frmdetalji.Show();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Nagrada>>(new NagradaSearchRequest
            {
                Naziv = txtPretragaNagrada.Text
            }) ;
            dgvNagrade.AutoGenerateColumns = false;
            dgvNagrade.DataSource = result;
        }

        private async void cmbNagrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbNagrade.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadNagradneIgre(id);
            }
        }
        private async Task LoadNagradneIgre(int nagradaId)
        {
            var result = await _apiServicenagradnaigra.Get<List<Model.NagradnaIgra>>(new NagradnaIgraSearchRequest()
            {
               _NagradaId=nagradaId
            });
            dgvNagradneIgre.AutoGenerateColumns = false;
            dgvNagradneIgre.DataSource = result;
            if(nagradaId==0)
            {
                var result2 = await _apiServicenagradnaigra.Get<List<Model.NagradnaIgra>>(null);
                dgvNagradneIgre.AutoGenerateColumns = false;
                dgvNagradneIgre.DataSource = result2;
            }
        }

    }
}
