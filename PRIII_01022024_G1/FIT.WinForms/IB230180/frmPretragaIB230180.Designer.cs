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
            dgvPodaci = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            cmbGradovi = new ComboBox();
            cmbDrzave = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Grad, Drzava, Prosjek });
            dgvPodaci.Location = new Point(33, 220);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1636, 375);
            dgvPodaci.TabIndex = 0;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 12;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 12;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 12;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
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
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 12;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 52);
            label1.Name = "label1";
            label1.Size = new Size(115, 41);
            label1.TabIndex = 1;
            label1.Text = "Drzave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(629, 52);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 2;
            label2.Text = "Gradovi:";
            // 
            // cmbGradovi
            // 
            cmbGradovi.FormattingEnabled = true;
            cmbGradovi.Location = new Point(629, 112);
            cmbGradovi.Name = "cmbGradovi";
            cmbGradovi.Size = new Size(496, 49);
            cmbGradovi.TabIndex = 3;
            cmbGradovi.SelectedIndexChanged += cmbGradovi_SelectedIndexChanged;
            // 
            // cmbDrzave
            // 
            cmbDrzave.FormattingEnabled = true;
            cmbDrzave.Location = new Point(33, 112);
            cmbDrzave.Name = "cmbDrzave";
            cmbDrzave.Size = new Size(496, 49);
            cmbDrzave.TabIndex = 4;
            cmbDrzave.SelectedIndexChanged += cmbDrzave_SelectedIndexChanged;
            // 
            // frmPretragaIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 692);
            Controls.Add(cmbDrzave);
            Controls.Add(cmbGradovi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPodaci);
            Name = "frmPretragaIB230180";
            Text = "frmPretragaIB230180";
            Load += frmPretragaIB230180_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPodaci;
        private Label label1;
        private Label label2;
        private ComboBox cmbGradovi;
        private ComboBox cmbDrzave;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Prosjek;
    }
}