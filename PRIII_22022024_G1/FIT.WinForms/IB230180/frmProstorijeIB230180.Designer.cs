namespace FIT.WinForms.IB230180
{
    partial class frmProstorijeIB230180
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
            dgvProstorijaPodaci = new DataGridView();
            Logo = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Oznaka = new DataGridViewTextBoxColumn();
            Kapacitet = new DataGridViewTextBoxColumn();
            BrojPredmeta = new DataGridViewTextBoxColumn();
            btnNastava = new DataGridViewButtonColumn();
            btnPrisustvo = new DataGridViewButtonColumn();
            btnNovaProstorija = new Button();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProstorijaPodaci).BeginInit();
            SuspendLayout();
            // 
            // dgvProstorijaPodaci
            // 
            dgvProstorijaPodaci.AllowUserToAddRows = false;
            dgvProstorijaPodaci.AllowUserToDeleteRows = false;
            dgvProstorijaPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProstorijaPodaci.Columns.AddRange(new DataGridViewColumn[] { Logo, Naziv, Oznaka, Kapacitet, BrojPredmeta, btnNastava, btnPrisustvo });
            dgvProstorijaPodaci.Location = new Point(24, 173);
            dgvProstorijaPodaci.Name = "dgvProstorijaPodaci";
            dgvProstorijaPodaci.ReadOnly = true;
            dgvProstorijaPodaci.RowHeadersWidth = 102;
            dgvProstorijaPodaci.RowTemplate.Height = 49;
            dgvProstorijaPodaci.Size = new Size(1817, 530);
            dgvProstorijaPodaci.TabIndex = 0;
            dgvProstorijaPodaci.CellContentClick += dgvProstorijaPodaci_CellContentClick;
            // 
            // Logo
            // 
            Logo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Logo.DataPropertyName = "Logo";
            Logo.HeaderText = "Logo";
            Logo.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Logo.MinimumWidth = 12;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 12;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.MinimumWidth = 12;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Kapacitet
            // 
            Kapacitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kapacitet.DataPropertyName = "Kapacitet";
            Kapacitet.HeaderText = "Kapacitet";
            Kapacitet.MinimumWidth = 12;
            Kapacitet.Name = "Kapacitet";
            Kapacitet.ReadOnly = true;
            // 
            // BrojPredmeta
            // 
            BrojPredmeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojPredmeta.DataPropertyName = "BrojPredmeta";
            BrojPredmeta.HeaderText = "Broj Predmeta";
            BrojPredmeta.MinimumWidth = 12;
            BrojPredmeta.Name = "BrojPredmeta";
            BrojPredmeta.ReadOnly = true;
            // 
            // btnNastava
            // 
            btnNastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnNastava.DataPropertyName = "btnNastava";
            btnNastava.HeaderText = "";
            btnNastava.MinimumWidth = 12;
            btnNastava.Name = "btnNastava";
            btnNastava.ReadOnly = true;
            btnNastava.Text = "Nastava";
            btnNastava.UseColumnTextForButtonValue = true;
            // 
            // btnPrisustvo
            // 
            btnPrisustvo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnPrisustvo.DataPropertyName = "btnPrisustvo";
            btnPrisustvo.HeaderText = "";
            btnPrisustvo.MinimumWidth = 12;
            btnPrisustvo.Name = "btnPrisustvo";
            btnPrisustvo.ReadOnly = true;
            btnPrisustvo.Text = "Prisustvo";
            btnPrisustvo.UseColumnTextForButtonValue = true;
            // 
            // btnNovaProstorija
            // 
            btnNovaProstorija.Location = new Point(1601, 62);
            btnNovaProstorija.Name = "btnNovaProstorija";
            btnNovaProstorija.Size = new Size(240, 58);
            btnNovaProstorija.TabIndex = 1;
            btnNovaProstorija.Text = "Nova Prostorija";
            btnNovaProstorija.UseVisualStyleBackColor = true;
            btnNovaProstorija.Click += btnNovaProstorija_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(1601, 743);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(240, 58);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // frmProstorijeIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1932, 894);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaProstorija);
            Controls.Add(dgvProstorijaPodaci);
            Name = "frmProstorijeIB230180";
            Text = "frmProstorijeIB230180";
            Load += frmProstorijeIB230180_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProstorijaPodaci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProstorijaPodaci;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Kapacitet;
        private DataGridViewTextBoxColumn BrojPredmeta;
        private DataGridViewButtonColumn btnNastava;
        private DataGridViewButtonColumn btnPrisustvo;
        private Button btnNovaProstorija;
        private Button btnPrintaj;
    }
}