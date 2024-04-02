using BusinessLayer.Interfaces;
using CommonLayer.Models;
using RespositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class EmployeeBusiness:IEmployeeBusiness
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeBusiness(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public bool AddEmployee(Employee employee)
        {
            return employeeRepository.AddEmployee(employee);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }

        public bool UpdateEmployee(Employee employee)
        {
            return employeeRepository.UpdateEmployee(employee);
        }

        public bool DeleteEmployee(int id)
        {
            return employeeRepository.DeleteEmployee(id);
        }

        public Employee GetEmployeeById(int id)
        {
            return employeeRepository.GetEmployeeById(id);
        }

        public Employee Login(LoginModel model)
        {
            return employeeRepository.Login(model);
        }

        public IEnumerable<Employee> GetByName(string name)
        {
            return employeeRepository.GetByName(name);
        }

        public bool Empnotexist(Employee employee)
        {
            return employeeRepository.Empnotexist(employee);
        }

    }
}
