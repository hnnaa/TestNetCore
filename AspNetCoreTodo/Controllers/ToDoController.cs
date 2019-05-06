using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo. Models;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            var models=new TodoViewModel();
            models.Items=new TodoItem[1]{new TodoItem {Title="1",Id=Guid.NewGuid()}};
            return View(models);
        }
    }
}
