using LovelyWaffles.RazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LovelyWaffles.RazorPages.Pages.Waffles
{
    public class DeleteModel : PageModel
    {
        private readonly WaffleDbContext _dbContext;
        public DeleteModel(WaffleDbContext waffleDbContext)
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
            Waffle = _dbContext.Waffles.Find(id);
            _dbContext.Waffles.Remove(Waffle);
            _dbContext.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}