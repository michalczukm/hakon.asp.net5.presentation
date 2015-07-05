using Microsoft.AspNet.Mvc;
using PizzaToDo.Controllers.ViewModels;
using PizzaToDo.Services;

namespace PizzaToDo.Controllers
{
    [Route("[controller]")]
    public class TasksController : Controller
    {
        private readonly ITasksService _tasksService;

        public TasksController(ITasksService tasksService)
        {
            _tasksService = tasksService;
        }

        [HttpPost]
        public IActionResult Add(TasksListViewModel viewModel)
        {
            _tasksService.Add(viewModel.NewTask);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("delete/{id}")]
        public IActionResult Delete(string id)
        {
            _tasksService.Delete(id);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("complete/{id}")]
        public IActionResult Complete(string id)
        {
            _tasksService.Complete(id);
            return RedirectToAction("Index", "Home");
        }
    }
}