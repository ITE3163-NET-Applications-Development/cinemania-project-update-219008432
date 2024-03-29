using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CineMania.Data;
using CineMania.Models;

namespace CineMania.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly CineMania.Data.CinemaniaContext _context;

        public DetailsModel(CineMania.Data.CinemaniaContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }
        public List<Movie> Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null && Category == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
           Category = await _context.Movies.Where(m => m.Genre == Movie.Genre).
                           ToListAsync(); 
            

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
