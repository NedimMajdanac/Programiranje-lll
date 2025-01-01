using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230180
{
    public class PrisustvoIB230180
    {
        public int Id { get; set; }
        public int NastavaId { get; set; }
        public NastavaIB230180 Nastava { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
    }
}
