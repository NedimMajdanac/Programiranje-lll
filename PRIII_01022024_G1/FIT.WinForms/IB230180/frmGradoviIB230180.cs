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
    public partial class frmGradoviIB230180 : Form
    {
        private DrzaveIB230180 kliknutaDrzava;
        List<GradoviIB230180> podaciGrad = new List<GradoviIB230180>();
        DLWMSDbContext db = new DLWMSDbContext();

        public frmGradoviIB230180(DrzaveIB230180 kliknutaDrzava)
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
            this.kliknutaDrzava = kliknutaDrzava;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {

        }

        private void frmGradoviIB230180_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            lblNaziv.Text = kliknutaDrzava.Naziv.ToString();
            pbZastava.Image = Ekstenzije.ToImage(kliknutaDrzava.Zastava);

            podaciGrad = db.GradoviIB230180.Where(x => x.DrzavaId == kliknutaDrzava.Id).ToList();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Naziv");
            dataTable.Columns.Add("Aktivan");

            for (int i = 0; i < podaciGrad.Count; i++)
            {
                var red = dataTable.NewRow();
                var grad = podaciGrad[i];

                red["Naziv"] = grad.Naziv.ToString();
                red["Aktivan"] = grad.Status;

                dataTable.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = dataTable;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                bool pohranjenGrad = podaciGrad.Any(x => x.Naziv == tbNaziv.Text);
                if (pohranjenGrad)
                {
                    MessageBox.Show("Grad vec postoji", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                var noviGrad = new GradoviIB230180()
                {
                    Naziv = tbNaziv.Text,
                    Status = true,
                    DrzavaId = kliknutaDrzava.Id,
                };
                db.GradoviIB230180.Add(noviGrad);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private bool isValid()
        {
            return Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPodaci.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var grad = podaciGrad[e.RowIndex];
                grad.Status = grad.Status == true ? false : true;
                db.GradoviIB230180.Update(podaciGrad[e.RowIndex]);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private void btnGenerisi_Click_1(object sender, EventArgs e)
        {
            var aktivan = cbStatus.Checked;
            var brojZahtjeva = tbBrGradova.Text == "" ? 0 : int.Parse(tbBrGradova.Text);
            Thread t = new Thread(() => GenerisiGradove(aktivan, brojZahtjeva));
            t.Start();
            UcitajPodatke();
        }

        private void GenerisiGradove(bool aktivan, int brojZahtjeva)
        {
            string generatedInfo = "";
            
            if (brojZahtjeva != 0)
            {
                for (int i = 1; i <= brojZahtjeva; i++)
                {
                    var noviGrad = new GradoviIB230180()
                    {
                        Naziv = "Grad " + i,
                        Status = aktivan ? true : false,
                        DrzavaId = kliknutaDrzava.Id,
                    };
                    db.GradoviIB230180.Add(noviGrad);
                    db.SaveChanges();
                    generatedInfo += $"{DateTime.Now} -> dodat grad Grad {i} za {kliknutaDrzava.Naziv} {Environment.NewLine}";
                }

                Action action = () =>
                {
                    tbInfo.Text = generatedInfo;
                    UcitajPodatke();
                };
                BeginInvoke(action);
            }
            else
            {
                MessageBox.Show("Unesite validan broj gradova!");
            }
        }
    }
}
