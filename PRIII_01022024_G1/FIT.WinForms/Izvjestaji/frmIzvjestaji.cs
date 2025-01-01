using FIT.Data.IB230180;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private DrzaveIB230180 kliknutaDrzava;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(DrzaveIB230180 kliknutaDrzava)
        {
            this.kliknutaDrzava = kliknutaDrzava;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            reportViewer1.RefreshReport();
        }
    }
}
