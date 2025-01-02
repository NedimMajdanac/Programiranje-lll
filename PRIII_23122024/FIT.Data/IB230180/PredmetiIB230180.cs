using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230180
{
    public class PredmetiIB230180
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SemestarId { get; set; }
        public SemestriIB230180 Semestar { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
