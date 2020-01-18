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

namespace eThreadingBar.WinUI.Izvjestaji
{
    public partial class frmIzvjestajpoTretmanu : Form
    {
        public APIService _rezervacije = new APIService("Rezervacija");
        public APIService _tretmani = new APIService("Tretman");

        public frmIzvjestajpoTretmanu()
        {
            InitializeComponent();
        }

        private void frmIzvjestajpoTretmanu_Load(object sender, EventArgs e)
        {
            LoadGodine();
        }
        private void LoadGodine()
        {
            var gZ = DateTime.Now.AddYears(5).Year;
            var gP = 2020;
            for (int i = gP; i <= gZ; i++)
            {
                cmbGodine.Items.Add(i);
            }
            cmbGodine.Text = "--Odaberite godinu--";
        }

        private async Task LoadIzvjestaj(int idGodine)
        {
            int zarada = 0;
            int ukupnazarada = 0;
            int brojrezervacija = 0;
            var tretmani = await _tretmani.Get<List<Model.Tretman>>(null);
            List<Model.IzvjestajPoTretmanu> lista = new List<Model.IzvjestajPoTretmanu>();
            if (chartIzvjestaj.Series["Tretman"].Points.Count > 0)
            {
                chartIzvjestaj.Series["Tretman"].Points.Clear();
             

            }
            foreach (var t in tretmani)
            {
                var rezervacije = await _rezervacije.Get<List<Model.Rezervacija>>(new RezervacijaSearchRequest { Godina = idGodine, TretmanId = t.TretmanId });
                foreach(var r in rezervacije)
                {
                    zarada += t.Cijena;
                    brojrezervacija++;
                }
                if (rezervacije.Count() > 0)
                {
                    chartIzvjestaj.Series["Tretman"].Points.AddXY(t.Naziv, zarada);

                    lista.Add(new Model.IzvjestajPoTretmanu() { Tretman = t.Naziv, ZaradapoTretmanu = zarada, BrojRezervacija = brojrezervacija });
                }
                ukupnazarada += zarada;
                brojrezervacija = 0;
                zarada = 0;
            }
            labelukupnazarada.Text = "Ukupna zarada za " + idGodine.ToString() + ".godinu je: " + ukupnazarada.ToString() + " KM";
            chartIzvjestaj.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chartIzvjestaj.ChartAreas[0].AxisX.Interval=1;
            dgvIzvjestaji.AutoGenerateColumns = false;
            dgvIzvjestaji.DataSource = lista;
          
        }

        private async void cmbGodine_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbGodine.SelectedItem;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadIzvjestaj(id);

            }
        }

        
    }
}
