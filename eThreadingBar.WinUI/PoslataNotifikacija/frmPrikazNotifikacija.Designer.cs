namespace eThreadingBar.WinUI.PoslataNotifikacija
{
    partial class frmPrikazNotifikacija
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNotifikacije = new System.Windows.Forms.DataGridView();
            this.NotifikacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tretman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Termin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdobriRezervaciju = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifikacije)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNotifikacije);
            this.groupBox1.Location = new System.Drawing.Point(46, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zahtjevi za rezervacije";
            // 
            // dgvNotifikacije
            // 
            this.dgvNotifikacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNotifikacije.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotifikacije.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNotifikacije.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNotifikacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifikacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NotifikacijaId,
            this.RezervacijaId,
            this.Klijent,
            this.Tretman,
            this.Termin,
            this.DatumRezervacije,
            this.OdobriRezervaciju});
            this.dgvNotifikacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotifikacije.Location = new System.Drawing.Point(3, 16);
            this.dgvNotifikacije.Name = "dgvNotifikacije";
            this.dgvNotifikacije.ReadOnly = true;
            this.dgvNotifikacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNotifikacije.Size = new System.Drawing.Size(794, 321);
            this.dgvNotifikacije.TabIndex = 0;
            this.dgvNotifikacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotifikacije_CellClick);
            // 
            // NotifikacijaId
            // 
            this.NotifikacijaId.DataPropertyName = "PoslataNotifikacijaId";
            this.NotifikacijaId.HeaderText = "NotifikacijaId";
            this.NotifikacijaId.Name = "NotifikacijaId";
            this.NotifikacijaId.ReadOnly = true;
            this.NotifikacijaId.Visible = false;
            this.NotifikacijaId.Width = 93;
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.Name = "RezervacijaId";
            this.RezervacijaId.ReadOnly = true;
            this.RezervacijaId.Visible = false;
            this.RezervacijaId.Width = 97;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            this.Klijent.Width = 60;
            // 
            // Tretman
            // 
            this.Tretman.DataPropertyName = "Tretman";
            this.Tretman.HeaderText = "Tretman";
            this.Tretman.Name = "Tretman";
            this.Tretman.ReadOnly = true;
            this.Tretman.Width = 71;
            // 
            // Termin
            // 
            this.Termin.DataPropertyName = "VrijemeTermina";
            this.Termin.HeaderText = "Termin";
            this.Termin.Name = "Termin";
            this.Termin.ReadOnly = true;
            this.Termin.Width = 64;
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            this.DatumRezervacije.Width = 107;
            // 
            // OdobriRezervaciju
            // 
            this.OdobriRezervaciju.HeaderText = "Odobri rezervaciju";
            this.OdobriRezervaciju.Name = "OdobriRezervaciju";
            this.OdobriRezervaciju.ReadOnly = true;
            this.OdobriRezervaciju.Text = "Odobri rezervaciju";
            this.OdobriRezervaciju.ToolTipText = "Odobri rezervaciju";
            this.OdobriRezervaciju.UseColumnTextForLinkValue = true;
            this.OdobriRezervaciju.Width = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klijent";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(68, 41);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(431, 21);
            this.cmbKlijent.TabIndex = 2;
            this.cmbKlijent.SelectedIndexChanged += new System.EventHandler(this.cmbKlijent_SelectedIndexChanged);
            this.cmbKlijent.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxFormat);
            // 
            // frmPrikazNotifikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazNotifikacija";
            this.Text = "frmPrikazNotifikacija";
            this.Load += new System.EventHandler(this.frmPrikazNotifikacija_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifikacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNotifikacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotifikacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tretman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewLinkColumn OdobriRezervaciju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKlijent;
    }
}