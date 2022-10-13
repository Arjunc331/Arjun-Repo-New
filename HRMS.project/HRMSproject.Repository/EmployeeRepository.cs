using HRMSproject.Repository.Interfaces;
using HRMSproject.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSproject.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SnadDBContext myContext;

        public EmployeeRepository(SnadDBContext context)
        {
            myContext = context;
        }

        public List<Employee> GetAllEmployees()
        {
            return myContext.Employees.ToList();
        }
    }
}
