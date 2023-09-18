using Microsoft.AspNetCore.Mvc;

namespace Chapter6_Code_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        // Simulando una base de datos en memoria
        private static readonly List<Book> Books = new List<Book>
    {
        new Book { Id = 1, Title = "1984", Author = "George Orwell", Genre = "Dystopia" },
        new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Historical Fiction" },
        // ... puedes añadir más libros para la demo
    };

        // Listar todos los libros
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return Books;
        }

        // Obtener un libro específico por ID
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

        // Añadir un nuevo libro
        [HttpPost]
        public ActionResult<Book> AddBook([FromBody] Book book)
        {
            // En una aplicación real, deberías asegurarte de que el ID es único, y probablemente lo generaría una base de datos.
            Books.Add(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        // Actualizar un libro
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

        // Eliminar un libro
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
