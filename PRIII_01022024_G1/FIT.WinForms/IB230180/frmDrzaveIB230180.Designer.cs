namespace FIT.WinForms.IB230180
{
    partial class frmDrzaveIB230180
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
            btnNovaDrzava = new Button();
            dgvPodaci = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Drzava = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            btnGradovi = new DataGridViewButtonColumn();
            btnPrintaj = new Button();
            lblVrijeme = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(1269, 49);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(240, 58);
            btnNovaDrzava.TabIndex = 0;
            btnNovaDrzava.Text = "Nova Drzava";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Zastava, Drzava, BrojGradova, Aktivna, btnGradovi });
            dgvPodaci.Location = new Point(49, 182);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1460, 375);
            dgvPodaci.TabIndex = 1;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Zastava
            // 
            Zastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.MinimumWidth = 12;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 12;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // BrojGradova
            // 
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj Gradova";
            BrojGradova.MinimumWidth = 12;
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            BrojGradova.Width = 250;
            // 
            // Aktivna
            // 
            Aktivna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.MinimumWidth = 12;
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // btnGradovi
            // 
            btnGradovi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnGradovi.DataPropertyName = "btnGradovi";
            btnGradovi.HeaderText = "";
            btnGradovi.MinimumWidth = 12;
            btnGradovi.Name = "btnGradovi";
            btnGradovi.ReadOnly = true;
            btnGradovi.Text = "Gradovi";
            btnGradovi.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(1269, 652);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(240, 58);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // lblVrijeme
            // 
            lblVrijeme.AutoSize = true;
            lblVrijeme.Location = new Point(49, 669);
            lblVrijeme.Name = "lblVrijeme";
            lblVrijeme.Size = new Size(97, 41);
            lblVrijeme.TabIndex = 3;
            lblVrijeme.Text = "label1";
            // 
            // frmDrzaveIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 776);
            Controls.Add(lblVrijeme);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvPodaci);
            Controls.Add(btnNovaDrzava);
            Name = "frmDrzaveIB230180";
            Text = "Drzave";
            Load += frmDrzaveIB230180_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovaDrzava;
        private DataGridView dgvPodaci;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewButtonColumn btnGradovi;
        private Button btnPrintaj;
        private Label lblVrijeme;
    }
}