using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230180
{
    public class PolozeniPredmetiIB230180
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB230180 Predmet { get; set; }
        public int Ocjena { get; set; }
        public string DatumPolaganja { get; set; }
        public string Napomena { get; set; }
    }
}
