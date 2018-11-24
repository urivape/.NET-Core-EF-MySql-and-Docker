using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigInteligencia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DigInteligencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskToDoController: ControllerBase
    {
        private readonly DBContext _context;

        public TaskToDoController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TasksToDo
        [HttpGet]
        public IEnumerable<TaskToDo> GetTaskToDo()
        {
            return _context.TaskToDo;
        }

        // GET: api/TasksToDo/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskToDo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var taskToDo = await _context.TaskToDo.FindAsync(id);

            if (taskToDo == null)
            {
                return NotFound();
            }

            return Ok(taskToDo);
        }

        // PUT: api/TasksToDo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskToDo([FromRoute] int id, [FromBody] TaskToDo taskToDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taskToDo.ID)
            {
                return BadRequest();
            }

            _context.Entry(taskToDo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskToDoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TasksToDo
        [HttpPost]
        public async Task<IActionResult> PostTaskToDo([FromBody] TaskToDo taskToDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TaskToDo.Add(taskToDo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskToDo", new { id = taskToDo.ID }, taskToDo);
        }

        // DELETE: api/TasksToDo/5
        [HttpPost("{id}")]
        public async Task<IActionResult> DeleteTaskToDo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var taskToDo = await _context.TaskToDo.FindAsync(id);
            if (taskToDo == null)
            {
                return NotFound();
            }

            _context.TaskToDo.Remove(taskToDo);
            await _context.SaveChangesAsync();

            return Ok(taskToDo);
        }

        private bool TaskToDoExists(int id)
        {
            return _context.TaskToDo.Any(e => e.ID == id);
        }
    }
}
