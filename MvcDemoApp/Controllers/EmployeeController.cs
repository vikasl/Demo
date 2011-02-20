using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MvcDemoApp.Models;

namespace MvcDemoApp.Controllers
{
    public class EmployeeController : Controller
    {
        public ViewResult Index()
        {
            return View("EmployeeList", null);
        }

        //
        // GET: /Employee/

        public JsonResult GetEmployeeList()
        {
            var employeeList =
                new List<Employee>
                    {
                        new Employee
                            {
                                Fname = "Sam",
                                Lname = "Pitroda",
                                Addresss = "ABC Street , Mayfield Heights, Oh 44124",
                                Bdate = new DateTime(1980, 01, 01)
                            },
                        new Employee
                            {
                                Fname = "John",
                                Minit = 'B',
                                Lname = "Smith",
                                Ssn = "123456789",
                                Bdate = new DateTime(1965, 01, 09),
                                Addresss = " 731 Fondren,  Houston,  TX",
                                Sex = 'M',
                                Salary = 30000,
                                Super_ssn = "333445555",
                                Dno = 5
                            }
                    };

            return Json(employeeList);
        }

        
        [HttpGet]
        public ActionResult EditEmployee(string essn)
        {
            var employee = GetEmployeeBySsn(essn);
            return View("EditEmployee", employee);

        }


        private Employee  GetEmployeeBySsn(string essn)
        {
            return new Employee
                {
                    Fname = "John",
                    Minit = 'B',
                    Lname = "Smith",
                    Ssn = "123456789",
                    Bdate = new DateTime(1965, 01, 09),
                    Addresss = " 731 Fondren,  Houston,  TX",
                    Sex = 'M',
                    Salary = 30000,
                    Super_ssn = "333445555",
                    Dno = 5
                };
        }

        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            return RedirectToAction("Index");
        }
    }
}