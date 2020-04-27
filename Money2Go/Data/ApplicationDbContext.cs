using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Money2Go.Models;

namespace Money2Go.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> appUserdb { get; set; }
        public DbSet<Comment> Commentdb { get; set; }
        public DbSet<Project> Projectdb { get; set; }
        public DbSet<Tranzaction> Tranzactiondb { get; set; }


    }
}
