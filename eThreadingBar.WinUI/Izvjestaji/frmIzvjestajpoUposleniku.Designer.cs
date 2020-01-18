namespace eThreadingBar.WinUI.Izvjestaji
{
    partial class frmIzvjestajpoUposleniku
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgodina = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUposlenici = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanBrojRezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupnazarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikaziIzvjestaj = new System.Windows.Forms.Button();
            this.chartIzvjestaj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIzvjestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izvjestaj po uposleniku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite godinu po kojoj zelite da pretrazujete";
            // 
            // txtgodina
            // 
            this.txtgodina.Location = new System.Drawing.Point(28, 104);
            this.txtgodina.Name = "txtgodina";
            this.txtgodina.Size = new System.Drawing.Size(337, 20);
            this.txtgodina.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUposlenici);
            this.groupBox1.Location = new System.Drawing.Point(28, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 333);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uposlenici";
            // 
            // dgvUposlenici
            // 
            this.dgvUposlenici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUposlenici.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.UkupanBrojRezervacija,
            this.Ukupnazarada});
            this.dgvUposlenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUposlenici.Location = new System.Drawing.Point(3, 16);
            this.dgvUposlenici.Name = "dgvUposlenici";
            this.dgvUposlenici.Size = new System.Drawing.Size(514, 314);
            this.dgvUposlenici.TabIndex = 0;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i Prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // UkupanBrojRezervacija
            // 
            this.UkupanBrojRezervacija.DataPropertyName = "Ukupanbrojrezervacija";
            this.UkupanBrojRezervacija.HeaderText = "Ukupan broj rezervacija";
            this.UkupanBrojRezervacija.Name = "UkupanBrojRezervacija";
            // 
            // Ukupnazarada
            // 
            this.Ukupnazarada.DataPropertyName = "Ukupnozaradjeno";
            this.Ukupnazarada.HeaderText = "Ukupna zarada(KM)";
            this.Ukupnazarada.Name = "Ukupnazarada";
            // 
            // btnPrikaziIzvjestaj
            // 
            this.btnPrikaziIzvjestaj.Location = new System.Drawing.Point(418, 104);
            this.btnPrikaziIzvjestaj.Name = "btnPrikaziIzvjestaj";
            this.btnPrikaziIzvjestaj.Size = new System.Drawing.Size(127, 20);
            this.btnPrikaziIzvjestaj.TabIndex = 4;
            this.btnPrikaziIzvjestaj.Text = "Prikazi izvjestaj";
            this.btnPrikaziIzvjestaj.UseVisualStyleBackColor = true;
            this.btnPrikaziIzvjestaj.Click += new System.EventHandler(this.btnPrikaziIzvjestaj_Click);
            // 
            // chartIzvjestaj
            // 
            chartArea4.Name = "ChartArea1";
            this.chartIzvjestaj.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartIzvjestaj.Legends.Add(legend4);
            this.chartIzvjestaj.Location = new System.Drawing.Point(570, 148);
            this.chartIzvjestaj.Name = "chartIzvjestaj";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.RoyalBlue;
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Uposlenik";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.MediumAquamarine;
            series8.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "Zarada";
            this.chartIzvjestaj.Series.Add(series7);
            this.chartIzvjestaj.Series.Add(series8);
            this.chartIzvjestaj.Size = new System.Drawing.Size(495, 333);
            this.chartIzvjestaj.TabIndex = 5;
            this.chartIzvjestaj.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(672, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // frmIzvjestajpoUposleniku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartIzvjestaj);
            this.Controls.Add(this.btnPrikaziIzvjestaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtgodina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIzvjestajpoUposleniku";
            this.Text = "frmIzvjestajpoUposleniku";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIzvjestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgodina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUposlenici;
        private System.Windows.Forms.Button btnPrikaziIzvjestaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanBrojRezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupnazarada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIzvjestaj;
        private System.Windows.Forms.Label label3;
    }
}