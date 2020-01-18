using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using eThreadingBar.WinUI.Clanak;
using eThreadingBar.WinUI.ClanakKategorija;
using eThreadingBar.WinUI.Grad;
using eThreadingBar.WinUI.Izvjestaji;
using eThreadingBar.WinUI.Klijent;
using eThreadingBar.WinUI.Korisnik;
using eThreadingBar.WinUI.Nagrada;
using eThreadingBar.WinUI.PoslataNotifikacija;
using eThreadingBar.WinUI.Termin;
using eThreadingBar.WinUI.Tretman;

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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;
 
        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrad frmGrad = new frmGrad();
            frmGrad.MdiParent = this;
            frmGrad.WindowState = FormWindowState.Maximized;
            frmGrad.Show();
        }

        private void dodajNoviGradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradDetalji frmGrad = new frmGradDetalji();

            frmGrad.Show();
        }

    

        private void prikaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKlijent frmGrad = new frmKlijent();
            frmGrad.MdiParent = this;
            frmGrad.WindowState = FormWindowState.Maximized;
            frmGrad.Show();
        }

        private void noviKlijentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmNoviKlijent frmGrad = new frmNoviKlijent();

            frmGrad.Show();
        }

        private void pretraziToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmTretman frmTretman = new frmTretman();
            frmTretman.MdiParent = this;
            frmTretman.WindowState = FormWindowState.Maximized;
            frmTretman.Show();

        }

        private void dodajTretmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTretmanDetalji frmtretman = new frmTretmanDetalji();
            frmtretman.Show();
        }

        private void tretmanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanakKategorija frmclanakKategorija = new frmClanakKategorija();
            frmclanakKategorija.MdiParent = this;
            frmclanakKategorija.WindowState = FormWindowState.Maximized;
            frmclanakKategorija.Show();
        }

     

        private void ngradneIgreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNagrada frmUposlenik = new frmNagrada();
            frmUposlenik.MdiParent = this;
            frmUposlenik.WindowState = FormWindowState.Maximized;
            frmUposlenik.Show();
        }

        private void pretraziTermineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTermin frmTermin = new frmTermin();
            frmTermin.MdiParent = this;
            frmTermin.WindowState = FormWindowState.Maximized;
            frmTermin.Show();
        }

        private void korisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnik frmTermin = new frmKorisnik();
            frmTermin.MdiParent = this;
            frmTermin.WindowState = FormWindowState.Maximized;
            frmTermin.Show();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmNoviKorisnik frmGrad = new frmNoviKorisnik();

            frmGrad.Show();
        }

        private void prikaziToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClanak frmClanak = new frmClanak();
            frmClanak.MdiParent = this;
            frmClanak.WindowState = FormWindowState.Maximized;
            frmClanak.Show();
        }

        private void kreirajClanakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanakDetails frmClanak = new frmClanakDetails();

            frmClanak.Show();
        }

        private void noviTerminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmTerminDetails frmClanak = new frmTerminDetails();

            frmClanak.Show();
        }

        private void novostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanak frmClanak = new frmClanak();
            frmClanak.MdiParent = this;
            frmClanak.WindowState = FormWindowState.Maximized;
            frmClanak.Show();
        }

        private void linkOdjaviSe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void izvjestajPoTretmanimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvjestajpoTretmanu izvjestaj = new frmIzvjestajpoTretmanu();
            izvjestaj.MdiParent = this;
            izvjestaj.WindowState = FormWindowState.Maximized;
            izvjestaj.Show();
        }

        private void izvjestajPoKlijentimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrIzvjestajpoKlijentima izvjestaj = new fmrIzvjestajpoKlijentima();
            izvjestaj.MdiParent = this;
            izvjestaj.WindowState = FormWindowState.Maximized;
            izvjestaj.Show();
        }

        private void izvjestajPoUposlenikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvjestajpoUposleniku izvjestaj = new frmIzvjestajpoUposleniku();
            izvjestaj.MdiParent = this;
            izvjestaj.WindowState = FormWindowState.Maximized;
            izvjestaj.Show();
        }
        
        private  void frmIndex_Load(object sender, EventArgs e)
        {
            frmPrikazNotifikacija frmGrad = new frmPrikazNotifikacija();
            frmGrad.MdiParent = this;
            frmGrad.WindowState = FormWindowState.Maximized;
            frmGrad.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void zahtjeviZaRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazNotifikacija frmGrad = new frmPrikazNotifikacija();
            frmGrad.MdiParent = this;
            frmGrad.WindowState = FormWindowState.Maximized;
            frmGrad.Show();
        }
    }
}
