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
    public class ReminderMessagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public ReminderMessagesController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ReminderMessages
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            // TODO not sure if User should be a property of Reminder Message, get list by looking at list of completedTasks instead
            return View(await _context.ReminderMessage.Where(u => u.completedTask.User.Id == currentUser.Id).ToListAsync());
            
            // return View(await _context.ReminderMessage.ToListAsync());
        }

        // GET: ReminderMessages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminderMessage = await _context.ReminderMessage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reminderMessage == null)
            {
                return NotFound();
            }

            return View(reminderMessage);
        }

        // GET: ReminderMessages/Create
        public async Task<IActionResult> CreateAsync()
        {
            CreateReminderMessageViewModel createReminderMessageViewModel = new CreateReminderMessageViewModel();
            var currentUser = await _userManager.GetUserAsync(User);
            // show tasks associated with the current user
            createReminderMessageViewModel.completedTasks = _context.CompletedTask.Where(u => u.User.Id == currentUser.Id).ToList();
            return View(createReminderMessageViewModel);
        }

        // POST: ReminderMessages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompletedTaskId,Description,dateTime,Message")] CreateReminderMessageViewModel createReminderMessageViewModel)
        {
            if (ModelState.IsValid)
            {
                ReminderMessage newReminderMessage = new ReminderMessage();
                newReminderMessage.dateTime = createReminderMessageViewModel.dateTime;
                newReminderMessage.Message = createReminderMessageViewModel.Message;
                newReminderMessage.completedTask = _context.CompletedTask.Find(createReminderMessageViewModel.CompletedTaskId);
                // TODO do I need to assign the user in the line below?
                newReminderMessage.User = await _userManager.GetUserAsync(User);

                try
                {
                    _context.Add(newReminderMessage);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error could not create ReminderMessage");
                }
                return RedirectToAction(nameof(Index));
            }
            return View(createReminderMessageViewModel);
        }

        // GET: ReminderMessages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminderMessage = await _context.ReminderMessage.FindAsync(id);
            if (reminderMessage == null)
            {
                return NotFound();
            }
            return View(reminderMessage);
        }

        // POST: ReminderMessages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,dateTime,Message")] ReminderMessage reminderMessage)
        {
            if (id != reminderMessage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reminderMessage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReminderMessageExists(reminderMessage.Id))
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
            return View(reminderMessage);
        }

        // GET: ReminderMessages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminderMessage = await _context.ReminderMessage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reminderMessage == null)
            {
                return NotFound();
            }

            return View(reminderMessage);
        }

        // POST: ReminderMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reminderMessage = await _context.ReminderMessage.FindAsync(id);
            try
            {
                _context.ReminderMessage.Remove(reminderMessage);
                await _context.SaveChangesAsync();
            } catch (Exception)
            {
                Console.WriteLine("Error cannot delete ReminderMessage");
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ReminderMessageExists(int id)
        {
            return _context.ReminderMessage.Any(e => e.Id == id);
        }
    }
}
