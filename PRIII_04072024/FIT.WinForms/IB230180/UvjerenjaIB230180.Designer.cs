namespace FIT.WinForms.IB230180
{
    partial class UvjerenjaIB230180
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
            dgvPodaci = new DataGridView();
            Datum = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            btnBrisi = new DataGridViewButtonColumn();
            btnPrintaj = new DataGridViewButtonColumn();
            btnNoviZahtjev = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGenerisi = new Button();
            tbInfo = new TextBox();
            tbSvrha = new TextBox();
            tbBrojZahtjeva = new TextBox();
            cmbVrsta = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Datum, Vrsta, Svrha, Uplatnica, Printano, btnBrisi, btnPrintaj });
            dgvPodaci.Location = new Point(12, 113);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1864, 375);
            dgvPodaci.TabIndex = 0;
            dgvPodaci.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 12;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 12;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 12;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            Svrha.Width = 250;
            // 
            // Uplatnica
            // 
            Uplatnica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Uplatnica.MinimumWidth = 12;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Resizable = DataGridViewTriState.True;
            Uplatnica.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Printano
            // 
            Printano.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 12;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
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
            // btnPrintaj
            // 
            btnPrintaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnPrintaj.DataPropertyName = "btnPrintaj";
            btnPrintaj.HeaderText = "";
            btnPrintaj.MinimumWidth = 12;
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.ReadOnly = true;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseColumnTextForButtonValue = true;
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(1605, 38);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(271, 58);
            btnNoviZahtjev.TabIndex = 1;
            btnNoviZahtjev.Text = "Novi Zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(tbSvrha);
            groupBox1.Controls.Add(tbBrojZahtjeva);
            groupBox1.Controls.Add(cmbVrsta);
            groupBox1.Location = new Point(12, 531);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1864, 780);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanja uvjerenja";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 211);
            label4.Name = "label4";
            label4.Size = new Size(77, 41);
            label4.TabIndex = 3;
            label4.Text = "Info:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1032, 73);
            label3.Name = "label3";
            label3.Size = new Size(193, 41);
            label3.TabIndex = 7;
            label3.Text = "Broj zahtjeva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 73);
            label2.Name = "label2";
            label2.Size = new Size(223, 41);
            label2.TabIndex = 6;
            label2.Text = "Svrha uvjerenja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 73);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 5;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(1549, 125);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(188, 58);
            btnGenerisi.TabIndex = 4;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(29, 293);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(1783, 458);
            tbInfo.TabIndex = 3;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(536, 136);
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(456, 47);
            tbSvrha.TabIndex = 2;
            // 
            // tbBrojZahtjeva
            // 
            tbBrojZahtjeva.Location = new Point(1032, 134);
            tbBrojZahtjeva.Name = "tbBrojZahtjeva";
            tbBrojZahtjeva.Size = new Size(250, 47);
            tbBrojZahtjeva.TabIndex = 1;
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Location = new Point(29, 134);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(456, 49);
            cmbVrsta.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UvjerenjaIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1888, 1330);
            Controls.Add(groupBox1);
            Controls.Add(btnNoviZahtjev);
            Controls.Add(dgvPodaci);
            Name = "UvjerenjaIB230180";
            Text = "UvjerenjaIB230180";
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPodaci;
        private Button btnNoviZahtjev;
        private GroupBox groupBox1;
        private TextBox tbInfo;
        private TextBox tbSvrha;
        private TextBox tbBrojZahtjeva;
        private ComboBox cmbVrsta;
        private Button btnGenerisi;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn btnBrisi;
        private DataGridViewButtonColumn btnPrintaj;
        private ErrorProvider errorProvider1;
    }
}