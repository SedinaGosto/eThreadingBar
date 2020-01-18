namespace eThreadingBar.WinUI.Grad
{
    partial class frmGrad
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
            this.grGradovi = new System.Windows.Forms.GroupBox();
            this.dgvGradovi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btn_Prikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grGradovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).BeginInit();
            this.SuspendLayout();
            // 
            // grGradovi
            // 
            this.grGradovi.Controls.Add(this.dgvGradovi);
            this.grGradovi.Location = new System.Drawing.Point(27, 95);
            this.grGradovi.Name = "grGradovi";
            this.grGradovi.Size = new System.Drawing.Size(696, 317);
            this.grGradovi.TabIndex = 0;
            this.grGradovi.TabStop = false;
            this.grGradovi.Text = "Gradovi";
            // 
            // dgvGradovi
            // 
            this.dgvGradovi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv});
            this.dgvGradovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGradovi.Location = new System.Drawing.Point(3, 16);
            this.dgvGradovi.Name = "dgvGradovi";
            this.dgvGradovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradovi.Size = new System.Drawing.Size(690, 298);
            this.dgvGradovi.TabIndex = 0;
            this.dgvGradovi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvGradovi_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(27, 57);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(587, 20);
            this.txtPretrazi.TabIndex = 1;
            // 
            // btn_Prikazi
            // 
            this.btn_Prikazi.Location = new System.Drawing.Point(634, 54);
            this.btn_Prikazi.Name = "btn_Prikazi";
            this.btn_Prikazi.Size = new System.Drawing.Size(75, 23);
            this.btn_Prikazi.TabIndex = 2;
            this.btn_Prikazi.Text = "Trazi";
            this.btn_Prikazi.UseVisualStyleBackColor = true;
            this.btn_Prikazi.Click += new System.EventHandler(this.btn_Prikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gradovi";
            // 
            // frmGrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Prikazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.grGradovi);
            this.Name = "frmGrad";
            this.Text = "frmGrad";
            this.Load += new System.EventHandler(this.frmGrad_Load);
            this.grGradovi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grGradovi;
        private System.Windows.Forms.DataGridView dgvGradovi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btn_Prikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}