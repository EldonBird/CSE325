using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Models;

public class CreateMovieViewModel
{
    public Movie Movie { get; set; }

    public SelectList Genres { get; set; }
}
