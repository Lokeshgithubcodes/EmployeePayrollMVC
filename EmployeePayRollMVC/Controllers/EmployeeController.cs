using BusinessLayer.Interfaces;
using CommonLayer.Models;
using Microsoft.AspNetCore.Http;
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

      


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            var result = employeeBusiness.Login(model);
            if (result == null)
            {
                return Content("Invalid Credentials");
            }
            else
            {

                HttpContext.Session.SetInt32("Id", result.Id);

                return RedirectToAction("GetEmpById", new { Id = result.Id });
            }
        }

        [HttpGet]

        public IActionResult GetByName(string name)
        {
            List<Employee> employees = new List<Employee>();
            employees=employeeBusiness.GetByName(name).ToList();
            if(employees == null)
            {
                return Content("Not Found");
            }
            return View(employees);
        }





        [HttpGet]
        public IActionResult empinsert(int id)
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

        [HttpPost]
        public IActionResult empinsert(Employee employee)
        {
            var res = employeeBusiness.Empnotexist(employee);
            try
            {
                if (ModelState.IsValid)
                {
                    employeeBusiness.Empnotexist(employee);
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

        //for ViewData 

        public class Workers
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }

        [HttpGet]
        public IActionResult ViewDemo()
        {
            List<Workers> workers = new List<Workers> 
            { 
                new Workers{Id=1, Name="John"},
                new Workers{Id=2, Name="Will"},
                new Workers{Id=3, Name="Scott"},
                new Workers{Id=4, Name="Smith"}
            };

            //for transfer data from controller to view 
            ViewBag.date = DateTime.Now.ToString();
            //for transfer large set of data from controller to view
            ViewData["All"] = workers;

            //By Using of TempData we can transfer large amount of data to multiple controller.

            return View();
        }


    }
}
