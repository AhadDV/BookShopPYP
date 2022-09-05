
public class BookService
{
   
    BookRepository books = new BookRepository ();

    public void CreateBook(Book book) => books.Add(book);
    public List<Book> GetAll() => books.GetAll();
    public List<Book> FindAllVooksByName(string name)
    => books.GetAll(x=>x.Name==name).ToList();

    public void RemoveAllBooksByName(string name)
    {
        Book book = books.GetById(x => x.Name == name);
        if (book != null)
            books.Remove(book);
        else throw new Exception("Item not found");
    }

    public List<Book> SearchBooksByName(string value)
      =>books.GetAll(x=>x.Name==value).ToList();


    public void FindAllBookByPageCountRange(int min, int max)
     => books.GetAll(x => x.PageCOunt > min && x.PageCOunt < max);
       

    public void Remove(string code)
    {
        Book book = books.GetById(x => x.Code == code);
        if (code == null)
            throw new Exception("item not found");
        else
            books.Remove(book);
    }
     







}

