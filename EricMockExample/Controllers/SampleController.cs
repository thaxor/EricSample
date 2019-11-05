using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EricMockExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace EricMockExample.Controllers
{
    public class SampleController : Controller
    {
        private readonly IEmployeeService employeeService;
        public SampleController(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

        public IActionResult Index()
        {
            var employees = employeeService.GetEmployees();

            return View();
        }

    }
}