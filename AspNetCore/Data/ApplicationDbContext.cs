using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AspNetCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHero> superHeroes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        internal void SaveChanges(IQueryable<SuperHero> superheroInDb)
        {
            throw new NotImplementedException();
        }
    }
}
