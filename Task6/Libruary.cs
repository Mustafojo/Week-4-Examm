public class Libruary : ILibruary
{
    List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public List<Book> DisplayBook()
    {
        
        return books;
    }
    public void UpdateBook(Book book)
    {
        foreach (var item in books)
        {
            if (item.Id == book.Id)
            {
                
                item.Tittle = book.Tittle;
                item.Author = book.Author;
                System.Console.WriteLine("----------------------------------------------");
                System.Console.WriteLine("Book was updated successfully!");
                break;
            }
            System.Console.WriteLine("Book not found!");
            break;
        }

    }
    public void DeleteBook(int id)
    {
        foreach (var i in books)
        {
            if (i.Id == id)
            {
                books.Remove(i);
                System.Console.WriteLine("----------------------------------------------");
                System.Console.WriteLine("Book deleted successfully!");
                break;
            }
            System.Console.WriteLine("Book not found!");
            break;

        }
    }
    public Book SearchByTittle(string tittle)
    {
        var book = books.FirstOrDefault(e => e.Tittle == tittle);
        {
            return book;
        }
    }
    public Book SearchByAuthor(string author)
    {
        var book = books.FirstOrDefault(e => e.Author == author);
        {
            return book;
        }
    }
}




