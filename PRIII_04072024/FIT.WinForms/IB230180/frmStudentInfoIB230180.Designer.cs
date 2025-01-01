namespace FIT.WinForms.IB230180
{
    partial class frmStudentInfoIB230180
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
            lblIme = new Label();
            lblProsjek = new Label();
            pbStudent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbStudent).BeginInit();
            SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(306, 671);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(97, 41);
            lblIme.TabIndex = 0;
            lblIme.Text = "label1";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(306, 834);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(97, 41);
            lblProsjek.TabIndex = 1;
            lblProsjek.Text = "label2";
            // 
            // pbStudent
            // 
            pbStudent.Location = new Point(34, 71);
            pbStudent.Name = "pbStudent";
            pbStudent.Size = new Size(721, 494);
            pbStudent.TabIndex = 2;
            pbStudent.TabStop = false;
            // 
            // frmStudentInfoIB230180
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 917);
            Controls.Add(pbStudent);
            Controls.Add(lblProsjek);
            Controls.Add(lblIme);
            Name = "frmStudentInfoIB230180";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIme;
        private Label lblProsjek;
        private PictureBox pbStudent;
    }
}