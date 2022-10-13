using HRMSproject.Business.Interfaces;
using HRMSproject.Models;
using HRMSproject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSproject.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository _empRepository;
        public EmployeeBusiness(IEmployeeRepository empRepository)
        {
            _empRepository = empRepository;
        }

        public List<EmployeeVM> GetAllEmployees()
        {
            var employees = _empRepository.GetAllEmployees();
            List<EmployeeVM> emps = new List<EmployeeVM>();
            foreach (var emp in employees)
             {
                EmployeeVM e = new EmployeeVM()
                {
                        DeptId = emp.DeptId,
                        EmpId = emp.EmpId,
                        EmpName = emp.EmpName,
                        EmpSalary = emp.EmpSalary
                };
                emps.Add(e);
             }
            return emps;
        } 
    }
}
