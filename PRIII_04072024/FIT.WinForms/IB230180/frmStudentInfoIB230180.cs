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
    public partial class frmStudentInfoIB230180 : Form
    {
        private Student kliknutiStudent;
        DLWMSDbContext db = new DLWMSDbContext();

        public frmStudentInfoIB230180(Student kliknutiStudent)
        {
            InitializeComponent();
            this.kliknutiStudent = kliknutiStudent;
            ucitajData();
        }

        private void ucitajData()
        {
            pbStudent.Image = Ekstenzije.ToImage(kliknutiStudent.Slika);
            lblIme.Text = kliknutiStudent.Ime + " " + kliknutiStudent.Prezime;

            List<PolozeniPredmetiIB230180> ocjena = db.PolozeniPredmeti.Where(x => x.StudentId == kliknutiStudent.Id).ToList();
            var prosjek = ocjena.Count == 0 ? "5" : ocjena.Average(x => x.Ocjena).ToString();

            lblProsjek.Text = $"Prosjek {prosjek}";
        }
    }
}
