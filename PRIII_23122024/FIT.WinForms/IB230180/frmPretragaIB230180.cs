using FIT.Data;
using FIT.Data.IB230180;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
            studentPodaci = db.Studenti.ToList();
            ucitajPodatke(studentPodaci);
            UcitajCMB();
        }

        private void UcitajCMB()
        {
            cmbSemestar.DataSource = db.Semestri.Select(x => x.Oznaka).Distinct().ToList();
            cmbUloga.DataSource = db.Uloge.Select(x => x.Naziv).Distinct().ToList();
        }

        private void cmbSemestar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void cmbUloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dtpDatumOD_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dtpDatumDO_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void ucitajPodatke(List<Student> studentPodaci)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("indeks");
            dt.Columns.Add("ime");
            dt.Columns.Add("datum");
            dt.Columns.Add("ocjena");
            dt.Columns.Add("uloga");
            dt.Columns.Add("aktivan");

            for (int i = 0; i < studentPodaci.Count; i++)
            {
                var student = studentPodaci[i];
                var red = dt.NewRow();

                List<PolozeniPredmetiIB230180> ocjene = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).ToList();

                var nazivUloge = db.StudentiUloge
                    .Where(x => x.StudentId == student.Id)
                    .Select(x => x.Uloga.Naziv)
                    .FirstOrDefault();
               
                red["indeks"] = student.Indeks.ToString();
                red["ime"] = student.Ime + " " + student.Prezime;
                red["datum"] = student.DatumRodjenja;
                red["ocjena"] = ocjene.Count == 0 ? "5" : ocjene.Average(x => x.Ocjena).ToString();
                red["uloga"] = nazivUloge ?? "N/A";
                red["aktivan"] = student.Aktivan;

                dt.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = dt;
        }
        private void ucitajStudente()
        {
            var semestar = cmbSemestar.SelectedIndex + 1;
            var uloga_ID_FORMA_CMB = cmbUloga.SelectedIndex + 1; // uloga_ID
            var datumOD = dtpDatumOD.Value;
            var datumDO = dtpDatumDO.Value;


            studentPodaci = db.Studenti
                .Where(x => x.SemestarId == semestar && 
                       x.DatumRodjenja >= datumOD &&
                       x.DatumRodjenja <= datumDO&&
                      (uloga_ID_FORMA_CMB == 0 || db.StudentiUloge.Any(su => su.StudentId == x.Id && su.UlogaId == uloga_ID_FORMA_CMB)))
                .ToList();

            ucitajPodatke(studentPodaci);
        }


        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPodaci.Columns[e.ColumnIndex].Name == "btnPoruke")
            {
                var kliknutiStudent = studentPodaci[e.RowIndex];
                var novaForma = new frmPorukeIB230180(kliknutiStudent);
                novaForma.ShowDialog();
            }
        }
    }
}
