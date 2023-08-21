using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFDotNetCorePractice.Models;

namespace EFDotNetCorePractice.Data
{
    public class EFDotNetCorePracticeContext : DbContext
    {
        public EFDotNetCorePracticeContext (DbContextOptions<EFDotNetCorePracticeContext> options)
            : base(options)
        {
        }

        public DbSet<EFDotNetCorePractice.Models.Category> Category { get; set; } = default!;

        public DbSet<EFDotNetCorePractice.Models.Product>? Product { get; set; }
    }
}
