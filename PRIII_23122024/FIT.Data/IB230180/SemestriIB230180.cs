using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230180
{
    public class SemestriIB230180
    {
        public int Id { get; set; }
        public bool Aktivan { get; set; }
        public string Opis { get; set; }
        public string Oznaka { get; set; }
        public override string ToString()
        {
            return Oznaka;
        }

    }
}
