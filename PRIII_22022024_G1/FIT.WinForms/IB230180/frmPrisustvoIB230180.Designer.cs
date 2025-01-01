namespace FIT.WinForms.IB230180
{
    partial class frmPrisustvoIB230180
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
            components = new System.ComponentModel.Container();
            cmbNastava = new ComboBox();
            cmbStudenti = new ComboBox();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            PredmetProstorijaVrijeme = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblOznaka = new Label();
            lblNaziv = new Label();
            lblPrisustvo = new Label();
            label5 = new Label();
            grpbGenerator = new GroupBox();
            tbGenerator = new TextBox();
            btnGenerisi = new Button();
            tbBrZapisa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            grpbGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cmbNastava
            // 
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(77, 268);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(568, 49);
            cmbNastava.TabIndex = 0;
            cmbNastava.SelectedIndexChanged += cmbNastava_SelectedIndexChanged;
            // 
            // cmbStudenti
            // 
            cmbStudenti.FormattingEnabled = true;
            cmbStudenti.Location = new Point(695, 268);
            cmbStudenti.Name = "cmbStudenti";
            cmbStudenti.Size = new Size(501, 49);
            cmbStudenti.TabIndex = 1;
            cmbStudenti.SelectedIndexChanged += cmbStudenti_SelectedIndexChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1253, 259);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(188, 58);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { PredmetProstorijaVrijeme, Student });
            dgvPodaci.Location = new Point(77, 380);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1364, 375);
            dgvPodaci.TabIndex = 3;
            // 
            // PredmetProstorijaVrijeme
            // 
            PredmetProstorijaVrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PredmetProstorijaVrijeme.DataPropertyName = "PredmetProstorijaVrijeme";
            PredmetProstorijaVrijeme.HeaderText = "PredmetProstorijaVrijeme";
            PredmetProstorijaVrijeme.MinimumWidth = 12;
            PredmetProstorijaVrijeme.Name = "PredmetProstorijaVrijeme";
            PredmetProstorijaVrijeme.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 12;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 201);
            label1.Name = "label1";
            label1.Size = new Size(129, 41);
            label1.TabIndex = 4;
            label1.Text = "Nastava:";
            // 
            // lblOznaka
            // 
            lblOznaka.AutoSize = true;
            lblOznaka.Font = new Font("Segoe UI", 20F);
            lblOznaka.Location = new Point(630, 58);
            lblOznaka.Name = "lblOznaka";
            lblOznaka.Size = new Size(214, 89);
            lblOznaka.TabIndex = 5;
            lblOznaka.Text = "label2";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 20F);
            lblNaziv.Location = new Point(77, 58);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(214, 89);
            lblNaziv.TabIndex = 6;
            lblNaziv.Text = "label3";
            // 
            // lblPrisustvo
            // 
            lblPrisustvo.AutoSize = true;
            lblPrisustvo.Font = new Font("Segoe UI", 20F);
            lblPrisustvo.Location = new Point(1227, 58);
            lblPrisustvo.Name = "lblPrisustvo";
            lblPrisustvo.Size = new Size(214, 89);
            lblPrisustvo.TabIndex = 7;
            lblPrisustvo.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(695, 201);
            label5.Name = "label5";
            label5.Size = new Size(128, 41);
            label5.TabIndex = 8;
            label5.Text = "Student:";
            // 
            // grpbGenerator
            // 
            grpbGenerator.Controls.Add(tbGenerator);
            grpbGenerator.Controls.Add(btnGenerisi);
            grpbGenerator.Controls.Add(tbBrZapisa);
            grpbGenerator.Controls.Add(label3);
            grpbGenerator.Controls.Add(label2);
            grpbGenerator.Location = new Point(77, 821);
            grpbGenerator.Name = "grpbGenerator";
            grpbGenerator.Size = new Size(1364, 565);
            grpbGenerator.TabIndex = 9;
            grpbGenerator.TabStop = false;
            grpbGenerator.Text = "Generator";
            // 
            // tbGenerator
            // 
            tbGenerator.Location = new Point(26, 261);
            tbGenerator.Multiline = true;
            tbGenerator.Name = "tbGenerator";
            tbGenerator.Size = new Size(1311, 298);
            tbGenerator.TabIndex = 4;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(502, 74);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(188, 58);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // tbBrZapisa
            // 
            tbBrZapisa.Location = new Point(217, 80);
            tbBrZapisa.Name = "tbBrZapisa";
            tbBrZapisa.Size = new Size(211, 47);
            tbBrZapisa.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 186);
            label3.Name = "label3";
            label3.Size = new Size(77, 41);
            label3.TabIndex = 1;
            label3.Text = "Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 80);
            label2.Name = "label2";
            label2.Size = new Size(167, 41);
            label2.TabIndex = 0;
            label2.Text = "Broj zapisa:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPrisustvoIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 1457);
            Controls.Add(grpbGenerator);
            Controls.Add(label5);
            Controls.Add(lblPrisustvo);
            Controls.Add(lblNaziv);
            Controls.Add(lblOznaka);
            Controls.Add(label1);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudenti);
            Controls.Add(cmbNastava);
            Name = "frmPrisustvoIB230180";
            Text = "frmPrisustvoIB230180";
            Load += frmPrisustvoIB230180_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            grpbGenerator.ResumeLayout(false);
            grpbGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbNastava;
        private ComboBox cmbStudenti;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private Label label1;
        private Label lblOznaka;
        private Label lblNaziv;
        private Label lblPrisustvo;
        private Label label5;
        private GroupBox grpbGenerator;
        private TextBox tbGenerator;
        private Button btnGenerisi;
        private TextBox tbBrZapisa;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn PredmetProstorijaVrijeme;
        private DataGridViewTextBoxColumn Student;
        private ErrorProvider errorProvider1;
    }
}