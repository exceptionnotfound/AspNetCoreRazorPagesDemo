using ASPNETCoreRazorPagesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreRazorPagesDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(GetByID(1));
            employees.Add(GetByID(2));
            employees.Add(GetByID(3));
            return employees;
        }

        public Employee GetByID(int id)
        {
            if(id == 1)
            {
                return new Employee()
                {
                    FirstName = "Spencer",
                    LastName = "Strasmore",
                    DateOfBirth = new DateTime(1978, 11, 16),
                    ID = 1
                };
            }
            if(id == 2)
            {
                return new Employee()
                {
                    FirstName = "Ricky",
                    LastName = "Jerret",
                    DateOfBirth = new DateTime(1989, 3, 30),
                    ID = 2
                };
            }
            if(id == 3)
            {
                return new Employee()
                {
                    FirstName = "Vernon",
                    LastName = "Littlefield",
                    DateOfBirth = new DateTime(1992, 7, 3),
                    ID = 3
                };
            }

            return null;
        }
    }
}
