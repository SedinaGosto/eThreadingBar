namespace eThreadingBar.WinUI.Termin
{
    partial class frmTermin
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUpolenici = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeTermina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezervisan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(297, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termini";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uposlenik";
            // 
            // cmbUpolenici
            // 
            this.cmbUpolenici.FormattingEnabled = true;
            this.cmbUpolenici.Location = new System.Drawing.Point(66, 105);
            this.cmbUpolenici.Name = "cmbUpolenici";
            this.cmbUpolenici.Size = new System.Drawing.Size(634, 21);
            this.cmbUpolenici.TabIndex = 2;
            this.cmbUpolenici.SelectedIndexChanged += new System.EventHandler(this.cmbUpolenici_SelectedIndexChanged);
            this.cmbUpolenici.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxFormat);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTermini);
            this.groupBox1.Location = new System.Drawing.Point(66, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 372);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Termini";
            // 
            // dgvTermini
            // 
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTermini.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTermini.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTermini.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.VrijemeTermina,
            this.Rezervisan});
            this.dgvTermini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTermini.Location = new System.Drawing.Point(3, 16);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(628, 353);
            this.dgvTermini.TabIndex = 0;
            this.dgvTermini.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTermini_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 41;
            // 
            // VrijemeTermina
            // 
            this.VrijemeTermina.DataPropertyName = "VrijemeTermina";
            this.VrijemeTermina.HeaderText = "Vrijeme termina";
            this.VrijemeTermina.Name = "VrijemeTermina";
            this.VrijemeTermina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VrijemeTermina.Width = 95;
            // 
            // Rezervisan
            // 
            this.Rezervisan.DataPropertyName = "Rezervisan";
            this.Rezervisan.HeaderText = "Rezervisan";
            this.Rezervisan.Name = "Rezervisan";
            this.Rezervisan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rezervisan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Rezervisan.Width = 85;
            // 
            // frmTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbUpolenici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTermin";
            this.Text = "frmTermin";
            this.Load += new System.EventHandler(this.frmTermin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUpolenici;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeTermina;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rezervisan;
    }
}