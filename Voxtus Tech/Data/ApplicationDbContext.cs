using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Voxtus_Tech.Models;

namespace Voxtus_Tech.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ContactUs> ContactUs { get; set; }

        public DbSet<ContactUs> ContactUsTable { get; set; }

        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<LoginModel> LoginModel { get; set; }
    }
}
