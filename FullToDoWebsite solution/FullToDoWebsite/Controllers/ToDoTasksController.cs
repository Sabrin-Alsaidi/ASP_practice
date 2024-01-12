using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullToDoWebsite.Data;
using FullToDoWebsite.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullToDoWebsite.Controllers
{
    public class ToDoTasksController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ToDoTasksController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var todo = _context.todoTask.ToList();

            return View(todo);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //return RedirectToAction("Index");
            return View();

        }

        [HttpPost]
        public IActionResult Create(ToDoTasks todos)
        {
            if (ModelState.IsValid)
            {
                _context.todoTask.Add(todos);
                _context.SaveChanges();
               return RedirectToAction("Index");
            }
            return View(todos);
        }

    }
}

