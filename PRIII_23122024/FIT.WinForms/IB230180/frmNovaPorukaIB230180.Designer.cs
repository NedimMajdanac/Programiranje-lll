namespace FIT.WinForms.IB230180
{
    partial class frmNovaPorukaIB230180
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
            dtpValidnost = new DateTimePicker();
            cmbPredmet = new ComboBox();
            cmbHitnost = new ComboBox();
            btnSacuvaj = new Button();
            tbSadrzaj = new TextBox();
            pbSlika = new PictureBox();
            btnOdustani = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(33, 258);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(500, 47);
            dtpValidnost.TabIndex = 0;
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(33, 140);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(500, 49);
            cmbPredmet.TabIndex = 1;
            // 
            // cmbHitnost
            // 
            cmbHitnost.FormattingEnabled = true;
            cmbHitnost.Items.AddRange(new object[] { "Visoka", "Srednja", "Niska" });
            cmbHitnost.Location = new Point(33, 382);
            cmbHitnost.Name = "cmbHitnost";
            cmbHitnost.Size = new Size(500, 49);
            cmbHitnost.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1263, 1024);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(188, 58);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // tbSadrzaj
            // 
            tbSadrzaj.Location = new Point(33, 556);
            tbSadrzaj.Multiline = true;
            tbSadrzaj.Name = "tbSadrzaj";
            tbSadrzaj.Size = new Size(500, 418);
            tbSadrzaj.TabIndex = 4;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(588, 140);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(863, 834);
            pbSlika.TabIndex = 5;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(1026, 1024);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(188, 58);
            btnOdustani.TabIndex = 6;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 83);
            label1.Name = "label1";
            label1.Size = new Size(280, 41);
            label1.TabIndex = 7;
            label1.Text = "Odaberite predmet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 204);
            label2.Name = "label2";
            label2.Size = new Size(292, 41);
            label2.TabIndex = 8;
            label2.Text = "Poruka je validna do:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 324);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 9;
            label3.Text = "Hitnost poruke:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 83);
            label4.Name = "label4";
            label4.Size = new Size(85, 41);
            label4.TabIndex = 10;
            label4.Text = "Slika:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 491);
            label5.Name = "label5";
            label5.Size = new Size(222, 41);
            label5.TabIndex = 11;
            label5.Text = "Sadrzaj poruke:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaPorukaIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 1124);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOdustani);
            Controls.Add(pbSlika);
            Controls.Add(tbSadrzaj);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbHitnost);
            Controls.Add(cmbPredmet);
            Controls.Add(dtpValidnost);
            Name = "frmNovaPorukaIB230180";
            Text = "frmNovaPorukaIB230180";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpValidnost;
        private ComboBox cmbPredmet;
        private ComboBox cmbHitnost;
        private Button btnSacuvaj;
        private TextBox tbSadrzaj;
        private PictureBox pbSlika;
        private Button btnOdustani;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}