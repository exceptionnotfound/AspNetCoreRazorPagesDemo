using ASPNETCoreRazorPagesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreRazorPagesDemo.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetByID(int id);
        List<Employee> GetAll();
    }
}
