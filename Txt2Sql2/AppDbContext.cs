using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Txt2Sql2 {
    
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<GerberPasDaily> gpds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer("server=localhost\\sqlexpress;database=Text2Sql;trusted_connection=true;");
        }

        public AppDbContext() {

        }
    }
}
