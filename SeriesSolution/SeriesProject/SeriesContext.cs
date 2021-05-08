using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesProject
{
    class SeriesContext : DbContext
    {
        public SeriesContext()
        {

        }

        private const string ConnectionString = "server=DESKTOP-87C5QHV;Integrated security=true;;Database=Series;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Series> Series { get; set; }

        public virtual System.Collections.Generic.IReadOnlyList<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry> Entries { get; }
    }
}
