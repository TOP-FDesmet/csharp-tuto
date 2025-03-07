using PrincipeI;

DisplayAllBooks(new BookRepository());

void DisplayAllBooks(IReadRepository repo)
{
  var books = repo.GetAll();
  foreach (var book in books)
  {
    Console.WriteLine(book.Title);
  }
}
