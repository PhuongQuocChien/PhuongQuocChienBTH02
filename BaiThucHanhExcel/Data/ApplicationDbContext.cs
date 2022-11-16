using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiThucHanhExcel.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BaiThucHanhExcel.Models.Student> Student { get; set; } = default!;

        public DbSet<BaiThucHanhExcel.Models.Person>? Person { get; set; }

        public DbSet<BaiThucHanhExcel.Models.Customer>? Customer { get; set; }

        public DbSet<BaiThucHanhExcel.Models.Employee>? Employee { get; set; }

        public DbSet<BaiThucHanhExcel.Models.Faculty>? Faculty {get; set;}
    }
