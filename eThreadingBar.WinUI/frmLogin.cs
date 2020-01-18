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

namespace eThreadingBar.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");
        APIService _serviceLogin = new APIService("Klijent");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            APIService.Username = txtKorisnickoIme.Text;
            APIService.Password = txtPassword.Text;
            string username = txtKorisnickoIme.Text;
            List<Model.Klijent> lista = null;
            try
            {
                await _service.Get<dynamic>(null);
                lista = await _serviceLogin.Get<List<Model.Klijent>>(new KlijentSearchRequest { KorisnickoIme = username });
                if (lista.Count>0)
                {
                    Application.Restart();
                }
                else
                {
                    frmIndex frm = new frmIndex();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
              
            }
            catch (Exception ex)
            {

            }
        }
    }
}
