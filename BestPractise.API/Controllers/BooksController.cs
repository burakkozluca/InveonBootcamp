using System.Text.Json;
using BestPractise.API.Model;
using BestPractise.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestPractise.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly BookService _bookService;
    private readonly CacheService _cacheService;
    
    public BooksController(BookService bookService, CacheService cacheService)
    {
        _bookService = bookService;
        _cacheService = cacheService;
    }
    
    [HttpGet]
    public IActionResult GetAllBooks()
    {
        return Ok();
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBookById(int id)
    {
        string cacheKey = $"book:{id}";
        var cachedBook = await _cacheService.GetCacheValueAsync(cacheKey);

        if (!string.IsNullOrEmpty(cachedBook))
        {
            var bookFromCache = JsonSerializer.Deserialize<Book>(cachedBook);
            return Ok(ServiceResult<Book>.Success(bookFromCache, 200));
        }

        var book = _bookService.GetBookById(id);
        if (book == null)
        {
            return NotFound(ServiceResult<Book>.Failure($"Book with id {id} not found.", 404));
        }

        await _cacheService.SetCacheValueAsync(cacheKey, JsonSerializer.Serialize(book), TimeSpan.FromMinutes(10));
        return Ok(ServiceResult<Book>.Success(book));
    }
    
    [HttpPost]
    public IActionResult CreateBook([FromBody] Book newBook)
    {
        if (newBook == null || string.IsNullOrWhiteSpace(newBook.Title))
        {
            return BadRequest(ServiceResult<Book>.Failure("Invalid book data.", 400));
        }

        _bookService.AddBook(newBook);
        return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, ServiceResult<Book>.Success(newBook));
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
    {
        if (updatedBook == null || string.IsNullOrWhiteSpace(updatedBook.Title))
        {
            return BadRequest(ServiceResult<Book>.Failure("Invalid book data.", 400));
        }

        var book = _bookService.UpdateBook(id, updatedBook);
        if (book == null)
        {
            return NotFound(ServiceResult<Book>.Failure($"Book with id {id} not found.", 404));
        }

        return Ok(ServiceResult<Book>.Success(book));
    }
    
    [HttpPatch("{id}")]
    public IActionResult UpdatePatchBook(int id)
    {
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var deleted = _bookService.DeleteBook(id);
        if (!deleted)
        {
            return NotFound(ServiceResult<string>.Failure($"Book with id {id} not found.", 404));
        }

        return NoContent();
    }
}