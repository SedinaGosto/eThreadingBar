namespace eThreadingBar.WinUI.Nagrada
{
    partial class frmNagradaDetails
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
            this.naslovnagrada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Slika = new System.Windows.Forms.PictureBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slika)).BeginInit();
            this.SuspendLayout();
            // 
            // naslovnagrada
            // 
            this.naslovnagrada.AutoSize = true;
            this.naslovnagrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.naslovnagrada.Location = new System.Drawing.Point(180, 9);
            this.naslovnagrada.Name = "naslovnagrada";
            this.naslovnagrada.Size = new System.Drawing.Size(123, 22);
            this.naslovnagrada.TabIndex = 0;
            this.naslovnagrada.Text = "Nova nagrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(251, 116);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(208, 20);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(311, 174);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(79, 26);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.naslovnagrada);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 48);
            this.panel1.TabIndex = 4;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Slika
            // 
            this.Slika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slika.Location = new System.Drawing.Point(44, 54);
            this.Slika.Name = "Slika";
            this.Slika.Size = new System.Drawing.Size(153, 133);
            this.Slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slika.TabIndex = 5;
            this.Slika.TabStop = false;
            // 
            // txtSlika
            // 
            this.txtSlika.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSlika.Location = new System.Drawing.Point(12, 206);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(217, 20);
            this.txtSlika.TabIndex = 6;
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(64, 244);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(106, 27);
            this.btnUcitajSliku.TabIndex = 7;
            this.btnUcitajSliku.Text = "Ucitaj sliku";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNagradaDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 306);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.Slika);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Name = "frmNagradaDetails";
            this.Text = "frmNagradaDetails";
            this.Load += new System.EventHandler(this.frmNagradaDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslovnagrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.PictureBox Slika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}