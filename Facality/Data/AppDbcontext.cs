using Facality.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Facality.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        { 
        }
        public DbSet<Student> students { get; set; }
        public DbSet<faccality> faccalities { get; set; }

    }
    
}
