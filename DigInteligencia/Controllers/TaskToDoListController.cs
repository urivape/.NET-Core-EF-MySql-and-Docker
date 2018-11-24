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
    public class TaskToDoListController: ControllerBase
    {
        private readonly DBContext _context;

        public TaskToDoListController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TaskToDoLists
        [HttpGet]
        public IEnumerable<TaskToDoList> GetTaskToDoList()
        {
            return _context.TaskToDoList;
        }

        // GET: api/TaskToDoLists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskToDoList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var taskToDoList = await _context.TaskToDoList.FindAsync(id);

            if (taskToDoList == null)
            {
                return NotFound();
            }

            return Ok(taskToDoList);
        }

        // PUT: api/TaskToDoLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskToDoList([FromRoute] int id, [FromBody] TaskToDoList taskToDoList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taskToDoList.ID)
            {
                return BadRequest();
            }

            _context.Entry(taskToDoList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskToDoListExists(id))
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

        // POST: api/TaskToDoLists
        [HttpPost]
        public async Task<IActionResult> PostTaskToDoList([FromBody] TaskToDoList taskToDoList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TaskToDoList.Add(taskToDoList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskToDoList", new { id = taskToDoList.ID }, taskToDoList);
        }

        // DELETE: api/TaskToDoLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskToDoList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var taskToDoList = await _context.TaskToDoList.FindAsync(id);
            if (taskToDoList == null)
            {
                return NotFound();
            }

            _context.TaskToDoList.Remove(taskToDoList);
            await _context.SaveChangesAsync();

            return Ok(taskToDoList);
        }

        private bool TaskToDoListExists(int id)
        {
            return _context.TaskToDoList.Any(e => e.ID == id);
        }
    }
}
