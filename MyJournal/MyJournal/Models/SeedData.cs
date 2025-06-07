using Microsoft.EntityFrameworkCore;
using MyJournal.Data;
using MyJournal.Models;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MyJournalContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MyJournalContext>>()))
        {
            if (context == null || context.JournalEntries == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.JournalEntries.Any())
            {
                return;   // DB has been seeded
            }

            context.JournalEntries.AddRange(
                    new JournalEntry
                    {
                        Book = "Alma",
                        Chapter = 37,
                        Verse = 6,
                        Note = "By small and simple things are great things brought to pass.",
                        NoteDate = DateTime.Parse("2024-01-01")
                    },
                    new JournalEntry
                    {
                        Book = "Mosiah",
                        Chapter = 2,
                        Verse = 17,
                        Note = "When ye are in the service of your fellow beings ye are only in the service of your God.",
                        NoteDate = DateTime.Parse("2024-02-15")
                    },
                    new JournalEntry
                    {
                        Book = "Ether",
                        Chapter = 12,
                        Verse = 27,
                        Note = "Weak things become strong unto them.",
                        NoteDate = DateTime.Parse("2024-03-10")
                    },
                    new JournalEntry
                    {
                        Book = "2 Nephi",
                        Chapter = 2,
                        Verse = 25,
                        Note = "Adam fell that men might be; and men are, that they might have joy.",
                        NoteDate = DateTime.Parse("2024-04-05")
                    }
                );

            context.SaveChanges();
        }
    }
}