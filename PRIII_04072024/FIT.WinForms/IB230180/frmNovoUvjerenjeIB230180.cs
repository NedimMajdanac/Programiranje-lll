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
    public partial class frmNovoUvjerenjeIB230180 : Form
    {
        private Student kliknutiStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovoUvjerenjeIB230180(Student kliknutiStudent)
        {
            InitializeComponent();
            this.kliknutiStudent = kliknutiStudent;
            UcitajCMB();
        }

        private void UcitajCMB()
        {
            cmbVrsta.DataSource = db.StudentiUvjerenjaIB230180.Select(x => x.Vrsta).Distinct().ToList();
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
            if (Validno())
            {
                var novoUvjerenje = new StudentiUvjerenjaIB230180()
                {
                    StudentId = kliknutiStudent.Id,
                    Vrijeme = DateTime.Now.ToString(),
                    Vrsta = cmbVrsta.SelectedItem.ToString(),
                    Svrha = tbSvrha.Text,
                    Uplatnica = Ekstenzije.ToByteArray(pbSlika.Image),
                    Printano = false,
                };
                db.StudentiUvjerenjaIB230180.Add(novoUvjerenje);
                db.SaveChanges();
                Close();
            }
        }

        private bool Validno()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbSvrha, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(cmbVrsta, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
