using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LWTechTaskTimeTracker.Models
{
    public class CreateReminderMessageViewModel
    {
        public List<CompletedTask> completedTasks;

        public int CompletedTaskId { get; set; }

        [Display(Name = "Task")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Reminder Date")]
        public DateTime dateTime { get; set; }

        [Display(Name = "Reminder Message")]
        public string Message { get; set; }
    }
}
