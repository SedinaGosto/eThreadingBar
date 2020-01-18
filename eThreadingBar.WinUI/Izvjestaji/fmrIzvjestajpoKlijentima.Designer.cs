namespace eThreadingBar.WinUI.Izvjestaji
{
    partial class fmrIzvjestajpoKlijentima
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
            this.cmbKlijenti = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brojrezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaziIzvjestaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUkupanbrojrezervacija = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblbrojrezervacija = new System.Windows.Forms.Label();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKlijenti
            // 
            this.cmbKlijenti.FormattingEnabled = true;
            this.cmbKlijenti.Location = new System.Drawing.Point(12, 148);
            this.cmbKlijenti.Name = "cmbKlijenti";
            this.cmbKlijenti.Size = new System.Drawing.Size(446, 21);
            this.cmbKlijenti.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKlijenti);
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klijenti";
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Brojrezervacija});
            this.dgvKlijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijenti.Location = new System.Drawing.Point(3, 16);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.Size = new System.Drawing.Size(473, 275);
            this.dgvKlijenti.TabIndex = 0;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Brojrezervacija
            // 
            this.Brojrezervacija.DataPropertyName = "Brojrezervacija";
            this.Brojrezervacija.HeaderText = "Ukupno rezervacija";
            this.Brojrezervacija.Name = "Brojrezervacija";
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(12, 188);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(446, 20);
            this.txtGodina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesite godinu po kojoj zelite da pretrazujete";
            // 
            // btnPrikaziIzvjestaj
            // 
            this.btnPrikaziIzvjestaj.Location = new System.Drawing.Point(532, 166);
            this.btnPrikaziIzvjestaj.Name = "btnPrikaziIzvjestaj";
            this.btnPrikaziIzvjestaj.Size = new System.Drawing.Size(121, 25);
            this.btnPrikaziIzvjestaj.TabIndex = 4;
            this.btnPrikaziIzvjestaj.Text = "Prikazi izvjestaj";
            this.btnPrikaziIzvjestaj.UseVisualStyleBackColor = true;
            this.btnPrikaziIzvjestaj.Click += new System.EventHandler(this.btnPrikaziIzvjestaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odaberite klijenta";
            // 
            // lblUkupanbrojrezervacija
            // 
            this.lblUkupanbrojrezervacija.AutoSize = true;
            this.lblUkupanbrojrezervacija.Location = new System.Drawing.Point(540, 157);
            this.lblUkupanbrojrezervacija.Name = "lblUkupanbrojrezervacija";
            this.lblUkupanbrojrezervacija.Size = new System.Drawing.Size(0, 13);
            this.lblUkupanbrojrezervacija.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Izvjestaj o broju rezervacija po klijentima";
            // 
            // lblbrojrezervacija
            // 
            this.lblbrojrezervacija.AutoSize = true;
            this.lblbrojrezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrojrezervacija.Location = new System.Drawing.Point(548, 266);
            this.lblbrojrezervacija.Name = "lblbrojrezervacija";
            this.lblbrojrezervacija.Size = new System.Drawing.Size(46, 18);
            this.lblbrojrezervacija.TabIndex = 8;
            this.lblbrojrezervacija.Text = "label4";
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijent.Location = new System.Drawing.Point(548, 297);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(46, 18);
            this.lblKlijent.TabIndex = 9;
            this.lblKlijent.Text = "label5";
            // 
            // fmrIzvjestajpoKlijentima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 547);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.lblbrojrezervacija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUkupanbrojrezervacija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrikaziIzvjestaj);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbKlijenti);
            this.Name = "fmrIzvjestajpoKlijentima";
            this.Text = "fmrIzvjestajpoKlijentima";
            this.Load += new System.EventHandler(this.fmrIzvjestajpoKlijentima_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKlijenti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikaziIzvjestaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brojrezervacija;
        private System.Windows.Forms.Label lblUkupanbrojrezervacija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblbrojrezervacija;
        private System.Windows.Forms.Label lblKlijent;
    }
}