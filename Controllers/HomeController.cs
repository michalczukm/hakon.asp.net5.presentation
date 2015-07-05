using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PizzaToDo.Controllers.ViewModels;
using PizzaToDo.Models;
using PizzaToDo.Services;

namespace PizzaToDo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITasksService _tasksService;

        public HomeController(ITasksService tasksService)
        {
            _tasksService = tasksService;
        }

        public IActionResult Index()
        {
            var tasks = _tasksService.GetAll();

            var viewModel = new TasksListViewModel
            {
                ToDoElements = tasks
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page. Blabla asdad. New text 2 asd";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
