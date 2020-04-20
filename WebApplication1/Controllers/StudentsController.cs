using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.DAL.MemoryStorage;
using WebApplication1.Common;

namespace WebApplication1.Controllers
{
    public class StudentsController : Controller
    {
        public readonly IGroupStorage _storage;
        public StudentsController(IGroupStorage storage)
        {
            _storage = storage;
        }
        public IActionResult Index(int? id, int? d)
        {
            var model = _storage.GetAll().Select(Mapper.ToView).ToList(); ;
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new GroupModel());
        }

        [HttpPost]
        public IActionResult Create(GroupModel model)
        {
            if (ModelState.IsValid)
            {
                _storage.Add(Mapper.ToDomain(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}