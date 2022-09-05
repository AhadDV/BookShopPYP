
public interface IBookService
{
  


    public void CreateBook(Book book);
    public List<Book> FindAllVooksByName(string name);
    public List<Book> GetAllBooks();


    public void RemoveAllBooksByName(string name);


    public List<Book> SearchBooksByName(string value);



    public List<Book> FindAllBookByPageCountRange(int min, int max);



    public void Remove(string code);

}

