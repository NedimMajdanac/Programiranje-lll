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
            cmbSemestar = new ComboBox();
            cmbUloga = new ComboBox();
            dgvPodaci = new DataGridView();
            indeks = new DataGridViewTextBoxColumn();
            ime = new DataGridViewTextBoxColumn();
            datum = new DataGridViewTextBoxColumn();
            ocjena = new DataGridViewTextBoxColumn();
            uloga = new DataGridViewTextBoxColumn();
            aktivan = new DataGridViewCheckBoxColumn();
            btnPoruke = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpDatumOD = new DateTimePicker();
            dtpDatumDO = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // cmbSemestar
            // 
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(165, 64);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(302, 49);
            cmbSemestar.TabIndex = 0;
            cmbSemestar.SelectedIndexChanged += cmbSemestar_SelectedIndexChanged;
            // 
            // cmbUloga
            // 
            cmbUloga.FormattingEnabled = true;
            cmbUloga.Location = new Point(601, 64);
            cmbUloga.Name = "cmbUloga";
            cmbUloga.Size = new Size(302, 49);
            cmbUloga.TabIndex = 1;
            cmbUloga.SelectedIndexChanged += cmbUloga_SelectedIndexChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { indeks, ime, datum, ocjena, uloga, aktivan, btnPoruke });
            dgvPodaci.Location = new Point(12, 189);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(2354, 375);
            dgvPodaci.TabIndex = 2;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // indeks
            // 
            indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            indeks.DataPropertyName = "indeks";
            indeks.HeaderText = "indeks";
            indeks.MinimumWidth = 12;
            indeks.Name = "indeks";
            indeks.ReadOnly = true;
            // 
            // ime
            // 
            ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ime.DataPropertyName = "ime";
            ime.HeaderText = "ime";
            ime.MinimumWidth = 12;
            ime.Name = "ime";
            ime.ReadOnly = true;
            // 
            // datum
            // 
            datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            datum.DataPropertyName = "datum";
            datum.HeaderText = "datum";
            datum.MinimumWidth = 12;
            datum.Name = "datum";
            datum.ReadOnly = true;
            // 
            // ocjena
            // 
            ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ocjena.DataPropertyName = "ocjena";
            ocjena.HeaderText = "ocjena";
            ocjena.MinimumWidth = 12;
            ocjena.Name = "ocjena";
            ocjena.ReadOnly = true;
            // 
            // uloga
            // 
            uloga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            uloga.DataPropertyName = "uloga";
            uloga.HeaderText = "uloga";
            uloga.MinimumWidth = 12;
            uloga.Name = "uloga";
            uloga.ReadOnly = true;
            // 
            // aktivan
            // 
            aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aktivan.DataPropertyName = "aktivan";
            aktivan.HeaderText = "aktivan";
            aktivan.MinimumWidth = 12;
            aktivan.Name = "aktivan";
            aktivan.ReadOnly = true;
            aktivan.Resizable = DataGridViewTriState.True;
            aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnPoruke
            // 
            btnPoruke.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnPoruke.DataPropertyName = "btnPoruke";
            btnPoruke.HeaderText = "";
            btnPoruke.MinimumWidth = 12;
            btnPoruke.Name = "btnPoruke";
            btnPoruke.ReadOnly = true;
            btnPoruke.Text = "Poruke";
            btnPoruke.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(147, 41);
            label1.TabIndex = 3;
            label1.Text = "Semestar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 67);
            label2.Name = "label2";
            label2.Size = new Size(104, 41);
            label2.TabIndex = 4;
            label2.Text = "Uloga:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(931, 58);
            label3.Name = "label3";
            label3.Size = new Size(299, 41);
            label3.TabIndex = 5;
            label3.Text = "Rodjen u periodu od:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1794, 64);
            label4.Name = "label4";
            label4.Size = new Size(61, 41);
            label4.TabIndex = 6;
            label4.Text = "do:";
            // 
            // dtpDatumOD
            // 
            dtpDatumOD.Location = new Point(1268, 59);
            dtpDatumOD.Name = "dtpDatumOD";
            dtpDatumOD.Size = new Size(500, 47);
            dtpDatumOD.TabIndex = 7;
            dtpDatumOD.ValueChanged += dtpDatumOD_ValueChanged;
            // 
            // dtpDatumDO
            // 
            dtpDatumDO.Location = new Point(1866, 59);
            dtpDatumDO.Name = "dtpDatumDO";
            dtpDatumDO.Size = new Size(500, 47);
            dtpDatumDO.TabIndex = 8;
            dtpDatumDO.ValueChanged += dtpDatumDO_ValueChanged;
            // 
            // frmPretragaIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2417, 692);
            Controls.Add(dtpDatumDO);
            Controls.Add(dtpDatumOD);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbUloga);
            Controls.Add(cmbSemestar);
            Name = "frmPretragaIB230180";
            Text = "Pretraga studenata";
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSemestar;
        private ComboBox cmbUloga;
        private DataGridView dgvPodaci;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpDatumOD;
        private DateTimePicker dtpDatumDO;
        private DataGridViewTextBoxColumn indeks;
        private DataGridViewTextBoxColumn ime;
        private DataGridViewTextBoxColumn datum;
        private DataGridViewTextBoxColumn ocjena;
        private DataGridViewTextBoxColumn uloga;
        private DataGridViewCheckBoxColumn aktivan;
        private DataGridViewButtonColumn btnPoruke;
    }
}