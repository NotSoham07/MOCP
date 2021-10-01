using Microsoft.AspNetCore.Mvc;
using MOCP.Models;
using MOCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace MOCP.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _Employee;
        private readonly IDepartment _Department;
        private readonly IPosition _Position;
        private readonly ICourse _Course;

        public EmployeeController(IEmployee _IEmployee, IDepartment _IDepartment, IPosition _IPosition, ICourse _ICourse)
        {
            _Employee = _IEmployee;
            _Department = _IDepartment;
            _Position = _IPosition;
            _Course = _ICourse;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View(_Employee.GetEmployees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _Department.GetDepartments;
            ViewBag.Positions = _Position.GetPositions;
            ViewBag.Courses = _Course.GetCourses;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _Employee.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                Employee model = _Employee.GetEmployee(Id);
                return View(model);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Employee.Remove(Id);
            return RedirectToAction("Index");
        }
    }
}
