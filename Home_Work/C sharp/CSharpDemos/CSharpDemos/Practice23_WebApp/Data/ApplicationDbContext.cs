using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using Demo23_WebApp.Models;

namespace Demo23_WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Demo23_WebApp.Models.Subject> Subject { get; set; }
    }
}
