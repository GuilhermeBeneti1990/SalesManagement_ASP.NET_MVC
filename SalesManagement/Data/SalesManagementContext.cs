using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesManagement.Models;

namespace SalesManagement.Data
{
    public class SalesManagementContext : DbContext
    {
        public SalesManagementContext (DbContextOptions<SalesManagementContext> options)
            : base(options)
        {
        }

        public DbSet<SalesManagement.Models.Department> Department { get; set; }
    }
}
