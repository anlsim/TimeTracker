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
            builder.Entity<IdentityUser>().HasData(

                new IdentityUser { Id = "3f9b0d15-de9b-4725-b2d2-6da825cb7abc", NormalizedUserName = "JOHN@LWTECH.EDU", UserName = "john@lwtech.edu", Email = "john@lwtech.edu", NormalizedEmail = "JOHN@LWTECH.EDU", EmailConfirmed = true, PhoneNumber = "1231230202", PasswordHash = hasher.HashPassword(null, "Abc123*"), LockoutEnabled = true },
                new IdentityUser { Id = "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc", NormalizedUserName = "MARIA@LWTECH.EDU", UserName = "maria@lwtech.edu", Email = "maria@lwtech.edu", NormalizedEmail = "MARIA@LWTECH.EDU", EmailConfirmed = true, PhoneNumber = "2062220000", PasswordHash = hasher.HashPassword(null, "123*Abc"), LockoutEnabled = true }


            );

        }
    }
}
