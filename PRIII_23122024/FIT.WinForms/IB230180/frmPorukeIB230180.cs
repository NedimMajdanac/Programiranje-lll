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
    public partial class frmPorukeIB230180 : Form
    {
        private Student kliknutiStudent;
        DLWMSDbContext dbContext = new DLWMSDbContext();
        List<StudentiPorukeIB230180> studentPorukaPodaci = new List<StudentiPorukeIB230180>();
        public frmPorukeIB230180(Student kliknutiStudent)
        {
            InitializeComponent();
            this.kliknutiStudent = kliknutiStudent;
            dgvPodaci.AutoGenerateColumns = false;
            UcitajTekst();
            UcitajDGV();
            cmbPredmeti.DataSource = dbContext.Predmeti.Select(x=>x.Naziv).Distinct().ToList();
            cmbValidnost.DataSource = new List<string> { DateTime.Now.ToString("D") };
        }

        private void UcitajDGV()
        {
            studentPorukaPodaci = dbContext.StudentiPorukeIB230180
                    .Where(x => x.StudentId == kliknutiStudent.Id)
                    .ToList();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Predmet");
            dataTable.Columns.Add("Sadrzaj");
            dataTable.Columns.Add("Slika", typeof(Image));
            dataTable.Columns.Add("Hitnost");
            dataTable.Columns.Add("Validnost");

            for (int i = 0; i < studentPorukaPodaci.Count; i++)
            {
                var podatakPoruke = studentPorukaPodaci[i];
                var red = dataTable.NewRow();
                var predmetNaziv = dbContext.Predmeti.FirstOrDefault(x => x.Id == podatakPoruke.PredmetId)?.Naziv ;

                red["Predmet"] = predmetNaziv;
                red["Sadrzaj"] = podatakPoruke.Sadrzaj;
                red["Slika"] = Ekstenzije.ToImage(podatakPoruke.Slika);
                red["Hitnost"] = podatakPoruke.Hitnost;
                red["Validnost"] = podatakPoruke.Validnost;

                dataTable.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = dataTable;
        }

        private void UcitajTekst()
        {
            lblPoruka.Text = $"Poruke studenta {kliknutiStudent.Ime} {kliknutiStudent.Prezime}";
            var brojPoruka = dbContext.StudentiPorukeIB230180.Where(x => x.StudentId == kliknutiStudent.Id).Count();
            this.Text = $"Broj poruka -> {brojPoruka}";
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPodaci.Columns[e.ColumnIndex].Name == "btnBrisi")
            {
                DialogResult odabir = MessageBox.Show("Da li zelite izbrisati?", "Upozorennje", MessageBoxButtons.YesNoCancel);
                if (odabir == DialogResult.Yes)
                {
                    var kliknutaPoruka = studentPorukaPodaci[e.RowIndex];
                    dbContext.StudentiPorukeIB230180.Remove(kliknutaPoruka);
                    dbContext.SaveChanges();
                    UcitajDGV();
                }
            }
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNovaPorukaIB230180(kliknutiStudent);
            novaForma.ShowDialog();
            UcitajDGV();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem.ToString();
            var brojZahtjeva = int.Parse(tbBrPoruka.Text);
            var validnost = cmbValidnost.SelectedItem.ToString();

            Thread tred = new Thread(() => generisiTred(predmet, brojZahtjeva, validnost));
            tred.Start();
            UcitajDGV();
        }

        private void generisiTred(string predmet, int brojZahtjeva, string validnost)
        {
            string info = "";
            using (var dbContextThread = new DLWMSDbContext())
            {
                for (int i = 1; i <= brojZahtjeva; i++)
                {
                    var predmetObj = dbContextThread.Predmeti.FirstOrDefault(x => x.Naziv == predmet);

                    var novaPoruka = new StudentiPorukeIB230180()
                    {
                        PredmetId = predmetObj.Id,
                        StudentId = kliknutiStudent.Id,
                        Predmet = predmetObj,
                        Validnost = validnost,
                        Sadrzaj = $"{i} generisana poruka",
                        Slika = studentPorukaPodaci[0].Slika,
                        Hitnost = "Srednja",
                    };

                    dbContextThread.StudentiPorukeIB230180.Add(novaPoruka);
                    dbContextThread.SaveChanges();

                    info += $"{validnost} -> {novaPoruka.Sadrzaj} za {kliknutiStudent.ToString()} na predmetu {predmet} {Environment.NewLine}";
                }
            }
            
            Thread.Sleep(300);

            Action action = () =>
            {
                tbInfo.Text = info;
                UcitajDGV();
            };

            BeginInvoke(action);
        }
    }
}
