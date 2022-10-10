using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhuongQuocChienBTH02.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<PhuongQuocChienBTH02.Models.Student> Student { get; set; } = default!;

        public DbSet<PhuongQuocChienBTH02.Models.Person>? Person { get; set; }

        public DbSet<PhuongQuocChienBTH02.Models.Employee>? Employee { get; set; }

        public DbSet<PhuongQuocChienBTH02.Models.Customer>? Customer { get; set; }
    }
