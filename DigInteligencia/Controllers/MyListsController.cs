using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigInteligencia.Models;

namespace DigInteligencia.Controllers
{
    public class MyListsController : Controller
    {
        private readonly DBContext _context;

        public MyListsController(DBContext context)
        {
            _context = context;
        }

        // GET: MyLists
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: New Task
        public async Task<IActionResult> CreateTask()
        {
            return View();
        }

        // GET: MyLists
        public async Task<IActionResult> Lists()
        {
            var TaskToDoLists = await _context.TaskToDoList.ToListAsync();
            foreach (TaskToDoList list in TaskToDoLists)
            {
                list.TaskToDo = _context.TaskToDo.Where(t => t.TaskToDoListID == list.ID).ToList();
            }
            return View(TaskToDoLists);
        }

        // GET: MyLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskToDoList = await _context.TaskToDoList
                .FirstOrDefaultAsync(m => m.ID == id);
            if (taskToDoList == null)
            {
                return NotFound();
            }

            return View(taskToDoList);
        }

        // GET: MyLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] TaskToDoList taskToDoList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskToDoList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taskToDoList);
        }

        // GET: MyLists/EditTask/5
        public async Task<IActionResult> EditTask(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskToDo = await _context.TaskToDo.FindAsync(id);
            if (taskToDo == null)
            {
                return NotFound();
            }
            return View(taskToDo);
        }

        // POST: MyLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] TaskToDoList taskToDoList)
        {
            if (id != taskToDoList.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskToDoList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskToDoListExists(taskToDoList.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(taskToDoList);
        }

        // GET: MyLists/DeleteTask/5
        public async Task<IActionResult> DeleteTask(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskToDo = await _context.TaskToDo
                .FirstOrDefaultAsync(m => m.ID == id);
            if (taskToDo == null)
            {
                return NotFound();
            }

            return View(taskToDo);
        }

        private bool TaskToDoListExists(int id)
        {
            return _context.TaskToDoList.Any(e => e.ID == id);
        }
    }
}
