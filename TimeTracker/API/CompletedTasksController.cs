using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LWTechTaskTimeTracker.Data;
using LWTechTaskTimeTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LWTechTaskTimeTracker.API
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CompletedTasksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CompletedTasksController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: api/CompletedTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompletedTask>>> GetCompletedTask()
        {
            var user = await _userManager.GetUserAsync(User);

            return await _context.CompletedTask.Where(u => u.category.User.Id == user.Id).ToListAsync();
        }

        // GET: api/CompletedTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompletedTask>> GetCompletedTask(int id)
        {
            var completedTask = await _context.CompletedTask.FindAsync(id);

            if (completedTask == null)
            {
                return NotFound();
            }

            return completedTask;
        }

        // PUT: api/CompletedTasks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompletedTask(int id, CompletedTask completedTask)
        {
            if (id != completedTask.Id)
            {
                return BadRequest();
            }

            _context.Entry(completedTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompletedTaskExists(id))
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

        // POST: api/CompletedTasks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CompletedTask>> PostCompletedTask(CompletedTask completedTask)
        {
            _context.CompletedTask.Add(completedTask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompletedTask", new { id = completedTask.Id }, completedTask);
        }

        // DELETE: api/CompletedTasks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CompletedTask>> DeleteCompletedTask(int id)
        {
            var completedTask = await _context.CompletedTask.FindAsync(id);
            if (completedTask == null)
            {
                return NotFound();
            }

            _context.CompletedTask.Remove(completedTask);
            await _context.SaveChangesAsync();

            return completedTask;
        }

        private bool CompletedTaskExists(int id)
        {
            return _context.CompletedTask.Any(e => e.Id == id);
        }
    }
}
