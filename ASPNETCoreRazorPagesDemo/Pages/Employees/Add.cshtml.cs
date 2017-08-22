using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASPNETCoreRazorPagesDemo.Models;

namespace ASPNETCoreRazorPagesDemo.Pages.Employees
{
    public class AddModel : PageModel
    {

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Employee Employee { get; set; }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            Message = Employee.FirstName + " " + Employee.LastName + ", ID " + Employee.ID.ToString() + " would have been added.";

            return RedirectToPage("Index");
        }
    }
}