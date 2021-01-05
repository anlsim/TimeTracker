using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LWTechTaskTimeTracker.Models
{
    public class History
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Task")]
        public CompletedTask CompletedTask { get; set; }
        [Display(Name = "Message")]
        public ReminderMessage ReminderMessage { get; set; }
        [Display(Name = "Category")]
        public Category Category { get; set; }
        [Display(Name = "Display")]
        public CreateCompletedTaskViewModel CreateCompletedTaskViewModel { get; set; }
        public string Description { get; set; }
        public string IntegerDescription()

        {
            return Id.ToString() + " " + Description;
        }

    } 
}
