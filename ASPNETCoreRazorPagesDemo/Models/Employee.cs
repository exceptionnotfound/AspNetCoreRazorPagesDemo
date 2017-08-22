using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreRazorPagesDemo.Models
{
    public class Employee
    {
        [DisplayName("First Name:")]
        [Required(ErrorMessage = "Please enter the employee's first name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name:")]
        [Required(ErrorMessage = "Please enter the employee's last name")]
        public string LastName { get; set; }

        [DisplayName("Date of Birth:")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("ID:")]
        [Required(ErrorMessage = "Please enter the employee's ID")]
        public int ID { get; set; }
    }
}
