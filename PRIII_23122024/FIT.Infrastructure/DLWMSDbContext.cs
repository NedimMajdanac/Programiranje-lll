using FIT.Data;
using FIT.Data.IB230180;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<UlogeIB230180> Uloge { get; set; }
        public DbSet<StudentiUlogeIB230180> StudentiUloge { get; set; }
        public DbSet<SemestriIB230180> Semestri { get; set; }
        public DbSet<PredmetiIB230180> Predmeti { get; set; }
        public DbSet<PolozeniPredmetiIB230180> PolozeniPredmeti { get; set; }
        public DbSet<StudentiPorukeIB230180> StudentiPorukeIB230180 { get; set; }

    }
}