using eThreadingBar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eThreadingBar.WinUI.Korisnik
{
    public partial class frmNoviKorisnik : Form
    {
        APIService _service = new APIService("Korisnici");
        APIService _ulogeService = new APIService("Uloge");

      
        public frmNoviKorisnik()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void frmKorisnikDetails_Load(object sender, EventArgs e)
        {
            var ulogeList = await _ulogeService.Get<List<Model.Uloge>>(null);

            clbRole.DataSource = ulogeList;
            clbRole.DisplayMember = "Naziv";

          
        }
        KorisniciInsertRequest model = new KorisniciInsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var roleList = clbRole.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();
            if (this.ValidateChildren())
            {

                model.Email = txtEmail.Text;
                model.Ime = txtIme.Text;
                model.KorisnickoIme = txtKorisnickoime.Text;
                model.Password = txtPasword.Text;
                model.PasswordPotvrda = txtpotvrdaPasworda.Text;
                model.Prezime = txtPrezime.Text;
                model.Telefon = txtTelefon.Text;

               model.Uloge = roleList;

              if(cbAktivan.Checked)
                {
                    model.Status = true;
                }
                model.Status = false;

                var provjera = await _service.Get<List<Model.Korisnici>>(txtKorisnickoime.Text);
                if (provjera.Count > 0)
                {
                    DialogResult r = MessageBox.Show("Korisničko ime je zauzeto!");
                    if (r == DialogResult.OK)
                    {
                        txtKorisnickoime.Text = "";
                    }
                }
                else
                {
                    Model.Korisnici entity = null;

                    entity = await _service.Insert<Model.Korisnici>(model);



                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno izvršeno");
                        this.Close();
                    }
                }
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                error.SetError(txtIme, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtIme.Text, @"^[a-zA-Z ]+$"))
            {
                error.SetError(txtIme,"Ime smije da sadrzi samo slova");
                e.Cancel = true;
            }
            else
                error.SetError(txtIme, null);
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
          
            if (!Regex.IsMatch(txtTelefon.Text, @"^?\(?\d{3}?\)??-??\(?\d{3}?\)??-??\(?\d{3,}?\)??-?$"))
            {
                e.Cancel = true;
                error.SetError(txtTelefon, "Neispravan format. Ovo polje mora biti u formatu (036)576-678 ili 123-456-7890 ili 045678543");
            }
            else
            {
                error.SetError(txtTelefon, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                error.SetError(txtPrezime, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPrezime.Text, @"^[a-zA-Z ]+$"))
            {
                error.SetError(txtPrezime, "Prezime mora da sadrzi samo slova!");
                e.Cancel = true;
            }
            else
                error.SetError(txtPrezime, null);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                error.SetError(txtEmail, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                error.SetError(txtEmail, "Pravilan format example@example.com");
                e.Cancel = true;
            }
            else
                error.SetError(txtEmail, null);
        }

        private void txtKorisnickoime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoime.Text))
            {
                error.SetError(txtKorisnickoime, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
            else if (txtKorisnickoime.Text.Length<3)
            {
                error.SetError(txtKorisnickoime, "Mora da sadrzi minimalno 3 slova.");
                e.Cancel = true;
            }
            else
                error.SetError(txtKorisnickoime, null);
        }

        private void txtPasword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasword.Text))
            {
                error.SetError(txtPasword, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
            else
                error.SetError(txtPasword, null);

        }

        private void txtpotvrdaPasworda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpotvrdaPasworda.Text))
            {
                error.SetError(txtpotvrdaPasworda, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
            else
                error.SetError(txtpotvrdaPasworda, null);
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;
                var file = File.ReadAllBytes(filename);
                model.Slika = file;
                txtSlika.Text = filename;
                Image image = Image.FromFile(filename);
                pictureBox.Image = image;

            }
        }
    }
}
