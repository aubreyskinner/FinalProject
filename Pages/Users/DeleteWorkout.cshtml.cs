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
        private readonly WorkoutContext _context; // Database context
        private readonly ILogger _logger; // Logging object

        // Model Constructor. Used to bring in _context and logger from Dependency Injection
        public DeleteWorkoutModel(WorkoutContext context, ILogger<DeleteWorkoutModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Drop down list of all the Movie Reviews
        public SelectList Workouts {get; set;} = default!;

        // ReviewId to delete. We bind this property because the user will select it in our form and submit it.
        [BindProperty]
        [Display(Name = "Workout")]
        public int? WorkoutId {get; set;}

        public IActionResult OnGet(int? id)
        {
            // Get all the reviews to populate our SelectList drop down
            // Use an anonymous type because we want a new variable that shows the Movie Title and Review score
            var workoutsWithUsers = _context.Workouts.Include(w => w.User).Select(w => new {
                ID = w.WorkoutId,
                Display = $"{w.User!.FirstName}: {w.DateCompleted}, {w.Calories}, {w.WorkoutLength}, {w.WorkoutType}"
            });
            

            // Populate SelectList. This variable is brought into the Razor Page with the asp-items tag helper
            Workouts = new SelectList(workoutsWithUsers.ToList(), "ID", "Display", id);
            return Page();
        }

        public IActionResult OnPost()
        {
           

            if (WorkoutId == null)
            {
                return NotFound();
            }
            // Find the review in the database
            Workout w = _context.Workouts.Find(WorkoutId)!;

            if (w != null)
            {
                _context.Workouts.Remove(w); // Delete the review
                _context.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
