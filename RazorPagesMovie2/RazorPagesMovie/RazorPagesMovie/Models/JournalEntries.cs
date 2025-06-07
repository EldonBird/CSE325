using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class JournalEntries {
    
    public int Id { get; set; }
    public string? book { get; set; }
    public int? chapter { get; set; }
    public int? verse {get; set;}
    public string? note { get; set; }
    [DataType(DataType.Date)]
    public DateTime note_date { get; set; }
    
}