using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASPNETCoreRazorPagesDemo.Models;
using ASPNETCoreRazorPagesDemo.Repositories;

namespace ASPNETCoreRazorPagesDemo.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private IEmployeeRepository _employeeRepo;
        public List<Employee> Employees { get; set; }

        [TempData]
        public string Message { get; set; }

        public IndexModel(IEmployeeRepository userRepo)
        {
            _employeeRepo = userRepo;
        }
        public void OnGet()
        {
            Employees = _employeeRepo.GetAll();
        }
    }
}