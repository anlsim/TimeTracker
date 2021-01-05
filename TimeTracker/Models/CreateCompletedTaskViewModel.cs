using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LWTechTaskTimeTracker.Models
{

    public class CreateCompletedTaskViewModel
    {
        public List<Category> categories;
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Task")]
        public string Description { get; set; }

        [Display(Name = "Due Date")]

        public DateTime dateTime { get; set; } = DateTime.Now;
        [Display(Name = "Completed ?")]
        public bool IsActive { get; set; }
        public string DateTimeDescriptionConcatenate()

        {
            return "{" + dateTime.ToString() + "}" + " " + Description;
        }

    }
}
