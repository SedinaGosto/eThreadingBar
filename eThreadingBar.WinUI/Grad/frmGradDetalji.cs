using eThreadingBar.Model.Requests;
using eThreadingBar.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eThreadingBar.WinUI.Grad
{
    public partial class frmGradDetalji : Form
    {
        private int? _id = null;
        private readonly APIService _apiservice=new APIService("grad");
        public frmGradDetalji(int? Id=null)
        {
            InitializeComponent();
            _id = Id;
           
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var grad = new GradInsertRequest()
                {
                    Naziv = txtNaziv.Text
                };
                Model.Grad entity = null;
                if (_id.HasValue)
                {
                    entity = await _apiservice.Update<Model.Grad>(_id.Value, grad);
                }
                else
                {
                    try
                    {
                        entity = await _apiservice.Insert<Model.Grad>(grad);
                    } 
                    catch(Exception)
                    {
                        MessageBox.Show("Niste autorizovani");
                    }
                }
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    this.Close();

                }
            }
        }

        private async void frmGradDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _apiservice.GetById<Model.Grad>(_id);
                txtNaziv.Text = result.Naziv;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || txtNaziv.Text.Length < 3)
            {
                e.Cancel = true;
                errorP.SetError(txtNaziv, "Ovo polje je obavezno i mora imati vise od 3 karaktera!");
            }
            else
            {
                errorP.SetError(txtNaziv, null);
            }
        }
    }
}
