﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Socol_Andreea_Lab2.Data;
using Socol_Andreea_Lab2.Models;

namespace Socol_Andreea_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Socol_Andreea_Lab2.Data.Socol_Andreea_Lab2Context _context;

        public IndexModel(Socol_Andreea_Lab2.Data.Socol_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
 .Include(b => b.Publisher)
 .ToListAsync();

            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}