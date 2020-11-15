using Microsoft.EntityFrameworkCore;
using NewBrandingStyle.Web.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Database {
    public class ExchangesDbContext : DbContext {
        public ExchangesDbContext(DbContextOptions options) : base(options) { }
        public DbSet<ItemEntity> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
