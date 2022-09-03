using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDApiDemo.Models;

namespace CRUDApiDemo.Data
{
    public class CRUDApiDemoContext : DbContext
    {
        public CRUDApiDemoContext (DbContextOptions<CRUDApiDemoContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDApiDemo.Models.Employee> Employee { get; set; } = default!;
    }
}
