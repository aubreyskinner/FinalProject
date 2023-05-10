using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProject.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Final.Models.WorkoutContext _context;

        public IndexModel(Final.Models.WorkoutContext context)
        {
            _context = context;
        }

        public new IList<User> User { get;set; } = default!;

        
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;
        
        public SelectList SortList {get; set;} = default!;
        [BindProperty(SupportsGet = true)]
        public string SearchString {get;set;} = default!;
        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                var query = _context.Users.Select(u => u);
                if (!String.IsNullOrEmpty(SearchString)){
                    query = query.Where(u => u.FirstName.Contains(SearchString));
                    
                }
            
               var query1 = _context.Users.Select(u => u);
                List<SelectListItem> sortItems = new List<SelectListItem> {
                    new SelectListItem { Text = "FirstName Ascending", Value = "first_asc" },
                    new SelectListItem { Text = "FirstName Descending", Value = "first_desc"}
                };
                SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

                switch (CurrentSort)
                {
                   
                    case "first_asc": 
                        query = query.OrderBy(u => u.FirstName);
                        break;
                    
                    case "first_desc":
                        query = query.OrderByDescending(u => u.FirstName);
                        break;
                    
                }

                
                User = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }
        }
    }
}
