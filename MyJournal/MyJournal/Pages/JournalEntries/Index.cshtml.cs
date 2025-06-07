using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyJournal.Data;
using MyJournal.Models;

namespace MyJournal.Pages.JournalEntries
{
    public class IndexModel : PageModel
    {
        private readonly MyJournal.Data.MyJournalContext _context;

        public IndexModel(MyJournal.Data.MyJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> JournalEntries { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? JournalEntryBooks { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortOrder { get; set; }


        public async Task OnGetAsync()
        {
            // <snippet_search_linqQuery>
            // saw this method on stack overflow and it seems to hold better...
            IQueryable<string> bookQuery = _context.JournalEntries
                                           .OrderBy(m => m.Book)
                                           .Select(m => m.Book)
                                           .Distinct();
            // </snippet_search_linqQuery>

            var entries = _context.JournalEntries.AsQueryable();

            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Note.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(JournalEntryBooks))
            {
                entries = entries.Where(s => s.Note.Contains(JournalEntryBooks));
            }

            if (!string.IsNullOrEmpty(JournalEntryBooks))
            {
                entries = entries.Where(x => x.Book == JournalEntryBooks);
            }

            switch (SortOrder)
            {
                case "book_asc":
                    entries = entries.OrderBy(s => s.Book);
                    break;
                case "date_asc":
                    entries = entries.OrderBy(s => s.NoteDate);
                    break;
                case "date_desc":
                    entries = entries.OrderByDescending(s => s.NoteDate);
                    break;
            }

            // <snippet_search_selectList>
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            // </snippet_search_selectList>
            JournalEntries = await entries.ToListAsync();
        }
    }
}
