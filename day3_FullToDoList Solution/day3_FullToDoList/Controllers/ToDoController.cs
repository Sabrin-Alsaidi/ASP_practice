using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day3_FullToDoList.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace day3_FullToDoList.Controllers
{
    
    public class ToDoController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        
        public ToDoController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var todo = _dbContext.todoLists.ToList();
            return View(todo);
        }
    }
}

