﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyJournal.Data;
using MyJournal.Models;

namespace MyJournal.Pages.JournalEntries
{
    public class CreateModel : PageModel
    {
        private readonly MyJournal.Data.MyJournalContext _context;

        public CreateModel(MyJournal.Data.MyJournalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JournalEntry JournalEntries { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JournalEntries.Add(JournalEntries);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
