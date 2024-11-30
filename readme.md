# Object-Oriented Programming

## Pillars

### Abstraction

Abstraction is to turn real world objects, properties, and behaviors into a computational representation.

### Encapsulation

Encapsulation is to protect internal properties and behaviors of an object from being manipulated externally.

### Inheritance

Inheritance is to reuse properties and behaviors of a base class by a derived class.

### Polymorphism

Polymorphism is the ability of an object to assume and be used as other forms.

## Examples

### Animal

```cs
public abstract record Animal(string Name)
{
    public bool Sleeping { get; private set; }

    public string Drink() => "Drink";

    public string Eat() => "Eat";

    public virtual string Move() => "Move";

    public abstract string Sound();

    public void Awake() => Sleeping = false;

    public void Sleep() => Sleeping = true;
}
```

```cs
public sealed record Cat() : Animal(nameof(Cat))
{
    public override string Sound() => "Meow";
}
```

```cs
public sealed record Dog() : Animal(nameof(Dog))
{
    public override string Sound() => "Bark";
}
```

```cs
public sealed record Duck() : Animal(nameof(Duck))
{
    public override string Move() => "Swim";

    public override string Sound() => "Quack";
}
```

```cs
public sealed record Eagle() : Animal(nameof(Eagle))
{
    public override string Move() => "Fly";

    public override string Sound() => "Screech";
}
```

```cs
public sealed record Lion() : Animal(nameof(Lion))
{
    public override string Sound() => "Roar";
}
```

```cs
public sealed record Snake() : Animal(nameof(Snake))
{
    public override string Sound() => "Hiss";
}
```

### Notification

```cs
public interface IMessage;
```

```cs
public sealed record EmailMessage(string To, string Body, string Subject) : IMessage;
```

```cs
public sealed record SmsMessage(string To, string Body) : IMessage;
```

```cs
public interface INotification<in TMessage> where TMessage : IMessage
{
    void Notify(TMessage message);
}
```

```cs
public sealed class EmailNotification : INotification<EmailMessage>
{
    public void Notify(EmailMessage message) => Console.WriteLine(nameof(EmailNotification));
}
```

```cs
public sealed class SmsNotification : INotification<SmsMessage>
{
    public void Notify(SmsMessage message) => Console.WriteLine(nameof(SmsNotification));
}
```

### Payment

```cs
public interface IPayment
{
    void Pay(decimal value);
}
```

```cs
public sealed class Cash : IPayment
{
    public void Pay(decimal value) => Console.WriteLine(nameof(Cash));
}
```

```cs
public sealed class CreditCard : IPayment
{
    public void Pay(decimal value) => Console.WriteLine(nameof(CreditCard));
}
```

```cs
public sealed class DebitCard : IPayment
{
    public void Pay(decimal value) => Console.WriteLine(nameof(DebitCard));
}
```

```cs
public sealed class PaymentService(IPayment payment)
{
    public void Pay(decimal value) => payment.Pay(value);
}
```

### Repositories

```cs
public interface IRepository<T>
{
    void Insert(T entity);

    IEnumerable<T> List();

    T Select(int id);

    void Update(T entity);
}
```

```cs
public abstract class MySqlRepository<T> : IRepository<T>
{
    public void Insert(T entity) { }

    public IEnumerable<T> List() => new List<T>();

    public T Select(int id) => default;

    public void Update(T entity) { }
}
```

```cs
public abstract class SqlServerRepository<T> : IRepository<T>
{
    public void Insert(T entity) { }

    public IEnumerable<T> List() => new List<T>();

    public T Select(int id) => default;

    public void Update(T entity) { }
}
```
