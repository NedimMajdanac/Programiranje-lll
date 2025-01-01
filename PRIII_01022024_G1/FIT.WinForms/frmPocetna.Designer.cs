namespace FIT.WinForms
{
    partial class frmPocetna
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
            lblKonekcijaInfo = new Label();
            btnIzvjestaj = new Button();
            btnPretraga = new Button();
            btnDrzaveGradovi = new Button();
            SuspendLayout();
            // 
            // lblKonekcijaInfo
            // 
            lblKonekcijaInfo.AutoSize = true;
            lblKonekcijaInfo.Font = new Font("Segoe UI", 15F);
            lblKonekcijaInfo.Location = new Point(243, 197);
            lblKonekcijaInfo.Margin = new Padding(7, 0, 7, 0);
            lblKonekcijaInfo.Name = "lblKonekcijaInfo";
            lblKonekcijaInfo.Size = new Size(0, 67);
            lblKonekcijaInfo.TabIndex = 0;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(335, 314);
            btnIzvjestaj.Margin = new Padding(7, 8, 7, 8);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(440, 63);
            btnIzvjestaj.TabIndex = 1;
            btnIzvjestaj.Text = "Izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(619, 450);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(301, 147);
            btnPretraga.TabIndex = 2;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += btnPretraga_Click;
            // 
            // btnDrzaveGradovi
            // 
            btnDrzaveGradovi.Location = new Point(188, 450);
            btnDrzaveGradovi.Name = "btnDrzaveGradovi";
            btnDrzaveGradovi.Size = new Size(301, 147);
            btnDrzaveGradovi.TabIndex = 3;
            btnDrzaveGradovi.Text = "Drzave Gradovi";
            btnDrzaveGradovi.UseVisualStyleBackColor = true;
            btnDrzaveGradovi.Click += btnDrzaveGradovi_Click;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 831);
            Controls.Add(btnDrzaveGradovi);
            Controls.Add(btnPretraga);
            Controls.Add(btnIzvjestaj);
            Controls.Add(lblKonekcijaInfo);
            Margin = new Padding(7, 8, 7, 8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template 2023/24";
            Load += frmPocetna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKonekcijaInfo;
        private Button btnIzvjestaj;
        private Button btnPretraga;
        private Button btnDrzaveGradovi;
    }
}