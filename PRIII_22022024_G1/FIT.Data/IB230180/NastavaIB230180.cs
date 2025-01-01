using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230180
{
    public class NastavaIB230180
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public ProstorijeIB230180 Prostorija { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB230180 Predmet { get; set; }
        public string VrijemeNastave { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }
        
    }
}
