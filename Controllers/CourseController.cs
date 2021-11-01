using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MOCP.Models;
using MOCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourse _Course;
        private readonly IMentor _Mentor;
        private readonly IDepartment _Department;
        public CourseController(ICourse _ICourse, IMentor _IMentor, IDepartment _IDepartment)
        {
            _Course = _ICourse;
            _Department = _IDepartment;
            _Mentor = _IMentor;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(_Course.GetCourses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _Department.GetDepartments;
            ViewBag.Mentors = _Mentor.GetMentors;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course model)
        {
            if (ModelState.IsValid)
            {
                _Course.Add(model);
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
                Course model = _Course.GetCourse(Id);
                return View(model);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Course.Remove(Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            return View(_Course.GetCourse(Id));
        }
    }
}
