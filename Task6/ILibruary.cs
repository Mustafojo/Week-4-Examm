public interface ILibruary
{
    public void AddBook(Book book);
    public List<Book> DisplayBook();
    public void UpdateBook(Book book);
    public void DeleteBook(int id);
    public Book SearchByTittle(string tittle);
    public Book SearchByAuthor(string author);

}