namespace LibraryProject.Repositories.Books;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Author { get; set; } = default!;
    public int PublicationYear { get; set; }
    public string? Isbn { get; set; } = default!;
    public string Genre { get; set; } = default!;
    public string? Publisher { get; set; }
    public int PageCount { get; set; }
    public string Language { get; set; } = default!;
    public string Summary { get; set; } = default!;
    public int AvailableCopies { get; set; }
}