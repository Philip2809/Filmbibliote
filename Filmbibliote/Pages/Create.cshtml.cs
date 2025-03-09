using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Filmbibliote.Data;
using Filmbibliote.Modeller;
using Microsoft.AspNetCore.Identity;

namespace Filmbibliote.Pages
{
    public class CreateModel(UserManager<IdentityUser> userManager, ApplicationDbContext context) : BaseLoggedInPageModel(userManager, context)
    {
        [BindProperty]
        public Film Film { get; set; } = default!;
        public IActionResult OnGet()
        {
            return Page();
        }

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await LoadCurrentUserAsync();

            if (!ModelState.IsValid || CurrentUser == null)
            {
                return Page();
            }

            Film.UserID = CurrentUser.Id;

            dbContext.Filmer.Add(Film);
            await dbContext.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
