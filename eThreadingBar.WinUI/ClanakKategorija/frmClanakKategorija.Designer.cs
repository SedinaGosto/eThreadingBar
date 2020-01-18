namespace eThreadingBar.WinUI.ClanakKategorija
{
    partial class frmClanakKategorija
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClanakKategorija = new System.Windows.Forms.DataGridView();
            this.KategorijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovaKtegorija = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanakKategorija)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorije clanaka";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClanakKategorija);
            this.groupBox1.Location = new System.Drawing.Point(124, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorije";
            // 
            // dgvClanakKategorija
            // 
            this.dgvClanakKategorija.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClanakKategorija.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClanakKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanakKategorija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategorijaId,
            this.Naziv,
            this.DatumKreiranja});
            this.dgvClanakKategorija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClanakKategorija.Location = new System.Drawing.Point(3, 16);
            this.dgvClanakKategorija.Name = "dgvClanakKategorija";
            this.dgvClanakKategorija.ReadOnly = true;
            this.dgvClanakKategorija.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvClanakKategorija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanakKategorija.Size = new System.Drawing.Size(568, 189);
            this.dgvClanakKategorija.TabIndex = 0;
            this.dgvClanakKategorija.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvClanakKategorija_MouseDoubleClick);
            // 
            // KategorijaId
            // 
            this.KategorijaId.DataPropertyName = "ClanciKategorijaId";
            this.KategorijaId.HeaderText = "Id";
            this.KategorijaId.Name = "KategorijaId";
            this.KategorijaId.ReadOnly = true;
            this.KategorijaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.DataPropertyName = "DatumKreiranja";
            this.DatumKreiranja.HeaderText = "Datum kreiranja";
            this.DatumKreiranja.Name = "DatumKreiranja";
            this.DatumKreiranja.ReadOnly = true;
            // 
            // btnNovaKtegorija
            // 
            this.btnNovaKtegorija.Location = new System.Drawing.Point(593, 151);
            this.btnNovaKtegorija.Name = "btnNovaKtegorija";
            this.btnNovaKtegorija.Size = new System.Drawing.Size(102, 26);
            this.btnNovaKtegorija.TabIndex = 2;
            this.btnNovaKtegorija.Text = "Nova kategorija";
            this.btnNovaKtegorija.UseVisualStyleBackColor = true;
            this.btnNovaKtegorija.Click += new System.EventHandler(this.btnNovaKtegorija_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 21);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(162, 102);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(254, 20);
            this.txtPretraga.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pretrazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClanakKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNovaKtegorija);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmClanakKategorija";
            this.Text = "frmClanakKategorija";
            this.Load += new System.EventHandler(this.frmClanakKategorija_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanakKategorija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClanakKategorija;
        private System.Windows.Forms.Button btnNovaKtegorija;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button button1;
    }
}