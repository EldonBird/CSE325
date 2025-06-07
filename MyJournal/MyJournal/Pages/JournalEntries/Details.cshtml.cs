using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyJournal.Data;
using MyJournal.Models;

namespace MyJournal.Pages.JournalEntries
{
    public class DetailsModel : PageModel
    {
        private readonly MyJournal.Data.MyJournalContext _context;

        public DetailsModel(MyJournal.Data.MyJournalContext context)
        {
            _context = context;
        }

        public JournalEntry JournalEntries { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journalentries = await _context.JournalEntries.FirstOrDefaultAsync(m => m.Id == id);

            if (journalentries is not null)
            {
                JournalEntries = journalentries;

                return Page();
            }

            return NotFound();
        }
    }
}
