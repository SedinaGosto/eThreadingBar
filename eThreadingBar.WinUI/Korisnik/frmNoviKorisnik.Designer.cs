namespace eThreadingBar.WinUI.Korisnik
{
    partial class frmNoviKorisnik
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKorisnickoime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpotvrdaPasworda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.clbRole = new System.Windows.Forms.CheckedListBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(312, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novi korisnik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(39, 103);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(273, 20);
            this.txtIme.TabIndex = 2;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(39, 159);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(274, 20);
            this.txtPrezime.TabIndex = 4;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(39, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(39, 278);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(273, 20);
            this.txtTelefon.TabIndex = 8;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon";
            // 
            // txtKorisnickoime
            // 
            this.txtKorisnickoime.Location = new System.Drawing.Point(406, 103);
            this.txtKorisnickoime.Name = "txtKorisnickoime";
            this.txtKorisnickoime.Size = new System.Drawing.Size(366, 20);
            this.txtKorisnickoime.TabIndex = 10;
            this.txtKorisnickoime.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoime_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Korisnicko Ime";
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(404, 175);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.PasswordChar = '*';
            this.txtPasword.Size = new System.Drawing.Size(179, 20);
            this.txtPasword.TabIndex = 12;
            this.txtPasword.UseSystemPasswordChar = true;
            this.txtPasword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasword_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password";
            // 
            // txtpotvrdaPasworda
            // 
            this.txtpotvrdaPasworda.Location = new System.Drawing.Point(625, 175);
            this.txtpotvrdaPasworda.Name = "txtpotvrdaPasworda";
            this.txtpotvrdaPasworda.PasswordChar = '*';
            this.txtpotvrdaPasworda.Size = new System.Drawing.Size(163, 20);
            this.txtpotvrdaPasworda.TabIndex = 14;
            this.txtpotvrdaPasworda.UseSystemPasswordChar = true;
            this.txtpotvrdaPasworda.Validating += new System.ComponentModel.CancelEventHandler(this.txtpotvrdaPasworda_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Potvrda passworda";
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Checked = true;
            this.cbAktivan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAktivan.Location = new System.Drawing.Point(404, 235);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(62, 17);
            this.cbAktivan.TabIndex = 17;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(543, 522);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(134, 29);
            this.btnSacuvaj.TabIndex = 18;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // clbRole
            // 
            this.clbRole.FormattingEnabled = true;
            this.clbRole.Location = new System.Drawing.Point(406, 311);
            this.clbRole.Name = "clbRole";
            this.clbRole.Size = new System.Drawing.Size(366, 79);
            this.clbRole.TabIndex = 19;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 55);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(40, 328);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(286, 188);
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            // 
            // txtSlika
            // 
            this.txtSlika.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSlika.Location = new System.Drawing.Point(40, 531);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(286, 20);
            this.txtSlika.TabIndex = 22;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(82, 567);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(166, 25);
            this.btnDodajSliku.TabIndex = 23;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clbRole);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.txtpotvrdaPasworda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKorisnickoime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Name = "frmNoviKorisnik";
            this.Text = "frmKorisnikDetails";
            this.Load += new System.EventHandler(this.frmKorisnikDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKorisnickoime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpotvrdaPasworda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.CheckedListBox clbRole;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}