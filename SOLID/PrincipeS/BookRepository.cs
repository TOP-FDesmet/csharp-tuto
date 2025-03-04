using System.Text.Json;

namespace PrincipeS;

public class BookRepository
{
  public async Task SaveToFile(Book book)
  {
    await File.WriteAllTextAsync(
      $"./book-{book.Title}.json", JsonSerializer.Serialize(book,
        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
      ));
  }
}
