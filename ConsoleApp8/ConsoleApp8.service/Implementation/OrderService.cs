
public class OrderService : IOrderService
{
    private readonly BookRepository _bookRepository;
    private readonly OrderRepository _orderRepository;
    public OrderService(BookRepository bookRepository, OrderRepository orderRepository)
    {
        _bookRepository = bookRepository;
        _orderRepository = orderRepository;
    }
    public Order Sale(List<string> bookCodes)
    {
        Order order = new Order();
        foreach (string code in bookCodes)
        {
            order.books.Add(_bookRepository.GetById(x => x.Code == code));
        }
        decimal totalPrice = order.books.Sum(b => b.Price);
      
        order.TotalPrice=Discount(totalPrice);
        _orderRepository.Add(order);
        return order;
    }


    private decimal Discount(decimal totalPrice)
    {
        if(totalPrice>=200)
            return totalPrice- (totalPrice * 2)/10;
        else if(totalPrice>=100)
            return totalPrice-(totalPrice/10);
        else 
            return totalPrice;
    }
}
