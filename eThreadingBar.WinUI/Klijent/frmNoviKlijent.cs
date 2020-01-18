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
    public partial class frmNoviKlijent : Form
    {
        private readonly APIService _apiservicekorisnik = new APIService("Klijent");
        private readonly APIService _apiservicegrad = new APIService("Grad");

        private int? _id = null;

        public frmNoviKlijent(int? Id = null)
        {
            InitializeComponent();
            _id = Id;
        }

      
        private async void frmNoviKlijent_Load_1(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _apiservicekorisnik.GetById<Model.Klijent>(_id);
                lblKlijent.Text = result.Ime + " " + result.Prezime;
                txtIme.Text=result.Ime;
               txtprezime.Text=result.Prezime;
               txtemail.Text=result.Email;
                txtbrojtelefona.Text=result.BrojTelefona;
                var grad = await _apiservicegrad.GetById<Model.Grad>(result.GradId);
                txtGrad.Text = grad.Naziv;

            }
        }
     
    
        KlijentInsertRequest request = new KlijentInsertRequest();
       
    }
}
