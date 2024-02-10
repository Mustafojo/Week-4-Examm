try
{
    var book1 = new Book();
    book1.Id = 1;
    book1.Tittle = "Barotov";
    book1.Author = "Mustafo";

    var book2 = new Book();
    book2.Id = 2;
    book2.Tittle = "Rumi";
    book2.Author = "Sherozi";

    var book3 = new Book();
    book3.Id = 3;
    book3.Tittle = "Sadi";
    book3.Author = "Rudaki";


    var libruary = new Libruary();
    libruary.AddBook(book1);
    libruary.AddBook(book2);
    libruary.AddBook(book3);

    foreach (var item in libruary.DisplayBook())
    {
        Console.WriteLine("Id : " + item.Id);
        Console.WriteLine("Author : " + item.Author);
        Console.WriteLine("Tittle : " + item.Tittle);
    }
    var updatedbook = new Book();
    updatedbook.Id = 1;
    updatedbook.Tittle = "Salom";
    updatedbook.Author = "Aleck";
    libruary.UpdateBook(updatedbook);

    foreach (var item in libruary.DisplayBook())
    {
        Console.WriteLine("Id : " + item.Id);
        Console.WriteLine("Author : " + item.Author);
        Console.WriteLine("Tittle : " + item.Tittle);
    }


    libruary.DeleteBook(1);
    foreach (var item in libruary.DisplayBook())
    {
        Console.WriteLine("Id : " + item.Id);
        Console.WriteLine("Author : " + item.Author);
        Console.WriteLine("Tittle : " + item.Tittle);
    }
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Search by Author : " + libruary.SearchByAuthor("Sherozi").Tittle);

    Console.WriteLine("Search by Tittle : " + libruary.SearchByTittle("Sadi").Author);

}
catch
{
    Console.WriteLine("Hatogiro isloh kuned ! ");
}
