using Filmbibliote.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

[Authorize]
public class BaseLoggedInPageModel(UserManager<IdentityUser> userManager, ApplicationDbContext _dbContext) : PageModel
{
    private readonly UserManager<IdentityUser> _userManager = userManager;

    // Property to hold the current user
    public IdentityUser? CurrentUser { get; set; }
    public ApplicationDbContext dbContext = _dbContext;

    // Common method to get the current user
    public async Task LoadCurrentUserAsync()
    {
        CurrentUser = await _userManager.GetUserAsync(User);
    }
}
