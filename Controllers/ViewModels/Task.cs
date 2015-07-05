using System;

namespace PizzaToDo.Controllers.ViewModels
{
    public class Task
    {
        public DateTime AddDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string Content { get; set; }
        public string Id { get; set; }
    }
}