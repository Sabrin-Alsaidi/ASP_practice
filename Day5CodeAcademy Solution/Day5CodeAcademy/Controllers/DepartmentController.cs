using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.BLL.Interfaces;
using CodeAcademy.DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day5CodeAcademy.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentReposatory _departmentRepo;

        public DepartmentController(IDepartmentReposatory departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var deps = _departmentRepo.GetAll();
            return View(deps);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else
            {
                var dep = _departmentRepo.Get(id.Value);
                return View(dep);
            }
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Department dep)
        {
            _departmentRepo.Create(dep);
            return RedirectToAction("Index");
        }

        public IActionResult Update(Department dep)
        {

            var deps = _departmentRepo.Update(dep);
            return View(deps);

        }
        public IActionResult Delete(Department dep)
        {

            var deps = _departmentRepo.Delete(dep);
            return View(deps);

        }
    }
}

