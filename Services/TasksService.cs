using System;
using System.Collections.Generic;
using System.Linq;
using PizzaToDo.Controllers.ViewModels;

namespace PizzaToDo.Services
{
    public class TasksService : ITasksService
    {
        private readonly List<Task> _tasks;

        public TasksService()
        {
            _tasks = new List<Task>();
        }

        public IEnumerable<Task> GetAll()
        {
            return _tasks;
        }

        public void Add(string newTask)
        {
            var task = new Task
            {
                AddDate = DateTime.Now,
                Id = Guid.NewGuid().ToString(),
                Content = newTask
            };

            _tasks.Add(task);
        }

        public void Delete(string id)
        {
            var taskToRemove = GetTaskById(id);

            if (taskToRemove != null)
            {
                _tasks.Remove(taskToRemove);
            }
        }

        public void Complete(string id)
        {
            var task = GetTaskById(id);

            if (task != null)
            {
                task.CompletedDate = DateTime.Now;
            }
        }

        private Task GetTaskById(string id)
        {
            var taskToRemove = _tasks.FirstOrDefault(task => task.Id == id);
            return taskToRemove;
        }
    }
}