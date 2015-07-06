using Microsoft.AspNet.Mvc;
using PizzaToDo.Controllers.ViewModels;
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

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
