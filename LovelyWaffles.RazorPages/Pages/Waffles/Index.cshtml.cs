using LovelyWaffles.RazorPages.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace LovelyWaffles.RazorPages.Pages.Waffles
{
    public class IndexModel : PageModel
    {
        private readonly WaffleDbContext _dbContext;
        public IndexModel(WaffleDbContext waffleDbContext)
        {
            _dbContext = waffleDbContext;
        }

        public List<Waffle> Waffles { get; set; }
        public void OnGet()
        {
            Waffles = _dbContext.Waffles.ToList();
        }
    }
}
