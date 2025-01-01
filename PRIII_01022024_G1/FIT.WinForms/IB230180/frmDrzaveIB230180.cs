using FIT.Data.IB230180;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using FIT.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace FIT.WinForms.IB230180
{
    public partial class frmDrzaveIB230180 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<DrzaveIB230180> drzavePodaci = new List<DrzaveIB230180>();
        Timer timer;
        public frmDrzaveIB230180()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
            UcitajPodatke();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => lblVrijeme.Text = $"Trenutno Vrijeme: {DateTime.Now.ToString("HH:mm:ss")}";
            timer.Start();
        }

        private void frmDrzaveIB230180_Load(object sender, EventArgs e)
        {

        }

        private void UcitajPodatke()
        {
            drzavePodaci = db.DrzaveIB230180.ToList();

            if (drzavePodaci != null)
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Zastava", typeof(Image));
                dt.Columns.Add("Drzava");
                dt.Columns.Add("BrojGradova");
                dt.Columns.Add("Aktivna", typeof(bool));

                for (int i = 0; i < drzavePodaci.Count; i++)
                {
                    var drzava = drzavePodaci[i];
                    var red = dt.NewRow();

                    red["Zastava"] = Ekstenzije.ToImage(drzava.Zastava);
                    red["Drzava"] = drzava.Naziv.ToString();
                    red["BrojGradova"] = db.GradoviIB230180.Count(x => x.DrzavaId == drzava.Id).ToString();
                    red["Aktivna"] = drzava.Status;

                    dt.Rows.Add(red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = dt;
            }
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNovaDrzavaIB230180(null);
            novaForma.ShowDialog();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var kliknutaDrzava = drzavePodaci[e.RowIndex];

                var novaForma = new frmGradoviIB230180(kliknutaDrzava);
                novaForma.ShowDialog();
            }
            else
            {
                var kliknutaDrzava = drzavePodaci[e.RowIndex];

                var novaForma = new frmNovaDrzavaIB230180(kliknutaDrzava);
                novaForma.ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            //if(dgvPodaci.SelectedRows.Count > 0)
            //{
            //    var red = dgvPodaci.SelectedRows[0];
            //    var drzava = red.Cells["Drzava"].Value.ToString();
            //    var kliknutaDrzava = drzavePodaci.FirstOrDefault(x => x.Naziv == drzava);

            //    if (kliknutaDrzava != null)
            //    {
            //        var podaciGradovi = db.GradoviIB230180.Where(x => x.DrzavaId == kliknutaDrzava.Id).ToList();
            //        var report = new frmIzvjestaji(kliknutaDrzava);
            //        report.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Izabrana drzava podaci nisu validni");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Izaberite drzavu!");
            //}
        }
    }
}
