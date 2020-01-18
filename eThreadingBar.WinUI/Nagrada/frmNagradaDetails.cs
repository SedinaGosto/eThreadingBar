using eThreadingBar.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eThreadingBar.WinUI.Nagrada
{
    public partial class frmNagradaDetails : Form
    {
        private int? _id = null;
        private readonly APIService _apiservice = new APIService("nagrada");
        public frmNagradaDetails(int? Id = null)
        {
            InitializeComponent();
            _id = Id;
        }
        NagradaInsertRequest model = new NagradaInsertRequest();
        private async void frmNagradaDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                naslovnagrada.Text = "Detalji nagrade";
                var result = await _apiservice.GetById<Model.Nagrada>(_id);
                txtNaziv.Text = result.Naziv;

                if (result.Photo!=null && result.Photo.Length > 0)
                {
                    model.Photo = result.Photo;
                    Slika.Image = BaytesToImage(model.Photo);
                }

            }
            else
                naslovnagrada.Text = "Nova nagrada";
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                model.Naziv = txtNaziv.Text;
                Model.Nagrada entity = null;
                if (_id.HasValue)
                {
                    model.NagradaId = _id.Value;
                    entity = await _apiservice.Update<Model.Nagrada>(_id.Value, model);
                }
                else
                {
                    entity = await _apiservice.Insert<Model.Nagrada>(model);
                }
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno!");
                    this.Close();

                }
            }
        }
        private Image BaytesToImage(byte[] slika)
        {
            MemoryStream m = new MemoryStream(slika);
            return Image.FromStream(m);
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }


        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || txtNaziv.Text.Length < 3)
            {
                e.Cancel = true;
                error.SetError(txtNaziv, "Ovo polje je obavezno i mora imati vise od 3 karaktera!");
            }
            else
            {
                error.SetError(txtNaziv, null);
            }
        }
    

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;
                var file = File.ReadAllBytes(filename);
                model.Photo = file;
                txtSlika.Text = filename;
                Image image = Image.FromFile(filename);
                Slika.Image = image;

            }
        }
    }
}
