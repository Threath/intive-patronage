﻿using Newtonsoft.Json;

namespace BooksAPI.src.Models;

public class Author
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public bool Gender { get; set; }

    [JsonIgnore]
    public IList<BookAuthor> BookAuthors { get; set; }
}