using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Muresan_Denisa_Lab8.Data;
using Muresan_Denisa_Lab8.Models;

namespace Muresan_Denisa_Lab8.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Muresan_Denisa_Lab8.Data.Muresan_Denisa_Lab8Context _context;

        public DetailsModel(Muresan_Denisa_Lab8.Data.Muresan_Denisa_Lab8Context context)
        {
            _context = context;
        }

        public BookCategory BookCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).FirstOrDefaultAsync(m => m.ID == id);

            if (BookCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
