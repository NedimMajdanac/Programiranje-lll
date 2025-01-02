namespace FIT.WinForms.IB230180
{
    partial class frmPorukeIB230180
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
            btnNovaPoruka = new Button();
            btnPrintaj = new Button();
            dgvPodaci = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Hitnost = new DataGridViewTextBoxColumn();
            Validnost = new DataGridViewTextBoxColumn();
            btnBrisi = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbValidnost = new ComboBox();
            cmbPredmeti = new ComboBox();
            btnDodaj = new Button();
            tbBrPoruka = new TextBox();
            tbInfo = new TextBox();
            lblPoruka = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(1840, 69);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(248, 58);
            btnNovaPoruka.TabIndex = 0;
            btnNovaPoruka.Text = "Nova poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(1900, 568);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(188, 58);
            btnPrintaj.TabIndex = 1;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Hitnost, Validnost, btnBrisi });
            dgvPodaci.Location = new Point(12, 163);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(2076, 372);
            dgvPodaci.TabIndex = 2;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
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
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.MinimumWidth = 12;
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Slika.MinimumWidth = 12;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Hitnost
            // 
            Hitnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hitnost.DataPropertyName = "Hitnost";
            Hitnost.HeaderText = "Hitnost";
            Hitnost.MinimumWidth = 12;
            Hitnost.Name = "Hitnost";
            Hitnost.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.MinimumWidth = 12;
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // btnBrisi
            // 
            btnBrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnBrisi.DataPropertyName = "btnBrisi";
            btnBrisi.HeaderText = "";
            btnBrisi.MinimumWidth = 12;
            btnBrisi.Name = "btnBrisi";
            btnBrisi.ReadOnly = true;
            btnBrisi.Text = "Brisi";
            btnBrisi.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbValidnost);
            groupBox1.Controls.Add(cmbPredmeti);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(tbBrPoruka);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Location = new Point(12, 645);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2076, 609);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 57);
            label2.Name = "label2";
            label2.Size = new Size(77, 41);
            label2.TabIndex = 5;
            label2.Text = "Info:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 57);
            label3.Name = "label3";
            label3.Size = new Size(178, 41);
            label3.TabIndex = 6;
            label3.Text = "Broj poruka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 187);
            label4.Name = "label4";
            label4.Size = new Size(138, 41);
            label4.TabIndex = 7;
            label4.Text = "Predmet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 327);
            label5.Name = "label5";
            label5.Size = new Size(292, 41);
            label5.TabIndex = 8;
            label5.Text = "Poruka je validna do:";
            // 
            // cmbValidnost
            // 
            cmbValidnost.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbValidnost.FormattingEnabled = true;
            cmbValidnost.Location = new Point(29, 381);
            cmbValidnost.Name = "cmbValidnost";
            cmbValidnost.Size = new Size(302, 49);
            cmbValidnost.TabIndex = 4;
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(29, 246);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(302, 49);
            cmbPredmeti.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(29, 505);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(302, 58);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // tbBrPoruka
            // 
            tbBrPoruka.Location = new Point(29, 114);
            tbBrPoruka.Name = "tbBrPoruka";
            tbBrPoruka.Size = new Size(302, 47);
            tbBrPoruka.TabIndex = 1;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(424, 114);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(1629, 449);
            tbInfo.TabIndex = 0;
            // 
            // lblPoruka
            // 
            lblPoruka.AutoSize = true;
            lblPoruka.Location = new Point(12, 59);
            lblPoruka.Name = "lblPoruka";
            lblPoruka.Size = new Size(97, 41);
            lblPoruka.TabIndex = 4;
            lblPoruka.Text = "label1";
            // 
            // frmPorukeIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2100, 1285);
            Controls.Add(lblPoruka);
            Controls.Add(groupBox1);
            Controls.Add(dgvPodaci);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaPoruka);
            Name = "frmPorukeIB230180";
            Text = "frmPorukeIB230180";
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovaPoruka;
        private Button btnPrintaj;
        private DataGridView dgvPodaci;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbValidnost;
        private ComboBox cmbPredmeti;
        private Button btnDodaj;
        private TextBox tbBrPoruka;
        private TextBox tbInfo;
        private Label lblPoruka;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Hitnost;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn btnBrisi;
    }
}