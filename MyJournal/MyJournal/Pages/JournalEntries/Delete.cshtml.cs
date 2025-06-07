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
    public class DeleteModel : PageModel
    {
        private readonly MyJournal.Data.MyJournalContext _context;

        public DeleteModel(MyJournal.Data.MyJournalContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journalentries = await _context.JournalEntries.FindAsync(id);
            if (journalentries != null)
            {
                JournalEntries = journalentries;
                _context.JournalEntries.Remove(JournalEntries);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
