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
    public partial class frmNastavaIB230180 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<NastavaIB230180> nastavaPodaci = new List<NastavaIB230180>();
        private ProstorijeIB230180 kliknutaProstorija;
        
        public frmNastavaIB230180(ProstorijeIB230180 kliknutaProstorija)
        {
            InitializeComponent();
            this.kliknutaProstorija = kliknutaProstorija;
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmNastavaIB230180_Load(object sender, EventArgs e)
        {
            UcitajCMB();
            UcitajNastavu();
            UcitajLabel();
        }

        private void UcitajLabel()
        {
            var zapis = db.ProstorijeIB230180.FirstOrDefault(x => x.Id == kliknutaProstorija.Id);

            lblNaziv.Text = zapis.Naziv.ToString();
            lblOznaka.Text = zapis.Oznaka.ToString();
        }

        private void UcitajNastavu()
        {
            nastavaPodaci = db.NastavaIB230180.Where(x => x.ProstorijaId == kliknutaProstorija.Id).ToList();

            DataTable tabela = new DataTable();

            tabela.Columns.Add("Predmet");
            tabela.Columns.Add("Dan");
            tabela.Columns.Add("Vrijeme");

            for (int i = 0; i < nastavaPodaci.Count; i++)
            {
                var red = tabela.NewRow();
                var nastava = nastavaPodaci[i];
                var predmet = db.Predmeti.FirstOrDefault(x => x.Id == nastava.PredmetId);

                red["Predmet"] = predmet.Naziv;
                red["Dan"] = nastava.Dan;
                red["Vrijeme"] = nastava.VrijemeNastave;

                tabela.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = tabela;
        }

        private void UcitajCMB()
        {
            cmbPredmeti.DataSource = db.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";


            cmbDan.DataSource = db.NastavaIB230180
                .Select(x => x.Dan)
                .Distinct()
                .ToList();

            cmbVrijeme.DataSource = db.NastavaIB230180
                .Select(x => x.VrijemeNastave)
                .Distinct()
                .ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var predmet = db.Predmeti.FirstOrDefault(x => x.Id == cmbPredmeti.SelectedIndex + 1).Naziv;
            var nastava = new NastavaIB230180()
            {
                ProstorijaId = kliknutaProstorija.Id,
                PredmetId = (int)cmbPredmeti.SelectedValue,
                VrijemeNastave = cmbVrijeme.SelectedItem.ToString(),
                Dan = cmbDan.SelectedItem.ToString(),
                Oznaka = $"{predmet} :: {cmbDan.SelectedItem} :: {cmbVrijeme.SelectedItem}"
            };
            db.NastavaIB230180.Add(nastava);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
            UcitajNastavu();
        }
    }
}
