using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaToDo.Controllers.ViewModels
{
    public class TasksListViewModel
    {
        public IEnumerable<Task> ToDoElements { get; set; }

        [Display(Name = "Nowe zadanie")]
        [Required(AllowEmptyStrings = false)]
        public string NewTask { get; set; }
    }
}