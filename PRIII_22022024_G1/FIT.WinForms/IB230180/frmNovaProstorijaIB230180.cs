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
    public partial class frmNovaProstorijaIB230180 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijeIB230180 _prostorija;
        public frmNovaProstorijaIB230180(ProstorijeIB230180 prostorija = null)
        {
            InitializeComponent();
            _prostorija = prostorija ?? new ProstorijeIB230180();
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private bool Validacija()
        {
            return Helpers.Validator.ProvjeriUnos(pbLogo, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbOznaka, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbKapacitet, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void frmNovaProstorijaIB230180_Load(object sender, EventArgs e)
        {
            if (_prostorija.Id != 0)
            {
                pbLogo.Image = Ekstenzije.ToImage(_prostorija.Logo);
                tbNaziv.Text = _prostorija.Naziv.ToString();
                tbOznaka.Text = _prostorija.Oznaka.ToString();
                tbKapacitet.Text = _prostorija.Kapacitet.ToString();
            }

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                _prostorija.Naziv = tbNaziv.Text;
                _prostorija.Oznaka = tbOznaka.Text;
                _prostorija.Kapacitet = tbKapacitet.Text;
                _prostorija.Logo = Ekstenzije.ToByteArray(pbLogo.Image);

                if(_prostorija.Id == 0)
                {
                    _prostorija.Id = db.ProstorijeIB230180.Count() + 1;
                    db.ProstorijeIB230180.Add(_prostorija);
                    db.SaveChanges();
                    Close();

                }
            }
        }
    }
}
