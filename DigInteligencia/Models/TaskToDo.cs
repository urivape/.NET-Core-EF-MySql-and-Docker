using System.ComponentModel.DataAnnotations;

namespace DigInteligencia.Models
{
    public class TaskToDo
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int TaskToDoListID { get; set; }

        [Required]
        public string Description { get; set; }

        public TaskToDoList TaskToDoList { get; set; }
    }
}
