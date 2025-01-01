namespace FIT.WinForms.IB230180
{
    partial class frmPretragaIB230180
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
            cmbSpol = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpOD = new DateTimePicker();
            dtpDO = new DateTimePicker();
            dgvPodaci = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnUvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // cmbSpol
            // 
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(44, 86);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(302, 49);
            cmbSpol.TabIndex = 0;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 42);
            label1.Name = "label1";
            label1.Size = new Size(84, 41);
            label1.TabIndex = 1;
            label1.Text = "Spol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1101, 89);
            label2.Name = "label2";
            label2.Size = new Size(61, 41);
            label2.TabIndex = 2;
            label2.Text = "do:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 86);
            label3.Name = "label3";
            label3.Size = new Size(162, 41);
            label3.TabIndex = 3;
            label3.Text = "Rodjen od:";
            // 
            // dtpOD
            // 
            dtpOD.Location = new Point(563, 81);
            dtpOD.Name = "dtpOD";
            dtpOD.Size = new Size(500, 47);
            dtpOD.TabIndex = 4;
            dtpOD.ValueChanged += dtpOD_ValueChanged;
            // 
            // dtpDO
            // 
            dtpDO.Location = new Point(1247, 80);
            dtpDO.Name = "dtpDO";
            dtpDO.Size = new Size(500, 47);
            dtpDO.TabIndex = 5;
            dtpDO.ValueChanged += dtpDO_ValueChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, ImePrezime, Prosjek, DatumRodjenja, Aktivan, btnUvjerenja });
            dgvPodaci.Location = new Point(44, 176);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(2165, 375);
            dgvPodaci.TabIndex = 6;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Broj Indeksa";
            BrojIndeksa.MinimumWidth = 12;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime Prezime";
            ImePrezime.MinimumWidth = 12;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 12;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            Prosjek.Width = 250;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum Rodjenja";
            DatumRodjenja.MinimumWidth = 12;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 12;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // btnUvjerenja
            // 
            btnUvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnUvjerenja.DataPropertyName = "btnUvjerenja";
            btnUvjerenja.HeaderText = "";
            btnUvjerenja.MinimumWidth = 12;
            btnUvjerenja.Name = "btnUvjerenja";
            btnUvjerenja.ReadOnly = true;
            btnUvjerenja.Text = "Uvjerenja";
            btnUvjerenja.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2264, 677);
            Controls.Add(dgvPodaci);
            Controls.Add(dtpDO);
            Controls.Add(dtpOD);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbSpol);
            Name = "frmPretragaIB230180";
            Text = "Pretraga studenti";
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSpol;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpOD;
        private DateTimePicker dtpDO;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnUvjerenja;
    }
}