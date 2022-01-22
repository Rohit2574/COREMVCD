using COREMVCD.Models.Respository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COREMVCD.Models.Respository.Services
{
    public class EmployeeService:IEmployee
    {
        private List<Employee> Employees;
        public EmployeeService()
        {
            Employees = new List<Employee>()
            {
              new Employee(){Id=1,Name="Rohit",Email="rohitsagar919@gmail.com",Gender="Male"},
              new Employee(){Id=2,Name="Mohit",Email="mohit420@gmail.com",Gender="Male"},
              new Employee(){Id=3,Name="Radha",Email="radha120@gmail.com",Gender="Female"},
            };
        }

        public int CountEmployee()
        {
            throw new NotImplementedException();
        }

        public int CountEmployees()
        {
           return Employees.Count;
        }

        public Employee CreateEmployee(Employee employee)
        {
            employee.Id = Employees.Count + 1;
            Employees.Add(employee);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return Employees.ToList();
        }
    }
}
