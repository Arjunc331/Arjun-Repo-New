using HRMSproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSproject.Business.Interfaces
{
    public interface IEmployeeBusiness
    {
        List<EmployeeVM> GetAllEmployees();
    }
}
