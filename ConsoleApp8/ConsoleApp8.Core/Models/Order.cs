
public class Order
{
    public int Id { get; set; }
    public List<Book> books { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime Date { get; set; }
}
