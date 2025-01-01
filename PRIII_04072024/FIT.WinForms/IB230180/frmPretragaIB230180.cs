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
        List<Student> podaciStudent = new List<Student>();
        public frmPretragaIB230180()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
            podaciStudent = db.Studenti.ToList();
            ucitajPodatke(podaciStudent);
            ucitajCMB();
        }

        private void ucitajCMB()
        {
            cmbSpol.DataSource = db.Studenti.Select(x => x.Spol).Distinct().ToList();
        }

        private void ucitajPodatke(List<Student> podaciStudent)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("BrojIndeksa");
            dt.Columns.Add("ImePrezime");
            dt.Columns.Add("Prosjek");
            dt.Columns.Add("DatumRodjenja");
            dt.Columns.Add("Aktivan", typeof(bool));

            for (int i = 0; i < podaciStudent.Count; i++)
            {
                var red = dt.NewRow();
                var student = podaciStudent[i];

                List<PolozeniPredmetiIB230180> ocjena = db.PolozeniPredmeti
                    .Where(x => x.StudentId == student.Id)
                    .ToList();

                red["BrojIndeksa"] = student.Indeks;
                red["ImePrezime"] = student.Ime + student.Prezime;
                red["Prosjek"] = ocjena.Count == 0 ? "5" : ocjena.Average(x => x.Ocjena).ToString();
                red["DatumRodjenja"] = student.DatumRodjenja;
                red["Aktivan"] = student.Aktivan;

                dt.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = dt;
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dtpOD_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dtpDO_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void ucitajStudente()
        {
            var spol = cmbSpol.SelectedItem.ToString();
            var datumOD = dtpOD.Value;
            var datumDO = dtpDO.Value;

            if (spol != "svi")
            {
                podaciStudent = db.Studenti
                    .Where(x => x.Spol == spol && x.DatumRodjenja >= datumOD && x.DatumRodjenja <= datumDO)
                    .ToList();
            }
            else
            {
                podaciStudent = db.Studenti
                    .Where(x => x.DatumRodjenja >= datumOD && x.DatumRodjenja <= datumDO)
                    .ToList();
            }
            ucitajPodatke(podaciStudent);
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPodaci.Columns[e.ColumnIndex].Name == "btnUvjerenja")
            {
                var kliknutiStudent = podaciStudent[e.RowIndex];
                var novaForma = new UvjerenjaIB230180(kliknutiStudent);
                novaForma.ShowDialog();
            }
            else
            {
                var kliknutiStudent = podaciStudent[e.RowIndex];
                var novaForma = new frmStudentInfoIB230180(kliknutiStudent);
                novaForma.ShowDialog();
            }
        }
    }
}
