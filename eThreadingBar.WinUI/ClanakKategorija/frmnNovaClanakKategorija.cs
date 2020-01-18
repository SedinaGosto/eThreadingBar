using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eThreadingBar.Model.Requests;

namespace eThreadingBar.WinUI.ClanakKategorija
{
    public partial class frmnNovaClanakKategorija : Form
    {
        private int? _id = null;
        private readonly APIService _apiService = new APIService("ClanakKategorijaDesktop");

        public frmnNovaClanakKategorija(int? Id = null)
        {
            InitializeComponent();
            _id = Id;
        }

        private async  void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                
               
              
                   
                    Model.ClanakKategorija entity = null;
                if (_id.HasValue)
                {
                    entity = await _apiService.Update<Model.ClanakKategorija>(_id.Value, new ClanakKategorijaInsertRequest
                    {


                        DatumKreiranja = DateTime.Now,
                        Naziv = txtNaziv.Text,
                        Id = _id.Value
                    });
                }
                else
                {

                    var list = await _apiService.Get<List<Model.ClanakKategorija>>(new ClanakKategorijaSearchRequest { Naziv = txtNaziv.Text });

                    if (list.Count>0)
                    {
                        MessageBox.Show("Vec postoji slicna kategorija!");
                        txtNaziv.Text = " ";
                    }
                    else
                    {
                        var Kategorija = new ClanakKategorijaInsertRequest
                        {
                            DatumKreiranja = DateTime.Now,
                            Naziv = txtNaziv.Text
                        };

                        entity = await _apiService.Insert<Model.ClanakKategorija>(Kategorija);


                       
                    }
                }
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    this.Close();

                }
            }
            

        }

        private void textNaziv_Validating(object sender, CancelEventArgs e)
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

        private async void frmnNovaClanakKategorija_Load(object sender, EventArgs e)
        {
            try
            {
                var list = await _apiService.Get<dynamic>(null);
                if(_id.HasValue)
                {
                    var kategorija = await _apiService.GetById<Model.ClanakKategorija>(_id.Value);
                    txtNaziv.Text = kategorija.Naziv;
                    lblNaslov.Text = "Detelji o kategoriji";

                }

            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Nemate pravo pristupa!");
                if (r == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
