using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LWTechTaskTimeTracker.Models
{
    public class CompletedTask
    {

        public int Id { get; set; }

        public Category category { get; set; }
        [Required]
        [Display(Name = "Task")]
        public string Description { get; set; }
        [Display(Name = "Due Date")]
        public DateTime dateTime { get; set; }
        public string IntegerDescriptionConcatenate()

        {
            return Id.ToString() + " " + Description;
        }
        public IdentityUser User { get; set; }
        [Display(Name = "Completed ?")]
        public bool IsActive { get; set; }
    }
}
