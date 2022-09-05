public class BaseEntity
{
    public static int Id { get; set; }

    public BaseEntity()
    {
        Id += 1;
    }
}
