using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LWTechTaskTimeTracker.Data;
using LWTechTaskTimeTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LWTechTaskTimeTracker.Controllers
{
    [Authorize]
    public class CompletedTasksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public CompletedTasksController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: CompletedTasks
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            return View(await _context.CompletedTask.Where(u => u.category.User.Id == user.Id).ToListAsync());
            //return View(await _context.CompletedTask.ToListAsync());
        }

        // GET: CompletedTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var completedTask = await _context.CompletedTask
                .FirstOrDefaultAsync(m => m.Id == id);
            if (completedTask == null)
            {
                return NotFound();
            }

            return View(completedTask);
        }

        // GET: CompletedTasks/Create
        public async Task<IActionResult> CreateAsync()
        {

            CreateCompletedTaskViewModel createViewModel = new CreateCompletedTaskViewModel();
            
            var currentUser = await _userManager.GetUserAsync(User);

            //Only adds categories for current user
            createViewModel.categories = _context.Category.Where(u => u.User.Id == currentUser.Id).ToList();
        
            return View(createViewModel);
        }

        // POST: CompletedTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,dateTime,CategoryId,IsActive")] CreateCompletedTaskViewModel createViewModel)
        {
            if (ModelState.IsValid)
            {
                CompletedTask newCompletedTask = new CompletedTask();
                newCompletedTask.Description = createViewModel.Description;
                newCompletedTask.dateTime = createViewModel.dateTime;
                newCompletedTask.category = _context.Category.Find(createViewModel.CategoryId);
                newCompletedTask.IsActive = createViewModel.IsActive;
                // TODO user is required by the ReminderMessagesController to get a list to CompletedTasks for the logged in user
                newCompletedTask.User = await _userManager.GetUserAsync(User);

                try
                {

                   
                    _context.Add(newCompletedTask);
                    await _context.SaveChangesAsync();
                }
                catch (Exception) { Console.WriteLine("Theres is a problem with the model "); }
                return RedirectToAction(nameof(Index));

            }
            return View(createViewModel);
            
        }
        // GET: CompletedTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var completedTask = await _context.CompletedTask.FindAsync(id);
            if (completedTask == null)
            {
                return NotFound();
            }
            return View(completedTask);
        }

        // POST: CompletedTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,dateTime,IsActive")] CompletedTask completedTask)
        {
            if (id != completedTask.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(completedTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompletedTaskExists(completedTask.Id))
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
            return View(completedTask);
        }

        // GET: CompletedTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var completedTask = await _context.CompletedTask
                .FirstOrDefaultAsync(m => m.Id == id);
            if (completedTask == null)
            {
                return NotFound();
            }

            return View(completedTask);
        }

        // POST: CompletedTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var completedTask = await _context.CompletedTask.FindAsync(id);
            try
            {
                _context.CompletedTask.Remove(completedTask);
                await _context.SaveChangesAsync();
            }
            catch (Exception) { Console.WriteLine("Can not Deleat Task "); }
            return RedirectToAction(nameof(Index));
        }

        private bool CompletedTaskExists(int id)
        {
            return _context.CompletedTask.Any(e => e.Id == id);
        }
        public async Task<IActionResult> History()
        {
            var user = await _userManager.GetUserAsync(User);

            return View(await _context.CompletedTask.Where(u => u.category.User.Id == user.Id).ToListAsync());
            
        }
    }
}
