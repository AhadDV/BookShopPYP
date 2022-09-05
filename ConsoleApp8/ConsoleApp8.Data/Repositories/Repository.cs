
using System.Linq;
using System.Linq.Expressions;

public class Repository<T> : IRepository<T> where T : class
{
    public List<T> Table { get; set; }=new List<T>();

    public void Add(T entity)
    {
        Table.Add(entity);
    }

    public List<T> GetAll()
    {
       return Table;
    }

    public IEnumerable<T> GetAll(Func<T, bool> expression)
    {
        IEnumerable<T> result = Table.Where<T>(expression);
     
        return result;
    }

    public T GetById(Func<T, bool> expression)
    {
       var data=Table.FirstOrDefault(expression);
        return data;
        
    }

    public void Remove(T Entity)
    {
       Table.Remove(Entity);
    }

    public void RemoveRange(List<T> Entity)
    {
        Entity.ForEach(x => Table.Remove(x));
    }
}

