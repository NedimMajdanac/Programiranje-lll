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
    public partial class UvjerenjaIB230180 : Form
    {
        private Student kliknutiStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenjaIB230180> podaciUvjerenja = new List<StudentiUvjerenjaIB230180>();


        public UvjerenjaIB230180(Student kliknutiStudent)
        {
            InitializeComponent();
            this.kliknutiStudent = kliknutiStudent;
            dgvPodaci.AutoGenerateColumns = false;
            UcitajPodatke();
            UcitajCMB();
        }

        private void UcitajCMB()
        {
            cmbVrsta.DataSource = db.StudentiUvjerenjaIB230180.Select(x=>x.Vrsta).Distinct().ToList();  
        }

        private void UcitajPodatke()
        {
            podaciUvjerenja = db.StudentiUvjerenjaIB230180.Where(x => x.StudentId == kliknutiStudent.Id).ToList();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Datum");
            dataTable.Columns.Add("Vrsta");
            dataTable.Columns.Add("Svrha");
            dataTable.Columns.Add("Uplatnica", typeof(Image));
            dataTable.Columns.Add("Printano", typeof(bool));

            for (int i = 0; i < podaciUvjerenja.Count; i++)
            {
                var red = dataTable.NewRow();
                var uvjerenja = podaciUvjerenja[i];

                red["Datum"] = uvjerenja.Vrijeme;
                red["Vrsta"] = uvjerenja.Vrsta;
                red["Svrha"] = uvjerenja.Svrha;
                red["Uplatnica"] = Ekstenzije.ToImage(uvjerenja.Uplatnica);
                red["Printano"] = uvjerenja.Printano;

                dataTable.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = dataTable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPodaci.Columns[e.ColumnIndex].Name == "btnBrisi")
            {
                DialogResult odabir = MessageBox.Show("Zelite li obrisati uvjerenje?", "Upo zorenje!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (odabir == DialogResult.Yes)
                {
                    var kliknutoUvjerenje = podaciUvjerenja[e.RowIndex];
                    db.StudentiUvjerenjaIB230180.Remove(kliknutoUvjerenje);
                    db.SaveChanges();
                    UcitajPodatke();
                }
                else if (odabir == DialogResult.No)
                {

                }
            }
            else if (dgvPodaci.Columns[e.ColumnIndex].Name == "btnPrintaj")
            {

            }
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNovoUvjerenjeIB230180(kliknutiStudent);
            novaForma.ShowDialog();
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (Validno())
            {
                var vrsta = cmbVrsta.Text;
                var svrha = tbSvrha.Text;
                var brojZahtjeva = int.Parse(tbBrojZahtjeva.Text);
                Thread tred = new Thread(() => generisiTred(vrsta, svrha, brojZahtjeva));
                tred.Start();
                UcitajPodatke();
            }
        }



        private void generisiTred(string vrsta, string svrha, int brojZahtjeva)
        {
            string generatedInfo = "";
            for (int i = 0; i < brojZahtjeva; i++)
            {
                var novoUvjerenje = new StudentiUvjerenjaIB230180()
                {
                    StudentId = kliknutiStudent.Id,
                    Vrijeme = DateTime.Now.ToString(),
                    Vrsta = vrsta,
                    Svrha = tbSvrha.Text,
                    Uplatnica = podaciUvjerenja[0].Uplatnica,
                    Printano = true,
                };
                db.StudentiUvjerenjaIB230180.Add(novoUvjerenje);
                db.SaveChanges();
                generatedInfo += $"{DateTime.Now.ToString("HH:mm:ss")} -> {vrsta} studentu {kliknutiStudent.ToString()} u svrhu {svrha} {Environment.NewLine}";
            }
            Action action = () =>
            {
                tbInfo.Text = generatedInfo;
                UcitajPodatke();
            };
            BeginInvoke(action);
        }

        private bool Validno()
        {
            return Helpers.Validator.ProvjeriUnos(cmbVrsta, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbBrojZahtjeva, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbSvrha, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
