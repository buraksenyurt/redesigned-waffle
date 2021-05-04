using LovelyWaffles.RazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LovelyWaffles.RazorPages.Pages.Waffles
{
    public class EditModel : PageModel
    {
        private readonly WaffleDbContext _dbContext;
        public EditModel(WaffleDbContext waffleDbContext)
        {
            _dbContext = waffleDbContext;
        }
        [BindProperty]
        public Waffle Waffle { get; set; }
        public void OnGet(int id)
        {
            Waffle = _dbContext.Waffles.Find(id);
        }
        public IActionResult OnPost(int id)
        {
            var orgWaffle = _dbContext.Waffles.Find(id);
            orgWaffle.InStock = Waffle.InStock;
            orgWaffle.Recipe = Waffle.Recipe;
            orgWaffle.Title = Waffle.Title;

            _dbContext.Waffles.Update(orgWaffle);
            _dbContext.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
