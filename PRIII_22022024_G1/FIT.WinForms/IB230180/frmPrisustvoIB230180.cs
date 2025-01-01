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
    public partial class frmPrisustvoIB230180 : Form
    {
        private ProstorijeIB230180 kliknutaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();
        List<PrisustvoIB230180> podaciPrisustvo = new List<PrisustvoIB230180>();
        public frmPrisustvoIB230180(ProstorijeIB230180 kliknutaProstorija)
        {
            InitializeComponent();
            this.kliknutaProstorija = kliknutaProstorija;
            dgvPodaci.AutoGenerateColumns = false;
            UcitajLabel();
            UcitajCMB();
            UcitajPodatke();
        }

        private void frmPrisustvoIB230180_Load(object sender, EventArgs e)
        {
            //UcitajLabel();
            //UcitajCMB();
            //UcitajPodatke();
        }

        private void UcitajCMB()
        {
            cmbNastava.DataSource = db.NastavaIB230180
                .Where(x => x.ProstorijaId == kliknutaProstorija.Id)
                .ToList();
            cmbNastava.DisplayMember = "Oznaka";
            cmbNastava.ValueMember = "Id";

            cmbStudenti.DataSource = db.Studenti.ToList();
            cmbStudenti.DisplayMember = "ImePrezimeIndeks";
            cmbStudenti.ValueMember = "Id";
        }

        private void UcitajLabel()
        {
            var zapis = db.ProstorijeIB230180.FirstOrDefault(x => x.Id == kliknutaProstorija.Id);
            lblNaziv.Text = zapis.Naziv;
            lblOznaka.Text = zapis.Oznaka;
            //throw new NotImplementedException();
        }

        private void UcitajPodatke()
        {

            var nastava = cmbNastava.SelectedValue is int ? (int)cmbNastava.SelectedValue : -1;
            var student = cmbStudenti.SelectedValue is int ? (int)cmbStudenti.SelectedValue : -1;

            podaciPrisustvo = db.PrisustvoIB230180
                .Where(x => x.NastavaId == nastava && x.StudentId == student)
                .ToList();

            DataTable tabela = new DataTable();

            tabela.Columns.Add("PredmetProstorijaVrijeme");
            tabela.Columns.Add("Student");

            for (int i = 0; i < podaciPrisustvo.Count; i++)
            {

                var red = tabela.NewRow();

                red["PredmetProstorijaVrijeme"] = db.NastavaIB230180
                    .FirstOrDefault(x => x.Id == podaciPrisustvo[i].NastavaId).Oznaka;

                red["Student"] = db.Studenti
                    .FirstOrDefault(x => x.Id == podaciPrisustvo[i].StudentId).ToString();

                tabela.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = tabela;
        }

        private void cmbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            // UcitajPodatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var novoPrisustvo = new PrisustvoIB230180()
            {
                NastavaId = (int)cmbNastava.SelectedValue,
                StudentId = (int)cmbStudenti.SelectedValue
            };
            db.PrisustvoIB230180.Add(novoPrisustvo);
            db.SaveChanges();
            UcitajPodatke();
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var broj = int.Parse(tbBrZapisa.Text);
                Thread t1 = new Thread(() => generisi(broj));
                t1.Start();
            }
        }

        private void generisi(int broj)
        {
            string tekst = "";

            var nastavaId = 0;
            var nastavaTekst = "";
            var studentId = 0;
            var studentTekst = "";

            cmbNastava.Invoke(new Action(() =>
            {
                nastavaId = (int)cmbNastava.SelectedValue;
                nastavaTekst = cmbNastava.SelectedItem.ToString();
            }));

            cmbStudenti.Invoke(new Action(() =>
            {
                studentId = (int)cmbStudenti.SelectedValue;
                studentTekst = cmbStudenti.SelectedItem.ToString();
            }));

            for (int i = 0; i < broj; i++)
            {
                var prisustvo = new PrisustvoIB230180()
                {
                    NastavaId = nastavaId,
                    StudentId = studentId,
                };
                db.PrisustvoIB230180.Add(prisustvo);
                db.SaveChanges();

                tekst += $"{DateTime.Now:dd.MM HH:mm:ss} -> {studentTekst} za {nastavaTekst}{Environment.NewLine}";
            }

            Action action = () =>
            {
                tbGenerator.Text = tekst;
                UcitajPodatke();
            };

            BeginInvoke(action);
        }

        private bool isValid()
        {
            return Helpers.Validator.ProvjeriUnos(tbBrZapisa, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
