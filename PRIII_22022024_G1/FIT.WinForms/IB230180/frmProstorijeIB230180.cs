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
    public partial class frmProstorijeIB230180 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<ProstorijeIB230180> prostorijaPodaci = new List<ProstorijeIB230180>();
        public frmProstorijeIB230180()
        {
            InitializeComponent();
            dgvProstorijaPodaci.AutoGenerateColumns = false;
        }

        private void frmProstorijeIB230180_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {

            prostorijaPodaci = db.ProstorijeIB230180.ToList();

            if (prostorijaPodaci != null)
            {
                var tabela = new DataTable();
                
                tabela.Columns.Add("Logo", typeof(Image));
                tabela.Columns.Add("Naziv");
                tabela.Columns.Add("Oznaka");
                tabela.Columns.Add("Kapacitet");
                tabela.Columns.Add("BrojPredmeta");

                for (int i = 0; i < prostorijaPodaci.Count; i++)
                {
                    var prostorija = prostorijaPodaci[i];
                    var red = tabela.NewRow();

                    red["Logo"] = Ekstenzije.ToImage(prostorija.Logo);
                    red["Naziv"] = prostorija.Naziv.ToString();
                    red["Oznaka"] = prostorija.Oznaka.ToString();
                    red["Kapacitet"] = prostorija.Kapacitet.ToString();
                    red["BrojPredmeta"] = db.NastavaIB230180.Where(x => x.ProstorijaId == prostorija.Id).Count();

                    tabela.Rows.Add(red);
                }
                dgvProstorijaPodaci.DataSource = null;
                dgvProstorijaPodaci.DataSource = tabela;

            }
        }

        private void btnNovaProstorija_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNovaProstorijaIB230180();
            if (novaForma.ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private void dgvProstorijaPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex < 4)
            {
                var odabranaProstorija = prostorijaPodaci[e.RowIndex];
                var frmEditovanjeProstorije = new frmNovaProstorijaIB230180(odabranaProstorija);
                frmEditovanjeProstorije.ShowDialog();
            }
            if (dgvProstorijaPodaci.Columns[e.ColumnIndex].Name == "btnNastava")
            {
                var kliknutaProstorija = prostorijaPodaci[e.RowIndex];
                var novaForma = new frmNastavaIB230180(kliknutaProstorija);
                if(DialogResult.OK == novaForma.ShowDialog())
                {
                    UcitajPodatke();
                }
            }else if (dgvProstorijaPodaci.Columns[e.ColumnIndex].Name == "btnPrisustvo")
            {
                var kliknutaProstorija = prostorijaPodaci[e.RowIndex];
                var brojNastave = db.NastavaIB230180.Count(x => x.Id == kliknutaProstorija.Id);
                
                if(brojNastave > 0)
                {
                    var novaForma = new frmPrisustvoIB230180(kliknutaProstorija);
                    if(DialogResult.OK == novaForma.ShowDialog())
                    {
                        UcitajPodatke();
                    }
                }
                else
                {
                    MessageBox.Show("U ovoj prostoriji nema nastave, dodajte novu!");
                }
            }
        }
    }
}
