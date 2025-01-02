using FIT.Data;
using FIT.Data.IB230180;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB230180
{
    public partial class frmNovaPorukaIB230180 : Form
    {
        DLWMSDbContext dbContext = new DLWMSDbContext();
        private Student kliknutiStudent;

        public frmNovaPorukaIB230180(Student kliknutiStudent)
        {
            InitializeComponent();
            UcitajCMB();
            this.kliknutiStudent = kliknutiStudent;
        }

        private void UcitajCMB()
        {
            cmbPredmet.DataSource = dbContext.Predmeti.Select(x=>x.Naziv).Distinct().ToList();
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var novaPoruka = new StudentiPorukeIB230180()
                {
                    PredmetId = cmbPredmet.SelectedIndex + 1,   
                    StudentId = kliknutiStudent.Id,
                    Predmet = cmbPredmet.SelectedItem as PredmetiIB230180,
                    Validnost = dtpValidnost.Value.ToString(),
                    Sadrzaj = tbSadrzaj.Text,
                    Slika = Ekstenzije.ToByteArray(pbSlika.Image),
                    Hitnost = cmbHitnost.SelectedItem.ToString(),
                };
                dbContext.StudentiPorukeIB230180.Add(novaPoruka);
                dbContext.SaveChanges();
                MessageBox.Show("Poruka uspješno sačuvana!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(cmbHitnost, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(cmbPredmet, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbSadrzaj, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(dtpValidnost, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
