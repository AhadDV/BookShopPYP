
public class Book:BaseEntity
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCOunt { get; set; }
    public decimal Price { get; set; }
    public string Code { get; set; }

    public Book(string name, string authorName, int pageCOunt)
    {
        ;
        Name = name;
        AuthorName = authorName;
        PageCOunt = pageCOunt;
        Code = $"{Name.Substring(0,2)}{Id}";
    }

    public override string ToString()
    {
        return $"{Name},{AuthorName}{PageCOunt}{Code}";
    }
}
