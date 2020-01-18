namespace eThreadingBar.WinUI
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviGradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tretmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTretmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngradneIgreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziTermineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviTerminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajPoTretmanimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajPoKlijentimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajPoUposlenikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zahtjeviZaRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(865, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.tretmanToolStripMenuItem,
            this.uposleniciToolStripMenuItem,
            this.ngradneIgreToolStripMenuItem,
            this.terminToolStripMenuItem,
            this.korisnikToolStripMenuItem,
            this.novostiToolStripMenuItem,
            this.izvjestajiToolStripMenuItem,
            this.zahtjeviZaRezervacijeToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(865, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretraziToolStripMenuItem,
            this.dodajNoviGradToolStripMenuItem});
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.gradToolStripMenuItem.Text = "Grad";
            // 
            // pretraziToolStripMenuItem
            // 
            this.pretraziToolStripMenuItem.Name = "pretraziToolStripMenuItem";
            this.pretraziToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pretraziToolStripMenuItem.Text = "Pretrazi";
            this.pretraziToolStripMenuItem.Click += new System.EventHandler(this.pretraziToolStripMenuItem_Click);
            // 
            // dodajNoviGradToolStripMenuItem
            // 
            this.dodajNoviGradToolStripMenuItem.Name = "dodajNoviGradToolStripMenuItem";
            this.dodajNoviGradToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dodajNoviGradToolStripMenuItem.Text = "Dodaj novi grad";
            this.dodajNoviGradToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviGradToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            // 
            // prikaziToolStripMenuItem
            // 
            this.prikaziToolStripMenuItem.Name = "prikaziToolStripMenuItem";
            this.prikaziToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikaziToolStripMenuItem.Text = "Prikazi";
            this.prikaziToolStripMenuItem.Click += new System.EventHandler(this.prikaziToolStripMenuItem_Click);
            // 
            // tretmanToolStripMenuItem
            // 
            this.tretmanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretraziToolStripMenuItem1,
            this.dodajTretmanToolStripMenuItem});
            this.tretmanToolStripMenuItem.Name = "tretmanToolStripMenuItem";
            this.tretmanToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tretmanToolStripMenuItem.Text = "Tretman";
            this.tretmanToolStripMenuItem.Click += new System.EventHandler(this.tretmanToolStripMenuItem_Click);
            // 
            // pretraziToolStripMenuItem1
            // 
            this.pretraziToolStripMenuItem1.Name = "pretraziToolStripMenuItem1";
            this.pretraziToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.pretraziToolStripMenuItem1.Text = "Pretrazi";
            this.pretraziToolStripMenuItem1.Click += new System.EventHandler(this.pretraziToolStripMenuItem1_Click);
            // 
            // dodajTretmanToolStripMenuItem
            // 
            this.dodajTretmanToolStripMenuItem.Name = "dodajTretmanToolStripMenuItem";
            this.dodajTretmanToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dodajTretmanToolStripMenuItem.Text = "Dodaj tretman";
            this.dodajTretmanToolStripMenuItem.Click += new System.EventHandler(this.dodajTretmanToolStripMenuItem_Click);
            // 
            // uposleniciToolStripMenuItem
            // 
            this.uposleniciToolStripMenuItem.Name = "uposleniciToolStripMenuItem";
            this.uposleniciToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.uposleniciToolStripMenuItem.Text = "KategorijeClanka";
            this.uposleniciToolStripMenuItem.Click += new System.EventHandler(this.uposleniciToolStripMenuItem_Click);
            // 
            // ngradneIgreToolStripMenuItem
            // 
            this.ngradneIgreToolStripMenuItem.Name = "ngradneIgreToolStripMenuItem";
            this.ngradneIgreToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ngradneIgreToolStripMenuItem.Text = "Nagradne igre";
            this.ngradneIgreToolStripMenuItem.Click += new System.EventHandler(this.ngradneIgreToolStripMenuItem_Click);
            // 
            // terminToolStripMenuItem
            // 
            this.terminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretraziTermineToolStripMenuItem,
            this.noviTerminToolStripMenuItem});
            this.terminToolStripMenuItem.Name = "terminToolStripMenuItem";
            this.terminToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.terminToolStripMenuItem.Text = "Termin";
            // 
            // pretraziTermineToolStripMenuItem
            // 
            this.pretraziTermineToolStripMenuItem.Name = "pretraziTermineToolStripMenuItem";
            this.pretraziTermineToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pretraziTermineToolStripMenuItem.Text = "Pretrazi termine";
            this.pretraziTermineToolStripMenuItem.Click += new System.EventHandler(this.pretraziTermineToolStripMenuItem_Click);
            // 
            // noviTerminToolStripMenuItem
            // 
            this.noviTerminToolStripMenuItem.Name = "noviTerminToolStripMenuItem";
            this.noviTerminToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.noviTerminToolStripMenuItem.Text = "Novi termin";
            this.noviTerminToolStripMenuItem.Click += new System.EventHandler(this.noviTerminToolStripMenuItem_Click);
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviKorisnikToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            this.korisnikToolStripMenuItem.Click += new System.EventHandler(this.korisnikToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // novostiToolStripMenuItem
            // 
            this.novostiToolStripMenuItem.Name = "novostiToolStripMenuItem";
            this.novostiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.novostiToolStripMenuItem.Text = "Novosti";
            this.novostiToolStripMenuItem.Click += new System.EventHandler(this.novostiToolStripMenuItem_Click);
            // 
            // izvjestajiToolStripMenuItem
            // 
            this.izvjestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvjestajPoTretmanimaToolStripMenuItem,
            this.izvjestajPoKlijentimaToolStripMenuItem,
            this.izvjestajPoUposlenikuToolStripMenuItem});
            this.izvjestajiToolStripMenuItem.Name = "izvjestajiToolStripMenuItem";
            this.izvjestajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvjestajiToolStripMenuItem.Text = "Izvjestaji";
            // 
            // izvjestajPoTretmanimaToolStripMenuItem
            // 
            this.izvjestajPoTretmanimaToolStripMenuItem.Name = "izvjestajPoTretmanimaToolStripMenuItem";
            this.izvjestajPoTretmanimaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.izvjestajPoTretmanimaToolStripMenuItem.Text = "Izvjestaj po tretmanima";
            this.izvjestajPoTretmanimaToolStripMenuItem.Click += new System.EventHandler(this.izvjestajPoTretmanimaToolStripMenuItem_Click);
            // 
            // izvjestajPoKlijentimaToolStripMenuItem
            // 
            this.izvjestajPoKlijentimaToolStripMenuItem.Name = "izvjestajPoKlijentimaToolStripMenuItem";
            this.izvjestajPoKlijentimaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.izvjestajPoKlijentimaToolStripMenuItem.Text = "Izvjestaj po klijentima";
            this.izvjestajPoKlijentimaToolStripMenuItem.Click += new System.EventHandler(this.izvjestajPoKlijentimaToolStripMenuItem_Click);
            // 
            // izvjestajPoUposlenikuToolStripMenuItem
            // 
            this.izvjestajPoUposlenikuToolStripMenuItem.Name = "izvjestajPoUposlenikuToolStripMenuItem";
            this.izvjestajPoUposlenikuToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.izvjestajPoUposlenikuToolStripMenuItem.Text = "Izvjestaj po uposleniku";
            this.izvjestajPoUposlenikuToolStripMenuItem.Click += new System.EventHandler(this.izvjestajPoUposlenikuToolStripMenuItem_Click);
            // 
            // zahtjeviZaRezervacijeToolStripMenuItem
            // 
            this.zahtjeviZaRezervacijeToolStripMenuItem.Name = "zahtjeviZaRezervacijeToolStripMenuItem";
            this.zahtjeviZaRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.zahtjeviZaRezervacijeToolStripMenuItem.Text = "Zahtjevi za rezervacije";
            this.zahtjeviZaRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.zahtjeviZaRezervacijeToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviGradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tretmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajTretmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngradneIgreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziTermineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviTerminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajPoTretmanimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajPoKlijentimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajPoUposlenikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zahtjeviZaRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
    }
}



