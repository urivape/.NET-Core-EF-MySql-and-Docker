using Microsoft.EntityFrameworkCore;

namespace DigInteligencia.Models
{
    public class DBContext : DbContext
    {
        public DbSet<TaskToDoList> TaskToDoList { get; set; }
        public DbSet<TaskToDo> TaskToDo { get; set; }

        public DBContext(DbContextOptions options) : base(options) { }
    }
}
