﻿using FIT.Data;
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
        public DbSet<SemestriIB230180> Semestri { get; set; }
        public DbSet<PredmetiIB230180> Predmeti { get; set; }
        public DbSet<PolozeniPredmetiIB230180> PolozeniPredmeti { get; set; }
        public DbSet<DrzaveIB230180> DrzaveIB230180 { get; set; }
        public DbSet<GradoviIB230180> GradoviIB230180 { get; set; }

    }
}