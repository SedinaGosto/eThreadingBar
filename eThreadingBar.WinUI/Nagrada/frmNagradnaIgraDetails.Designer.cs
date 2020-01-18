namespace eThreadingBar.WinUI.Nagrada
{
    partial class frmNagradnaIgraDetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNagrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdministrator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalji nagradne igre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum pocetka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum zavrsetka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opis";
            // 
            // txtNagrada
            // 
            this.txtNagrada.Location = new System.Drawing.Point(460, 106);
            this.txtNagrada.Name = "txtNagrada";
            this.txtNagrada.ReadOnly = true;
            this.txtNagrada.Size = new System.Drawing.Size(233, 20);
            this.txtNagrada.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nagrada";
            // 
            // txtAdministrator
            // 
            this.txtAdministrator.Location = new System.Drawing.Point(460, 186);
            this.txtAdministrator.Name = "txtAdministrator";
            this.txtAdministrator.ReadOnly = true;
            this.txtAdministrator.Size = new System.Drawing.Size(233, 20);
            this.txtAdministrator.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Administrator";
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(460, 270);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.ReadOnly = true;
            this.txtKlijent.Size = new System.Drawing.Size(233, 20);
            this.txtKlijent.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Osnivac nagrade";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(586, 364);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(92, 32);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 58);
            this.panel1.TabIndex = 14;
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Location = new System.Drawing.Point(36, 106);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.Size = new System.Drawing.Size(230, 20);
            this.dtpDatumPocetka.TabIndex = 15;
            // 
            // dtpDatumZavrsetka
            // 
            this.dtpDatumZavrsetka.Location = new System.Drawing.Point(36, 183);
            this.dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            this.dtpDatumZavrsetka.Size = new System.Drawing.Size(230, 20);
            this.dtpDatumZavrsetka.TabIndex = 16;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(36, 267);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(229, 93);
            this.txtOpis.TabIndex = 17;
            this.txtOpis.Text = "";
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating_1);
            // 
            // frmNagradnaIgraDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.dtpDatumZavrsetka);
            this.Controls.Add(this.dtpDatumPocetka);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdministrator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNagrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmNagradnaIgraDetails";
            this.Text = "frmNagradnaIgraDetails";
            this.Load += new System.EventHandler(this.frmNagradnaIgraDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNagrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdministrator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetka;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.RichTextBox txtOpis;
    }
}