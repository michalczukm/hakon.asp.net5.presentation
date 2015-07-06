using System.Collections.Generic;
using System.Linq;
using PizzaToDo.Controllers.ViewModels;

namespace PizzaToDo.Controllers.Helpers
{
    public interface ITasksDisjoiner
    {
        IEnumerable<Task> GetCompletedFrom(IEnumerable<Task> tasks);
        IEnumerable<Task> GetToDoFrom(IEnumerable<Task> tasks);
    }

    public class TasksDisjoiner : ITasksDisjoiner
    {
        public IEnumerable<Task> GetCompletedFrom(IEnumerable<Task> tasks)
        {
            return tasks.Where(task => task.CompletedDate.HasValue);
        }

        public IEnumerable<Task> GetToDoFrom(IEnumerable<Task> tasks)
        {
            return tasks.Where(task => !task.CompletedDate.HasValue);
        }
    }
}