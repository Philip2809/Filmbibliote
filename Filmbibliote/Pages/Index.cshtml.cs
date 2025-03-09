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
    public class IndexModel : PageModel
    {
        private readonly Filmbibliote.Data.ApplicationDbContext _context;

        public IndexModel(Filmbibliote.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Film = await _context.Filmer.ToListAsync();
            Console.WriteLine(Film.Count);
        }
    }
}
