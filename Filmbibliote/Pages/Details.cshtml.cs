using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Filmbibliote.Data;
using Filmbibliote.Modeller;

namespace Filmbibliote.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Filmbibliote.Data.ApplicationDbContext _context;

        public DetailsModel(Filmbibliote.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Film Film { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Filmer.FirstOrDefaultAsync(m => m.FilmID == id);
            if (film == null)
            {
                return NotFound();
            }
            else
            {
                Film = film;
            }
            return Page();
        }
    }
}
