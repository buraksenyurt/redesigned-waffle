using LovelyWaffles.RazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LovelyWaffles.RazorPages.Pages.Waffles
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Waffle Waffle{ get; set; }
        private readonly WaffleDbContext _dbContext;
        public CreateModel(WaffleDbContext waffleDbContext)
        {
            _dbContext = waffleDbContext;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            _dbContext.Waffles.Add(Waffle);
            _dbContext.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
