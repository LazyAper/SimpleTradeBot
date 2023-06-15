using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTradeBotBacktester.Data
{
    class DataBaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Pair> Pairs { get; set; }
        public DbSet<Setting> Settings { get; set; }

        public DataBaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=SimpleTradeBotBacktester.db");
        }

    }
}
