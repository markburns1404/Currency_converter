using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class DBEntities: DbContext
    {
        public DBEntities()
            : base("name=conString")
        {
        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ConversionHistory> ConversionHistories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
