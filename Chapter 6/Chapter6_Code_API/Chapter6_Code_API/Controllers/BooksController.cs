using Microsoft.AspNetCore.Mvc;

namespace Chapter6_Code_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        // Simulating an in-memory database
        private static readonly List<Book> Books = new List<Book>
    {
        new Book { Id = 1, Title = "1984", Author = "George Orwell", Genre = "Dystopia" },
        new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Historical Fiction" },        
    };

        // List all books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return Books;
        }

        // Get a specific book by ID
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        // Add a new book
        [HttpPost]
        public ActionResult<Book> AddBook([FromBody] Book book)
        {            
            Books.Add(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        // Update a book
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Genre = updatedBook.Genre;
            return NoContent();
        }

        // Delete a book
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            Books.Remove(book);
            return NoContent();
        }
    }

}
