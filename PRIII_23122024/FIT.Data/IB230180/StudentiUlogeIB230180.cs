using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230180
{
    public class StudentiUlogeIB230180
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int UlogaId { get; set; }
        public UlogeIB230180 Uloga { get; set; }
    }
}
