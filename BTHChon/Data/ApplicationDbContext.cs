using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTHChon.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BTHChon.Models.Student> Student { get; set; } = default!;

        public DbSet<BTHChon.Models.Faculty> Faculty { get; set; } = default!;
    }
