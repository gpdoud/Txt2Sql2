using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Txt2Sql2 {
    
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<GerberPasDaily> GERBER_PAS_DAILY { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            var connStr = ConfigurationManager.Configuration.GetConnectionString("Db");
            options.UseSqlServer(connStr);
        }

        public AppDbContext() {

        }
    }
}
