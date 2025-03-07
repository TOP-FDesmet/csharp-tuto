namespace PrincipeI;

public interface IWriteRepository
{
  void Add(Book book);
  void Update(Book book);
  void Delete(Book book);
  Task Save();

}
