using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final.Pages
{
    public class DeleteWorkoutModel : PageModel
    {
        private readonly WorkoutContext _context; 
        private readonly ILogger _logger; 

        public DeleteWorkoutModel(WorkoutContext context, ILogger<DeleteWorkoutModel> logger)
        {
            _context = context;
            _logger = logger;
        }

       
        public SelectList Workouts {get; set;} = default!;

        
        [BindProperty]
        [Display(Name = "Workout")]
        public int? WorkoutId {get; set;}

        public IActionResult OnGet(int? id)
        {
           
            var workoutsWithUsers = _context.Workouts.Include(w => w.User).Select(w => new {
                ID = w.WorkoutId,
                Display = $"{w.User!.FirstName}: {w.DateCompleted}, {w.Calories}, {w.WorkoutLength}, {w.WorkoutType}"
            });
            

            Workouts = new SelectList(workoutsWithUsers.ToList(), "ID", "Display", id);
            return Page();
        }

        public IActionResult OnPost()
        {
           

            if (WorkoutId == null)
            {
                return NotFound();
            }
           
            Workout w = _context.Workouts.Find(WorkoutId)!;

            if (w != null)
            {
                _context.Workouts.Remove(w); 
                _context.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
