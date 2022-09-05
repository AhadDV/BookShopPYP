
using System.Linq.Expressions;

public interface IRepository<T>
{
    List<T> Table { get; set; }
    public void Add(T entity);
    public List<T> GetAll();
    public IEnumerable<T> GetAll(Func<T,bool>expression);
    public T GetById(Func<T, bool> expression);
    public void RemoveRange(List<T> Entity);
    public void Remove(T Entity);
    
    
}

