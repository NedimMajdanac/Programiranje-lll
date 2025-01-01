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
    public partial class frmNovaDrzavaIB230180 : Form
    {
        private DrzaveIB230180 kliknutaDrzava;
        DLWMSDbContext db = new DLWMSDbContext();
        List<GradoviIB230180> podaciGrad = new List<GradoviIB230180>();

        public frmNovaDrzavaIB230180(DrzaveIB230180 kliknutaDrzava)
        {
            InitializeComponent();
            this.kliknutaDrzava = kliknutaDrzava;
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var novo = new DrzaveIB230180()
                {
                    Naziv = tbNaziv.Text,
                    Status = cbAktivna.Checked,
                    Zastava = Ekstenzije.ToByteArray(pbSlika.Image),
                };
                db.DrzaveIB230180.Add(novo);
                db.SaveChanges();
                Close();
            }
        }

        private bool isValid()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(cbAktivna, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void frmNovaDrzavaIB230180_Load(object sender, EventArgs e)
        {
            if (kliknutaDrzava != null)
            {
                tbNaziv.Text = kliknutaDrzava.Naziv.ToString();
                pbSlika.Image = Ekstenzije.ToImage(kliknutaDrzava.Zastava);
                cbAktivna.Checked = kliknutaDrzava.Status;
            }
        }
    }
}
