namespace FIT.WinForms.IB230180
{
    partial class frmGradoviIB230180
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
            pbZastava = new PictureBox();
            lblNaziv = new Label();
            label2 = new Label();
            dgvPodaci = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnPromijeni = new DataGridViewButtonColumn();
            btnDodaj = new Button();
            tbNaziv = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            tbInfo = new TextBox();
            label1 = new Label();
            btnGenerisi = new Button();
            cbStatus = new CheckBox();
            tbBrGradova = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(548, 345);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNaziv.Location = new Point(642, 128);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(229, 89);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 383);
            label2.Name = "label2";
            label2.Size = new Size(377, 41);
            label2.TabIndex = 2;
            label2.Text = "Unesite naziv novog grada:";
            label2.Click += label2_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Naziv, Aktivan, btnPromijeni });
            dgvPodaci.Location = new Point(8, 442);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1290, 222);
            dgvPodaci.TabIndex = 3;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
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
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 12;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnPromijeni
            // 
            btnPromijeni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnPromijeni.DataPropertyName = "btnPromijeni";
            btnPromijeni.HeaderText = "";
            btnPromijeni.MinimumWidth = 12;
            btnPromijeni.Name = "btnPromijeni";
            btnPromijeni.ReadOnly = true;
            btnPromijeni.Text = "Promijeni Status";
            btnPromijeni.UseColumnTextForButtonValue = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1110, 366);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(188, 58);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "DOdaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(414, 380);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(486, 47);
            tbNaziv.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(tbBrGradova);
            groupBox1.Location = new Point(12, 704);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1286, 699);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 85);
            label3.Name = "label3";
            label3.Size = new Size(193, 41);
            label3.TabIndex = 5;
            label3.Text = "Broj gradova:";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(29, 295);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(1251, 388);
            tbInfo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 227);
            label1.Name = "label1";
            label1.Size = new Size(77, 41);
            label1.TabIndex = 3;
            label1.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(735, 79);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(188, 58);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click_1;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(531, 85);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(153, 45);
            cbStatus.TabIndex = 1;
            cbStatus.Text = "Aktivna";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // tbBrGradova
            // 
            tbBrGradova.Location = new Point(244, 85);
            tbBrGradova.Name = "tbBrGradova";
            tbBrGradova.Size = new Size(250, 47);
            tbBrGradova.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmGradoviIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 1415);
            Controls.Add(groupBox1);
            Controls.Add(tbNaziv);
            Controls.Add(btnDodaj);
            Controls.Add(dgvPodaci);
            Controls.Add(label2);
            Controls.Add(lblNaziv);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB230180";
            Text = "frmGradoviIB230180";
            Load += frmGradoviIB230180_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblNaziv;
        private Label label2;
        private DataGridView dgvPodaci;
        private Button btnDodaj;
        private TextBox tbNaziv;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox tbInfo;
        private Label label1;
        private Button btnGenerisi;
        private CheckBox cbStatus;
        private TextBox tbBrGradova;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnPromijeni;
        private ErrorProvider errorProvider1;
    }
}