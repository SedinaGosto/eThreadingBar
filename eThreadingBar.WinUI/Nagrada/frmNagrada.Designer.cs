namespace eThreadingBar.WinUI.Nagrada
{
    partial class frmNagrada
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
            this.lablenagrada = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbprva = new System.Windows.Forms.TabPage();
            this.btnNovaNagrada = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNagrade = new System.Windows.Forms.DataGridView();
            this.NagradaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnevidentiraj_Nagradnu_Igru = new System.Windows.Forms.Button();
            this.NagradneiGre = new System.Windows.Forms.GroupBox();
            this.dgvNagradneIgre = new System.Windows.Forms.DataGridView();
            this.NagradnaIgraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZavrsetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaNagrada = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNagrade = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbprva.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNagrade)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.NagradneiGre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNagradneIgre)).BeginInit();
            this.SuspendLayout();
            // 
            // lablenagrada
            // 
            this.lablenagrada.AutoSize = true;
            this.lablenagrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lablenagrada.Location = new System.Drawing.Point(549, 9);
            this.lablenagrada.Name = "lablenagrada";
            this.lablenagrada.Size = new System.Drawing.Size(124, 22);
            this.lablenagrada.TabIndex = 0;
            this.lablenagrada.Text = "Nagradne igre";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(31, 66);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(99, 23);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbprva);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(31, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 422);
            this.tabControl1.TabIndex = 3;
            // 
            // tbprva
            // 
            this.tbprva.Controls.Add(this.btnPretraga);
            this.tbprva.Controls.Add(this.txtPretragaNagrada);
            this.tbprva.Controls.Add(this.label1);
            this.tbprva.Controls.Add(this.btnNovaNagrada);
            this.tbprva.Controls.Add(this.groupBox1);
            this.tbprva.Location = new System.Drawing.Point(4, 22);
            this.tbprva.Name = "tbprva";
            this.tbprva.Padding = new System.Windows.Forms.Padding(3);
            this.tbprva.Size = new System.Drawing.Size(888, 396);
            this.tbprva.TabIndex = 0;
            this.tbprva.Text = "Nagrade";
            this.tbprva.UseVisualStyleBackColor = true;
            // 
            // btnNovaNagrada
            // 
            this.btnNovaNagrada.Location = new System.Drawing.Point(609, 21);
            this.btnNovaNagrada.Name = "btnNovaNagrada";
            this.btnNovaNagrada.Size = new System.Drawing.Size(91, 28);
            this.btnNovaNagrada.TabIndex = 1;
            this.btnNovaNagrada.Text = "Dodaj nagradu";
            this.btnNovaNagrada.UseVisualStyleBackColor = true;
            this.btnNovaNagrada.Click += new System.EventHandler(this.btnNovaNagrada_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNagrade);
            this.groupBox1.Location = new System.Drawing.Point(24, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nagrade";
            // 
            // dgvNagrade
            // 
            this.dgvNagrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNagrade.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNagrade.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNagrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNagrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNagrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NagradaId,
            this.Naziv});
            this.dgvNagrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNagrade.Location = new System.Drawing.Point(3, 16);
            this.dgvNagrade.Name = "dgvNagrade";
            this.dgvNagrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNagrade.Size = new System.Drawing.Size(684, 304);
            this.dgvNagrade.TabIndex = 0;
            this.dgvNagrade.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNagrade_MouseDoubleClick);
            // 
            // NagradaId
            // 
            this.NagradaId.DataPropertyName = "NagradaId";
            this.NagradaId.HeaderText = "NagradaId";
            this.NagradaId.Name = "NagradaId";
            this.NagradaId.Visible = false;
            this.NagradaId.Width = 82;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 59;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbNagrade);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnevidentiraj_Nagradnu_Igru);
            this.tabPage2.Controls.Add(this.NagradneiGre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nagradne Igre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnevidentiraj_Nagradnu_Igru
            // 
            this.btnevidentiraj_Nagradnu_Igru.Location = new System.Drawing.Point(696, 10);
            this.btnevidentiraj_Nagradnu_Igru.Name = "btnevidentiraj_Nagradnu_Igru";
            this.btnevidentiraj_Nagradnu_Igru.Size = new System.Drawing.Size(147, 32);
            this.btnevidentiraj_Nagradnu_Igru.TabIndex = 1;
            this.btnevidentiraj_Nagradnu_Igru.Text = "Evidentiraj nagradnu igru";
            this.btnevidentiraj_Nagradnu_Igru.UseVisualStyleBackColor = true;
            this.btnevidentiraj_Nagradnu_Igru.Click += new System.EventHandler(this.btnevidentiraj_Nagradnu_Igru_Click);
            // 
            // NagradneiGre
            // 
            this.NagradneiGre.Controls.Add(this.dgvNagradneIgre);
            this.NagradneiGre.Location = new System.Drawing.Point(22, 75);
            this.NagradneiGre.Name = "NagradneiGre";
            this.NagradneiGre.Size = new System.Drawing.Size(802, 297);
            this.NagradneiGre.TabIndex = 0;
            this.NagradneiGre.TabStop = false;
            this.NagradneiGre.Text = "Nagradne igre";
            // 
            // dgvNagradneIgre
            // 
            this.dgvNagradneIgre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNagradneIgre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNagradneIgre.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNagradneIgre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNagradneIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNagradneIgre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NagradnaIgraId,
            this.DatumPocetka,
            this.DatumZavrsetka,
            this.Opis});
            this.dgvNagradneIgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNagradneIgre.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvNagradneIgre.Location = new System.Drawing.Point(3, 16);
            this.dgvNagradneIgre.Name = "dgvNagradneIgre";
            this.dgvNagradneIgre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNagradneIgre.Size = new System.Drawing.Size(796, 278);
            this.dgvNagradneIgre.TabIndex = 0;
            this.dgvNagradneIgre.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNagradneIgre_MouseDoubleClick);
            // 
            // NagradnaIgraId
            // 
            this.NagradnaIgraId.DataPropertyName = "NagradnaIgraId";
            this.NagradnaIgraId.HeaderText = "NagradnaIgraId";
            this.NagradnaIgraId.Name = "NagradnaIgraId";
            this.NagradnaIgraId.Visible = false;
            this.NagradnaIgraId.Width = 106;
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.DataPropertyName = "DatumPocetka";
            this.DatumPocetka.HeaderText = "Datum pocetka";
            this.DatumPocetka.Name = "DatumPocetka";
            this.DatumPocetka.Width = 96;
            // 
            // DatumZavrsetka
            // 
            this.DatumZavrsetka.DataPropertyName = "DatumZavrsetka";
            this.DatumZavrsetka.HeaderText = "Datum zavrsetka";
            this.DatumZavrsetka.Name = "DatumZavrsetka";
            this.DatumZavrsetka.Width = 103;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.Width = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv";
            // 
            // txtPretragaNagrada
            // 
            this.txtPretragaNagrada.Location = new System.Drawing.Point(24, 19);
            this.txtPretragaNagrada.Name = "txtPretragaNagrada";
            this.txtPretragaNagrada.Size = new System.Drawing.Size(258, 20);
            this.txtPretragaNagrada.TabIndex = 3;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(312, 16);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(97, 23);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nagrada";
            // 
            // cmbNagrade
            // 
            this.cmbNagrade.FormattingEnabled = true;
            this.cmbNagrade.Location = new System.Drawing.Point(42, 26);
            this.cmbNagrade.Name = "cmbNagrade";
            this.cmbNagrade.Size = new System.Drawing.Size(311, 21);
            this.cmbNagrade.TabIndex = 3;
            this.cmbNagrade.SelectedIndexChanged += new System.EventHandler(this.cmbNagrade_SelectedIndexChanged);
            // 
            // frmNagrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 544);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.lablenagrada);
            this.Name = "frmNagrada";
            this.Text = "frmNagrada";
            this.Load += new System.EventHandler(this.frmNagrada_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbprva.ResumeLayout(false);
            this.tbprva.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNagrade)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.NagradneiGre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNagradneIgre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablenagrada;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbprva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNagrade;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox NagradneiGre;
        private System.Windows.Forms.DataGridView dgvNagradneIgre;
        private System.Windows.Forms.Button btnNovaNagrada;
        private System.Windows.Forms.Button btnevidentiraj_Nagradnu_Igru;
        private System.Windows.Forms.DataGridViewTextBoxColumn NagradnaIgraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZavrsetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NagradaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtPretragaNagrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNagrade;
        private System.Windows.Forms.Label label2;
    }
}