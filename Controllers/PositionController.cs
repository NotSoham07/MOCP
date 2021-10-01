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
    public class PositionController : Controller
    {
        private readonly IPosition _Position;
        public PositionController(IPosition _IPosition)
        {
            _Position = _IPosition;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(_Position.GetPositions);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Position model)
        {
            if(ModelState.IsValid)
            {
                _Position.Add(model);
                return RedirectToAction("Index");
            }
            return View();
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
                Position model = _Position.GetPosition(Id);
                return View(model);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Position.Remove(Id);
            return RedirectToAction("Index");
        }
    }
}
