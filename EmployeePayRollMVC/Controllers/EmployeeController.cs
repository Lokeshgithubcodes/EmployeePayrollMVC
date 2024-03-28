using BusinessLayer.Interfaces;
using CommonLayer.Models;
using Microsoft.AspNetCore.Mvc;
using RespositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeePayRollMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBusiness employeeBusiness;

        public EmployeeController(IEmployeeBusiness employeeBusiness)
        {
            this.employeeBusiness = employeeBusiness;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListofEmployee()
        {
            List<Employee> employee = new List<Employee>();
            employee = employeeBusiness.GetAllEmployees().ToList();
             return View(employee);

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeBusiness.AddEmployee(employee);
                return RedirectToAction("ListofEmployee");
            }
            return View(employee);
        }

        [HttpGet]
        //[Route("Update/{id}")]
        public IActionResult Edit(int id)
        {
            //id = (int)HttpContext.Session.GetInt32("Id");

            if (id == null)
            {
                return NotFound();
            }
            Employee employee = employeeBusiness.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            var res = employeeBusiness.UpdateEmployee(employee);
            try
            {
                if (ModelState.IsValid)
                {
                    employeeBusiness.UpdateEmployee(employee);
                    return RedirectToAction("ListOfEmployee");
                }
                return View();
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
                return View(employee);
            }

        }

        [HttpGet]
        public IActionResult GetEmpById(int id)
        {

            if (id == null)
            {
                return NotFound();
            }
            Employee employee = employeeBusiness.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound("Something went Wrong....");
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employee employee = employeeBusiness.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            employeeBusiness.DeleteEmployee(id);
            return RedirectToAction("ListofEmployee");
        }

    }
}
