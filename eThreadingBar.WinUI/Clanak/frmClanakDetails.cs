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

namespace eThreadingBar.WinUI.Clanak
{
    public partial class frmClanakDetails : Form
    {
        private int? _id = null;
        private readonly APIService _clanakKtegorije = new APIService("clanakkategorija");
        private readonly APIService _clanak = new APIService("ClanakDesktop");
        public frmClanakDetails(int? Id = null)
        {
            InitializeComponent();
            _id = Id;
        }
        private async Task LoadClanakKtegorija()
        {
            
                var result = await _clanakKtegorije.Get<List<Model.ClanakKategorija>>(null);

                cmbClanakKategroija.DisplayMember = "Naziv";
                cmbClanakKategroija.ValueMember = "ClanciKategorijaId";
                cmbClanakKategroija.DataSource = result;


        }
           
            
           
        

        ClanakInsertRequest model = new ClanakInsertRequest();
        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;
                var file = File.ReadAllBytes(filename);
                model.Slika = file;
                txtSlika.Text = filename;
                Image image = Image.FromFile(filename);
                pictureBox.Image = image;
               
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var idObj = cmbClanakKategroija.SelectedValue;

                if (int.TryParse(idObj.ToString(), out int KategorijaId))
                {
                    model.ClanciKategorijaId = KategorijaId;
                }
                model.Naslov = txtNaslov.Text;
                model.Podnaslov = txtPodnaslov.Text;
                model.TekstClanka = rtxtSadrzaj.Text;
                model.DatumObjave = dtpDatumKreiranja.Value;
          
                Model.Clanak entity = null;
               
                    if (_id.HasValue)
                    {
                        model.ClanakId = _id.Value;
                        entity = await _clanak.Update<Model.Clanak>(_id.Value, model);
                    }
                    else
                    {
                        entity = await _clanak.Insert<Model.Clanak>(model); ;
                    }
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno izvršeno");
                        this.Close();

                    }
                
            }

          
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

      
        private async void frmClanakDetails_Load(object sender, EventArgs e)
        {
            
            await LoadClanakKtegorija();
                if (_id.HasValue)
                {
                    var result = await _clanak.GetById<Model.Clanak>(_id);
                    txtNaslov.Text = result.Naslov;
                    txtPodnaslov.Text = result.Podnaslov;
                    rtxtSadrzaj.Text = result.TekstClanka;
                    dtpDatumKreiranja.Value = result.DatumObjave;
                    var kategorija = await _clanakKtegorije.GetById<Model.ClanakKategorija>(result.ClanciKategorijaId);
                    cmbClanakKategroija.SelectedIndex = cmbClanakKategroija.FindStringExact(kategorija.Naziv);
                    if (result.Slika.Length > 0)
                    {
                    model.Slika = result.Slika;
                        pictureBox.Image = BaytesToImage(result.Slika);
                    }
                    label1.Text = result.Naslov;
                    btnDodajSliku.Text = "Promijeni sliku";

                }
           
        }
        private Image BaytesToImage(byte[] slika)
        {
            MemoryStream m = new MemoryStream(slika);
           return Image.FromStream(m);
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text) || txtNaslov.Text.Length < 3)
            {
                e.Cancel = true;
                error.SetError(txtNaslov, "Ovo polje je obavezno i mora imati vise od 3 karaktera!");
            }
            else
            {
                error.SetError(txtNaslov, null);
            }
        }

        private void txtPodnaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPodnaslov.Text) || txtPodnaslov.Text.Length < 10)
            {
                e.Cancel = true;
                error.SetError(txtNaslov, "Ovo polje je obavezno i mora imati vise od 10 karaktera!");
            }
            else
            {
                error.SetError(txtNaslov, null);
            }
        }

        private void cmbClanakKategroija_Validating(object sender, CancelEventArgs e)
        {

        }

        private void rtxtSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            
                if (string.IsNullOrWhiteSpace(rtxtSadrzaj.Text) || rtxtSadrzaj.Text.Length < 20)
                {
                    e.Cancel = true;
                    error.SetError(txtNaslov, "Ovo polje je obavezno i mora imati vise od 20 karaktera!");
                }
                else
                {
                    error.SetError(txtNaslov, null);
                }
            
        }
    }
}
