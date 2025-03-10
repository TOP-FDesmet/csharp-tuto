using PrincipeD;

BookManager(new FileRepository());

void BookManager(IRepository repo)
{
  repo.GetAll();
}
