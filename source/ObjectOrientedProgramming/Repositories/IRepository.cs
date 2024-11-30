namespace ObjectOrientedProgramming;

public interface IRepository<T>
{
    void Insert(T entity);

    IEnumerable<T> List();

    T Select(int id);

    void Update(T entity);
}
