namespace PrincipeD;

public interface IReadRepository
{
  Book? GetById(int id);

  IEnumerable<Book> GetAll();

}
