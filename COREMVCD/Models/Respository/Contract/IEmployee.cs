using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COREMVCD.Models.Respository.Contract
{
    public interface IEmployee
    {
        Employee CreateEmployee(Employee employee);
        List<Employee> GetEmployees();
        int CountEmployee();
    }
}
