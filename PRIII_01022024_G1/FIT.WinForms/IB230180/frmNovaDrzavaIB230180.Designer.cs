namespace FIT.WinForms.IB230180
{
    partial class frmNovaDrzavaIB230180
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
            pbSlika = new PictureBox();
            tbNaziv = new TextBox();
            btnSacuvaj = new Button();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            cbAktivna = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(52, 102);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(715, 492);
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(52, 685);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(715, 47);
            tbNaziv.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(579, 787);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(188, 58);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(124, 41);
            label1.TabIndex = 3;
            label1.Text = "Zastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 626);
            label2.Name = "label2";
            label2.Size = new Size(90, 41);
            label2.TabIndex = 4;
            label2.Text = "Naziv";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Location = new Point(52, 800);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(153, 45);
            cbAktivna.TabIndex = 5;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // frmNovaDrzavaIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 933);
            Controls.Add(cbAktivna);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Controls.Add(tbNaziv);
            Controls.Add(pbSlika);
            Name = "frmNovaDrzavaIB230180";
            Text = "Podaci o drzavi";
            Load += frmNovaDrzavaIB230180_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private TextBox tbNaziv;
        private Button btnSacuvaj;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
        private CheckBox cbAktivna;
    }
}