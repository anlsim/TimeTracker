using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LWTechTaskTimeTracker.Models
{
    public class ReminderMessage
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Reminder Date")]
        public DateTime dateTime { get; set; }

        [Display(Name = "Reminder Message")]
        public string Message { get; set; }

        [Display(Name = "Task")]
        public CompletedTask completedTask { get; set; }

        public IdentityUser User { get; set; }
        public string IntegerDateTimeMessageConcatenate()

        {
            return Id.ToString() + " " + "{" + dateTime.ToString() + "}" + " " + Message;
        }
    }
}
