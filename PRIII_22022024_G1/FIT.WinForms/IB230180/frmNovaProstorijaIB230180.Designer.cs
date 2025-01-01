namespace FIT.WinForms.IB230180
{
    partial class frmNovaProstorijaIB230180
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
            pbLogo = new PictureBox();
            tbKapacitet = new TextBox();
            tbOznaka = new TextBox();
            tbNaziv = new TextBox();
            btnSacuvaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(37, 147);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(404, 407);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            // 
            // tbKapacitet
            // 
            tbKapacitet.Location = new Point(790, 358);
            tbKapacitet.Name = "tbKapacitet";
            tbKapacitet.Size = new Size(250, 47);
            tbKapacitet.TabIndex = 1;
            // 
            // tbOznaka
            // 
            tbOznaka.Location = new Point(481, 358);
            tbOznaka.Name = "tbOznaka";
            tbOznaka.Size = new Size(250, 47);
            tbOznaka.TabIndex = 2;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(481, 216);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(559, 47);
            tbNaziv.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(852, 496);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(188, 58);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 64);
            label1.Name = "label1";
            label1.Size = new Size(93, 41);
            label1.TabIndex = 5;
            label1.Text = "Logo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 296);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 6;
            label2.Text = "Oznaka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(790, 296);
            label3.Name = "label3";
            label3.Size = new Size(147, 41);
            label3.TabIndex = 7;
            label3.Text = "Kapacitet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 147);
            label4.Name = "label4";
            label4.Size = new Size(97, 41);
            label4.TabIndex = 8;
            label4.Text = "Naziv:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaProstorijaIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 632);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Controls.Add(tbNaziv);
            Controls.Add(tbOznaka);
            Controls.Add(tbKapacitet);
            Controls.Add(pbLogo);
            Name = "frmNovaProstorijaIB230180";
            Text = "frmNovaProstorijaIB230180";
            Load += frmNovaProstorijaIB230180_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private TextBox tbKapacitet;
        private TextBox tbOznaka;
        private TextBox tbNaziv;
        private Button btnSacuvaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}