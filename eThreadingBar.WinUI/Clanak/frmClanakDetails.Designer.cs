namespace eThreadingBar.WinUI.Clanak
{
    partial class frmClanakDetails
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDatumKreiranja = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cmbClanakKategroija = new System.Windows.Forms.ComboBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPodnaslov = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novi clanak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(12, 96);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(426, 20);
            this.txtNaslov.TabIndex = 2;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Podnaslov";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kategorija clanaka";
            // 
            // rtxtSadrzaj
            // 
            this.rtxtSadrzaj.Location = new System.Drawing.Point(12, 381);
            this.rtxtSadrzaj.Name = "rtxtSadrzaj";
            this.rtxtSadrzaj.Size = new System.Drawing.Size(767, 200);
            this.rtxtSadrzaj.TabIndex = 6;
            this.rtxtSadrzaj.Text = "";
            this.rtxtSadrzaj.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtSadrzaj_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sadrzaj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Datum kreiranja";
            // 
            // dtpDatumKreiranja
            // 
            this.dtpDatumKreiranja.Location = new System.Drawing.Point(12, 236);
            this.dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            this.dtpDatumKreiranja.Size = new System.Drawing.Size(426, 20);
            this.dtpDatumKreiranja.TabIndex = 10;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(532, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(247, 231);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // cmbClanakKategroija
            // 
            this.cmbClanakKategroija.FormattingEnabled = true;
            this.cmbClanakKategroija.Location = new System.Drawing.Point(12, 304);
            this.cmbClanakKategroija.Name = "cmbClanakKategroija";
            this.cmbClanakKategroija.Size = new System.Drawing.Size(426, 21);
            this.cmbClanakKategroija.TabIndex = 12;
            //this.cmbClanakKategroija.SelectedIndexChanged += new System.EventHandler(this.cmbClanakKategroija_SelectedIndexChanged);
            this.cmbClanakKategroija.Validating += new System.ComponentModel.CancelEventHandler(this.cmbClanakKategroija_Validating);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(611, 343);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(135, 28);
            this.btnDodajSliku.TabIndex = 13;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 62);
            this.panel1.TabIndex = 14;
            // 
            // txtSlika
            // 
            this.txtSlika.BackColor = System.Drawing.SystemColors.Control;
            this.txtSlika.Location = new System.Drawing.Point(532, 317);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(247, 20);
            this.txtSlika.TabIndex = 15;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(623, 631);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(123, 25);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtPodnaslov
            // 
            this.txtPodnaslov.Location = new System.Drawing.Point(12, 172);
            this.txtPodnaslov.Name = "txtPodnaslov";
            this.txtPodnaslov.Size = new System.Drawing.Size(425, 34);
            this.txtPodnaslov.TabIndex = 17;
            this.txtPodnaslov.Text = "";
            this.txtPodnaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtPodnaslov_Validating);
            // 
            // frmClanakDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 668);
            this.Controls.Add(this.txtPodnaslov);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.cmbClanakKategroija);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dtpDatumKreiranja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtSadrzaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label2);
            this.Name = "frmClanakDetails";
            this.Text = "frmClanakDetails";
            this.Load += new System.EventHandler(this.frmClanakDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtSadrzaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cmbClanakKategroija;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.RichTextBox txtPodnaslov;
    }
}