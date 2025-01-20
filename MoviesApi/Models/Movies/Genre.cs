using System;
using System.Collections.Generic;

namespace MoviesApi.Models.Movies;

public partial class Genre
{
    public int GenreId { get; set; }

    public string? GenreName { get; set; }
}
