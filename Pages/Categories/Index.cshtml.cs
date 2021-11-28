﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Muresan_Denisa_Lab8.Data.Muresan_Denisa_Lab8Context _context;

        public IndexModel(Muresan_Denisa_Lab8.Data.Muresan_Denisa_Lab8Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; }

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}