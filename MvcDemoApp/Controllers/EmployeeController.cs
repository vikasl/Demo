using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MvcDemoApp.DataService;
using MvcDemoApp.Models;

namespace MvcDemoApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeRepository _repository;
        public EmployeeController()
        {
            _repository = new EmployeeRepository();
            AutoMapper.Mapper.CreateMap<Employee, EditEmployeeViewModel>();
            AutoMapper.Mapper.CreateMap<string,char>().ConvertUsing(x=>Convert.ToChar(x));
       }

        public ViewResult Index()
        {
            return View("ListEmployee", null);
        }

        //
        // GET: /Employee/

        public JsonResult GetEmployeeList()
        {
            var employeeList = _repository.GetAllEmployees();

            return Json(employeeList);
        }

        
        [HttpGet]
        public ActionResult EditEmployee(string essn)
        {
            var employee = _repository.GetEmployee( essn);
            var editEmployeeViewModel = AutoMapper.Mapper.Map<Employee,EditEmployeeViewModel>(employee);

            return View("EditEmployee", editEmployeeViewModel);

        }



        [HttpPost]
        public ActionResult EditEmployee(EditEmployeeViewModel model)
        {
            return RedirectToAction("Index");
        }


        public ActionResult DeleteEmployee(string essn)
        {
            var employee = new Employee {Ssn = essn};
            _repository.Delete(employee);
            return RedirectToAction("Index");
        }


    }
}