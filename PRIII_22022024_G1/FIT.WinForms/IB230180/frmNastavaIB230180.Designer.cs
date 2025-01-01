namespace FIT.WinForms.IB230180
{
    partial class frmNastavaIB230180
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
            cmbPredmeti = new ComboBox();
            cmbVrijeme = new ComboBox();
            cmbDan = new ComboBox();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            lblNaziv = new Label();
            lblOznaka = new Label();
            label1 = new Label();
            label2 = new Label();
            lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(54, 360);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(404, 49);
            cmbPredmeti.TabIndex = 0;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Location = new Point(867, 359);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(302, 49);
            cmbVrijeme.TabIndex = 1;
            // 
            // cmbDan
            // 
            cmbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDan.FormattingEnabled = true;
            cmbDan.Location = new Point(464, 360);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(397, 49);
            cmbDan.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1234, 354);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(188, 58);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvPodaci.Location = new Point(54, 474);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1368, 431);
            dgvPodaci.TabIndex = 4;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 12;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 12;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 12;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNaziv.Location = new Point(257, 113);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(229, 89);
            lblNaziv.TabIndex = 5;
            lblNaziv.Text = "label1";
            // 
            // lblOznaka
            // 
            lblOznaka.AutoSize = true;
            lblOznaka.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblOznaka.Location = new Point(960, 113);
            lblOznaka.Name = "lblOznaka";
            lblOznaka.Size = new Size(229, 89);
            lblOznaka.TabIndex = 6;
            lblOznaka.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 304);
            label1.Name = "label1";
            label1.Size = new Size(145, 41);
            label1.TabIndex = 7;
            label1.Text = "Predmeti:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(867, 304);
            label2.Name = "label2";
            label2.Size = new Size(125, 41);
            label2.TabIndex = 8;
            label2.Text = "Vrijeme:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(464, 304);
            lbl.Name = "lbl";
            lbl.Size = new Size(78, 41);
            lbl.TabIndex = 9;
            lbl.Text = "Dan:";
            // 
            // frmNastavaIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 1065);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblOznaka);
            Controls.Add(lblNaziv);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(cmbDan);
            Controls.Add(cmbVrijeme);
            Controls.Add(cmbPredmeti);
            Name = "frmNastavaIB230180";
            Text = "frmNastavaIB230180";
            Load += frmNastavaIB230180_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPredmeti;
        private ComboBox cmbVrijeme;
        private ComboBox cmbDan;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private Label lblNaziv;
        private Label lblOznaka;
        private Label label1;
        private Label label2;
        private Label lbl;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}