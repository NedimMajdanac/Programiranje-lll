using FIT.Data;
using FIT.Data.IB230180;
using FIT.Infrastructure;
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
    public partial class frmPretragaIB230180 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studentPodaci = new List<Student>();
        public frmPretragaIB230180()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;

        }

        private void frmPretragaIB230180_Load(object sender, EventArgs e)
        {
            UcitajDrzaveCMB();
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            studentPodaci = db.Studenti.ToList();
            UcitajPodatke(studentPodaci);
        }

        private void UcitajPodatke(List<Student> studentPodaci)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Columns.Add("Grad");
            dt.Columns.Add("Drzava");
            dt.Columns.Add("Prosjek");

            for (int i = 0; i < studentPodaci.Count; i++)
            {
                var student = studentPodaci[i];
                var red = dt.NewRow();

                List<DrzaveIB230180> drzavaPodaci = db.DrzaveIB230180.ToList();
                List<GradoviIB230180> gradPodaci = db.GradoviIB230180.ToList();
                List<PolozeniPredmetiIB230180> ocjena = db.PolozeniPredmeti.ToList();

                var grad = db.GradoviIB230180.FirstOrDefault(x => x.Id == student.GradId);
                var drzava = db.DrzaveIB230180.FirstOrDefault(x => x.Id == grad.DrzavaId);

                red["Ime"] = student.Ime.ToString();
                red["Prezime"] = student.Prezime.ToString();
                red["Grad"] = grad.Naziv;
                red["Drzava"] = drzava.Naziv;
                red["Prosjek"] = ocjena.Count() == 0 ? "5" : ocjena.Average(x => x.Ocjena);

                dt.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = dt;
        }

        private void UcitajDrzaveCMB()
        {
            cmbDrzave.DataSource = db.DrzaveIB230180.ToList();
            cmbDrzave.DisplayMember = "Naziv";
            var drzava = cmbDrzave.SelectedItem as DrzaveIB230180;
            UcitajGradoveCMB(drzava);
        }

        private void UcitajGradoveCMB(DrzaveIB230180? drzava)
        {
            var grad = db.GradoviIB230180.ToList();
            cmbGradovi.DataSource = grad
                .Where(x => x.DrzavaId == drzava.Id)
                .ToList();
            cmbDrzave.DisplayMember = "Naziv";
        }

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzave.SelectedItem as DrzaveIB230180;
            UcitajGradoveCMB(drzava);

            UcitajPretragu();
        }

        private void cmbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPretragu();
        }

        private void UcitajPretragu()
        {
            var filterGrad = cmbGradovi.SelectedItem as GradoviIB230180;

            if(filterGrad != null)
            {
                studentPodaci = db.Studenti
                    .Where(x => x.GradId == filterGrad.Id)
                    .ToList();

                if(studentPodaci.Count == 0)
                {
                    MessageBox.Show("Nema podataka");
                }
                UcitajPodatke(studentPodaci);
            }
        }
    }
}
