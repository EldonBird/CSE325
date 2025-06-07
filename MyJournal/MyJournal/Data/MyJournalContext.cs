using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyJournal.Models;

namespace MyJournal.Data
{
    public class MyJournalContext : DbContext
    {
        public MyJournalContext (DbContextOptions<MyJournalContext> options)
            : base(options)
        {
        }

        public DbSet<MyJournal.Models.JournalEntry> JournalEntries { get; set; } = default!;
    }
}
