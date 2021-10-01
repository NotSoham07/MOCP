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
    public class MentorController : Controller
    {
        private readonly IMentor _Mentor;
        private readonly IDepartment _Department;
        public MentorController(IMentor _IMentor, IDepartment _IDepartment)
        {
            _Mentor = _IMentor;
            _Department = _IDepartment;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(_Mentor.GetMentors);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _Department.GetDepartments;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Mentor model)
        {
            if (ModelState.IsValid)
            {
                _Mentor.Add(model);
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
                Mentor model = _Mentor.GetMentor(Id);
                return View(model);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Mentor.Remove(Id);
            return RedirectToAction("Index");
        }
    }
}
