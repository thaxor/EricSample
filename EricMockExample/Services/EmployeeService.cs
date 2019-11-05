using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EricMockExample.Data;

namespace EricMockExample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly SampleContext _context;

        public EmployeeService()
        {
            _context = new SampleContext();
        }
        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
