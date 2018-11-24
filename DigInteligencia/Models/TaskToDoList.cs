using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigInteligencia.Models
{
    public class TaskToDoList
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<TaskToDo> TaskToDo { get; set; }
    }
}
