using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyJournal.Models;

public class JournalEntry
{
    public int Id { get; set; }
    public string? Book { get; set; }
    public int? Chapter {  get; set; }
    public int? Verse { get; set; }
    public string? Note { get; set; }
    [DataType(DataType.Date)]
    public DateTime? NoteDate { get; set; }
}

