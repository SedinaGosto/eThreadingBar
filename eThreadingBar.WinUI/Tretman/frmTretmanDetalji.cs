using eThreadingBar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eThreadingBar.WinUI.Tretman
{
    public partial class frmTretmanDetalji : Form
    {
        private int? _id = null;
        private readonly APIService _apiservice = new APIService("tretman");

        public frmTretmanDetalji(int? Id = null)
        {
            InitializeComponent();
            _id = Id;
        }

        private async void btnScuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var tretman = new TretmanInsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    Cijena = int.Parse(txtCijena.Text.ToString())

                };
                Model.Tretman entity = null;
                if (_id.HasValue)
                {
                    entity = await _apiservice.Update<Model.Tretman>(_id.Value, tretman);
                }
                else
                {
                    entity = await _apiservice.Insert<Model.Tretman>(tretman);
                }
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    this.Close();

                }
            }
        }

        private async void frmTretmanDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _apiservice.GetById<Model.Tretman>(_id);
                txtNaziv.Text = result.Naziv;
                txtCijena.Text = result.Cijena.ToString();
                lblTretman.Text = "Detalji o tretmanu";
            }
            else
                lblTretman.Text = "Novi tretman";
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                error.SetError(txtNaziv, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
           
            else
                error.SetError(txtNaziv, null);
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                error.SetError(txtCijena, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtCijena.Text, @"^[0-9]+$"))
            {
                error.SetError(txtCijena, "Cijena mora da sadrzi samo brojeve");
                e.Cancel = true;
            }
            else
                error.SetError(txtCijena, null);
        }
    }
}
