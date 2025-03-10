namespace PrincipeD;

public class BookRepository : IRepository
{
  private List<Book> books = [];
  public void Add(Book book)
    => books.Add(book);

  public void Delete(Book book)
    => books.Remove(book);

  public IEnumerable<Book> GetAll()
   => books;

  public Book? GetById(int id)
    => books.FirstOrDefault(b => b.Id == id);

  public Task Save()
   => Task.CompletedTask;

  public void Update(Book book)
  {
    books.RemoveAll(b => b.Id == book.Id);
    books.Add(book);
  }
}
