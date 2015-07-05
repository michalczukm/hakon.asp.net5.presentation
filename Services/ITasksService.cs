using System.Collections.Generic;
using PizzaToDo.Controllers.ViewModels;

namespace PizzaToDo.Services
{
    public interface ITasksService
    {
        IEnumerable<Task> GetAll();
        void Add(string newTask);
        void Delete(string id);
        void Complete(string id);
    }
}