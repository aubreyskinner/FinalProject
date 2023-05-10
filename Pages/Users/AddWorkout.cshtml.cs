using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final.Pages
{
    public class AddWorkoutModel : PageModel
    {
        private readonly ILogger<AddWorkoutModel> _logger;
        private readonly WorkoutContext _context;
        [BindProperty]
        public Workout Workout {get; set;} = default!;
        
        public User UserId {get;set;} = default!;
        public new User User {get;set;} =default!;
        public SelectList UsersDropDown {get; set;} = default!;

        public AddWorkoutModel(WorkoutContext context, ILogger<AddWorkoutModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            UsersDropDown = new SelectList(_context.Users.ToList(), "UserId", "FirstName");
        }
     public IActionResult OnPost()
{
   if (!ModelState.IsValid)
   {
       return Page();
   }

   var user = _context.Users.Find(Workout.UserId);
   Workout.User = user;
   
   _context.Workouts.Add(Workout);
   _context.SaveChanges();

   return RedirectToPage("./Index");
}

 
           

    }
}