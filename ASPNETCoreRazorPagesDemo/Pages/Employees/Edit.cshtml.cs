using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASPNETCoreRazorPagesDemo.Repositories;
using ASPNETCoreRazorPagesDemo.Models;

namespace ASPNETCoreRazorPagesDemo.Pages.Employees
{
    public class EditModel : PageModel
    {
        private IEmployeeRepository _employeeRepo;

        public EditModel(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Employee Employee { get; set; }

        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepo.GetByID(id);

            if(Employee == null)
            {
                return RedirectToPage("Index");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            Message = Employee.FirstName + " " + Employee.LastName + ", ID " + Employee.ID.ToString() + " would have been saved.";

            return RedirectToPage("Index");
        }
    }
}