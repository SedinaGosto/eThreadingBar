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
    public partial class frmKorisnikDetails : Form
    {
        APIService _service = new APIService("Korisnici");
        private int? _id = null;
        public frmKorisnikDetails(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmKorisnikDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var entity = await _service.GetById<Model.Korisnici>(_id);
                txtKorisnik.Text = entity.Ime + " " + entity.Prezime;
                txtEmail.Text = entity.Email;
                txtIme.Text = entity.Ime;
                txtKorisnickoIme.Text = entity.KorisnickoIme;
                txtPrezime.Text = entity.Prezime;
                txtTelefon.Text = entity.Telefon;
                if(entity.Status==true)
                {
                    cbAktivan.Checked = true;
                }
                if (entity.Slika.Length > 0)
                {
                    pictureBox.Image = BaytesToImage(entity.Slika);
                    model.Slika = entity.Slika;
                }
            }
        }
        private Image BaytesToImage(byte[] slika)
        {
            MemoryStream m = new MemoryStream(slika);
            return Image.FromStream(m);
        }
        KorisniciInsertRequest model = new KorisniciInsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                model.Email = txtEmail.Text;
                model.Ime = txtIme.Text;
                model.KorisnickoIme = txtKorisnickoIme.Text;
                model.Prezime = txtPrezime.Text;
                model.Telefon = txtTelefon.Text;
                model.Password = txtPassword.Text;
                model.PasswordPotvrda = txtPotvrdaPassworda.Text;
                model.KorisnikId = _id.Value;
                if(cbAktivan.Checked==true)
                {
                    model.Status = true;
                }
                else
                model.Status = false;
                Model.Korisnici entity = null;
                entity = await _service.Update<Model.Korisnici>(_id.Value, model);
                if (entity != null)
                {
                    DialogResult r = MessageBox.Show("Podaci su izmijenjeni! Morate se ponovo prijaviti!");
                    if (r == DialogResult.OK)
                    {
                        Application.Restart();
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
                error.SetError(txtIme, "Ime smije da sadrzi samo slova");
                e.Cancel = true;
            }
            else
                error.SetError(txtIme, null);
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
                error.SetError(txtPrezime, "Ime mora da sadrzi samo slova!");
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

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                error.SetError(txtKorisnickoIme, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtTelefon.Text, @"^?\(?\d{3}?\)??-??\(?\d{3}?\)??-??\(?\d{3,}?\)??-?$"))
            {
                e.Cancel = true;
                error.SetError(txtTelefon, "Neispravan format. Ovo polje mora biti u formatu (036)576-678 ili 123-456-7890 ili 045678543");
            }
            else
            {
                error.SetError(txtTelefon, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                error.SetError(txtKorisnickoIme, "Ovo polje je obavezno.");
                e.Cancel = true;
            }
            else if (txtKorisnickoIme.Text.Length < 3)
            {
                error.SetError(txtKorisnickoIme, "Mora da sadrzi minimalno 3 slova.");
                e.Cancel = true;
            }
            else
                error.SetError(txtKorisnickoIme, null);
        }
        //public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        //{
        //    using (var ms = new MemoryStream())
        //    {
        //        imageIn.Save(ms, imageIn.RawFormat);
        //        return ms.ToArray();
        //    }
        //}
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
