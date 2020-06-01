using SalesManagement.Data;
using SalesManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagement.Services
{
    public class DepartmentService
    {
        private readonly SalesManagementContext _context;

        public DepartmentService(SalesManagementContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
