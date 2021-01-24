using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LWTechTaskTimeTracker.Models;
using Microsoft.AspNetCore.Identity;

namespace LWTechTaskTimeTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LWTechTaskTimeTracker.Models.Category> Category { get; set; }
        public DbSet<LWTechTaskTimeTracker.Models.ReminderMessage> ReminderMessage { get; set; }
        public DbSet<LWTechTaskTimeTracker.Models.CompletedTask> CompletedTask { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            base.OnModelCreating(builder);
            var hasher = new PasswordHasher<IdentityUser>();
            
        }
    }
}
