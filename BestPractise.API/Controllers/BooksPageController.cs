using System.Text.Json;
using BestPractise.API.Model;
using BestPractise.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestPractise.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksPageController : ControllerBase
{
    private readonly BookService _bookService;
    private readonly CacheService _cacheService;

    public BooksPageController(BookService bookService, CacheService cacheService)
    {
        _bookService = bookService;
        _cacheService = cacheService;
    }

    [HttpGet("paged")]
    public async Task<IActionResult> GetBooksPaged([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        if (pageNumber <= 0 || pageSize <= 0)
        {
            return BadRequest("Page number and page size must be greater than zero.");
        }

        string cacheKey = $"books:page:{pageNumber}:size:{pageSize}";
        var cachedBooks = await _cacheService.GetCacheValueAsync(cacheKey);

        if (!string.IsNullOrEmpty(cachedBooks))
        {
            var booksFromCache = JsonSerializer.Deserialize<IEnumerable<Book>>(cachedBooks);
            return Ok(new { Source = "Cache", Data = booksFromCache });
        }

        var books = _bookService.GetBooks(pageNumber, pageSize);
        await _cacheService.SetCacheValueAsync(cacheKey, JsonSerializer.Serialize(books), TimeSpan.FromMinutes(5));

        return Ok(new { Source = "Database", Data = books });
    }
}