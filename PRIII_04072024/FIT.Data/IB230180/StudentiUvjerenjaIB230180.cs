using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230180
{
    public class StudentiUvjerenjaIB230180
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }
        public string Vrijeme { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }
    }
}
