using Microsoft.AspNetCore.Mvc;
using MOCP.Models;
using MOCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartment _Department;
        public DepartmentController(IDepartment _IDepartment)
        {
            _Department = _IDepartment;
        }
        public IActionResult Index()
        {
            return View(_Department.GetDepartments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department model)
        {
            if (ModelState.IsValid)
            {
                _Department.Add(model);
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
                Department model = _Department.GetDepartment(Id);
                return View(model);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Department.Remove(Id);
            return RedirectToAction("Index");
        }
    }
}
