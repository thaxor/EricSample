using EricMockExample.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricMockExample.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }
}
