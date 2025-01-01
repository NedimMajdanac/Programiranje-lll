namespace FIT.WinForms.IB230180
{
    partial class frmNovoUvjerenjeIB230180
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
            btnSacuvaj = new Button();
            cmbVrsta = new ComboBox();
            tbSvrha = new TextBox();
            pbSlika = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1578, 658);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(188, 58);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Location = new Point(42, 86);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(597, 49);
            cmbVrsta.TabIndex = 1;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(42, 231);
            tbSvrha.Multiline = true;
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(597, 564);
            tbSvrha.TabIndex = 2;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(711, 86);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(1055, 536);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 3;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 27);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 4;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 161);
            label2.Name = "label2";
            label2.Size = new Size(226, 41);
            label2.TabIndex = 5;
            label2.Text = "Svrha izdavanja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(711, 27);
            label3.Name = "label3";
            label3.Size = new Size(281, 41);
            label3.TabIndex = 6;
            label3.Text = "Skenirana uplatnica:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenjeIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1822, 837);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbSlika);
            Controls.Add(tbSvrha);
            Controls.Add(cmbVrsta);
            Controls.Add(btnSacuvaj);
            Name = "frmNovoUvjerenjeIB230180";
            Text = "frmNovoUvjerenjeIB230180";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private ComboBox cmbVrsta;
        private TextBox tbSvrha;
        private PictureBox pbSlika;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}