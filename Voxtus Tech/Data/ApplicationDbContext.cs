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
    }
}
