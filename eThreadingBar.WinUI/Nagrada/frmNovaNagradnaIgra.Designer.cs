namespace eThreadingBar.WinUI.Nagrada
{
    partial class frmNovaNagradnaIgra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumpocetka = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNagrada = new System.Windows.Forms.ComboBox();
            this.cmbAdministrator = new System.Windows.Forms.ComboBox();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova nagradna igra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum pocetka";
            // 
            // dtpDatumpocetka
            // 
            this.dtpDatumpocetka.Location = new System.Drawing.Point(24, 113);
            this.dtpDatumpocetka.Name = "dtpDatumpocetka";
            this.dtpDatumpocetka.Size = new System.Drawing.Size(248, 20);
            this.dtpDatumpocetka.TabIndex = 2;
            // 
            // dtpDatumZavrsetka
            // 
            this.dtpDatumZavrsetka.Location = new System.Drawing.Point(24, 187);
            this.dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            this.dtpDatumZavrsetka.Size = new System.Drawing.Size(248, 20);
            this.dtpDatumZavrsetka.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum zavrsetka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opis";
            // 
            // cmbNagrada
            // 
            this.cmbNagrada.FormattingEnabled = true;
            this.cmbNagrada.Location = new System.Drawing.Point(396, 112);
            this.cmbNagrada.Name = "cmbNagrada";
            this.cmbNagrada.Size = new System.Drawing.Size(270, 21);
            this.cmbNagrada.TabIndex = 7;
            // 
            // cmbAdministrator
            // 
            this.cmbAdministrator.FormattingEnabled = true;
            this.cmbAdministrator.Location = new System.Drawing.Point(396, 190);
            this.cmbAdministrator.Name = "cmbAdministrator";
            this.cmbAdministrator.Size = new System.Drawing.Size(270, 21);
            this.cmbAdministrator.TabIndex = 8;
            this.cmbAdministrator.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxFormat);
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(396, 251);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(270, 21);
            this.cmbKlijent.TabIndex = 9;
            this.cmbKlijent.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.KlijentcmbFormat);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Klijent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Administrator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nagrada";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(291, 373);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(137, 34);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(25, 251);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(247, 72);
            this.rtxtOpis.TabIndex = 14;
            this.rtxtOpis.Text = "";
            this.rtxtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtOpis_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 54);
            this.panel1.TabIndex = 15;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmNovaNagradnaIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.cmbAdministrator);
            this.Controls.Add(this.cmbNagrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatumZavrsetka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumpocetka);
            this.Controls.Add(this.label2);
            this.Name = "frmNovaNagradnaIgra";
            this.Text = "frmNovaNagradnaIgra";
            this.Load += new System.EventHandler(this.frmNovaNagradnaIgra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumpocetka;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNagrada;
        private System.Windows.Forms.ComboBox cmbAdministrator;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider error;
    }
}