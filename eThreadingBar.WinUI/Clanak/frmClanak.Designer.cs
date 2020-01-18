namespace eThreadingBar.WinUI.Clanak
{
    partial class frmClanak
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
            this.dgvClanak = new System.Windows.Forms.DataGridView();
            this.ClanakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRfereseh = new System.Windows.Forms.Button();
            this.btnDodajClanak = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanak)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClanak);
            this.groupBox1.Location = new System.Drawing.Point(33, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novosti";
            // 
            // dgvClanak
            // 
            this.dgvClanak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClanak.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClanak.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClanak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClanak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClanakId,
            this.Naslov,
            this.DatumKreiranja});
            this.dgvClanak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClanak.Location = new System.Drawing.Point(3, 16);
            this.dgvClanak.Name = "dgvClanak";
            this.dgvClanak.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvClanak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanak.Size = new System.Drawing.Size(702, 194);
            this.dgvClanak.TabIndex = 0;
            this.dgvClanak.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvClanak_MouseDoubleClick);
            // 
            // ClanakId
            // 
            this.ClanakId.DataPropertyName = "ClanakId";
            this.ClanakId.HeaderText = "ClanakId";
            this.ClanakId.Name = "ClanakId";
            this.ClanakId.Visible = false;
            this.ClanakId.Width = 74;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.Width = 65;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.DataPropertyName = "DatumObjave";
            this.DatumKreiranja.HeaderText = "Datum objave";
            this.DatumKreiranja.Name = "DatumKreiranja";
            this.DatumKreiranja.Width = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(36, 143);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(587, 20);
            this.txtNaslov.TabIndex = 2;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(683, 142);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(86, 20);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Novosti";
            // 
            // btnRfereseh
            // 
            this.btnRfereseh.Location = new System.Drawing.Point(11, 11);
            this.btnRfereseh.Name = "btnRfereseh";
            this.btnRfereseh.Size = new System.Drawing.Size(62, 28);
            this.btnRfereseh.TabIndex = 5;
            this.btnRfereseh.Text = "Refresh";
            this.btnRfereseh.UseVisualStyleBackColor = true;
            this.btnRfereseh.Click += new System.EventHandler(this.btnRfereseh_Click);
            // 
            // btnDodajClanak
            // 
            this.btnDodajClanak.Location = new System.Drawing.Point(649, 69);
            this.btnDodajClanak.Name = "btnDodajClanak";
            this.btnDodajClanak.Size = new System.Drawing.Size(120, 24);
            this.btnDodajClanak.TabIndex = 6;
            this.btnDodajClanak.Text = "Dodaj clanak";
            this.btnDodajClanak.UseVisualStyleBackColor = true;
            this.btnDodajClanak.Click += new System.EventHandler(this.btnDodajClanak_Click);
            // 
            // frmClanak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajClanak);
            this.Controls.Add(this.btnRfereseh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClanak";
            this.Text = "frmClanak";
            this.Load += new System.EventHandler(this.frmClanak_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClanak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRfereseh;
        private System.Windows.Forms.Button btnDodajClanak;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranja;
    }
}