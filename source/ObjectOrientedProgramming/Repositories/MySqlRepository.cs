namespace ObjectOrientedProgramming;

public abstract class MySqlRepository<T> : IRepository<T>
{
    public void Insert(T entity) { }

    public IEnumerable<T> List() => new List<T>();

    public T Select(int id) => default;

    public void Update(T entity) { }
}
