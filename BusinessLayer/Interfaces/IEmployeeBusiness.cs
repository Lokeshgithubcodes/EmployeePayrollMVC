using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IEmployeeBusiness
    {

        public bool AddEmployee(Employee employee);
        public IEnumerable<Employee> GetAllEmployees();

        public bool UpdateEmployee(Employee employee);

        public bool DeleteEmployee(int id);

        public Employee GetEmployeeById(int id);

        public Employee Login(LoginModel model);


    }
}
