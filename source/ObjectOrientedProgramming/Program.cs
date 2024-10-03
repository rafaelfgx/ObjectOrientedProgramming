namespace ObjectOrientedProgramming;

public static class Program
{
    private static IEnumerable<Animal> Animals => new List<Animal> { new Cat(), new Dog(), new Duck(), new Eagle(), new Lion(), new Snake() };

    public static void Main()
    {
        Abstraction();
        Encapsulation();
        Polymorphism();
        DependencyInjection();
        Console.ReadKey();
    }

    private static void Abstraction()
    {
        Console.WriteLine(nameof(Abstraction).ToUpper());

        IEntityRepository repository = new EntitySqlServerRepository();

        Console.WriteLine(repository.GetType().Name);

        repository = new EntityMySqlRepository();

        Console.WriteLine(repository.GetType().Name);

        Console.WriteLine();
    }

    private static void DependencyInjection()
    {
        Console.WriteLine(nameof(DependencyInjection).ToUpper());

        new PaymentService(new Cash()).Pay(1000);
        new EmailNotification().Notify(new EmailMessage("To", "Subject", "Body"));
        new SmsNotification().Notify(new SmsMessage("Number", "Body"));

        new PaymentService(new CreditCard()).Pay(1000);
        new SmsNotification().Notify(new SmsMessage("Number", "Body"));

        new PaymentService(new CreditCard()).Pay(2000);
        new EmailNotification().Notify(new EmailMessage("To", "Subject", "Body"));

        new PaymentService(new DebitCard()).Pay(1000);
        new SmsNotification().Notify(new SmsMessage("Number", "Body"));

        Console.WriteLine();
    }

    private static void Encapsulation()
    {
        Console.WriteLine(nameof(Encapsulation).ToUpper());

        foreach (var animal in Animals)
        {
            Console.WriteLine($"Animal: {animal.Name}");

            animal.Awake();
            Console.WriteLine($"Sleeping: {animal.Sleeping}");

            animal.Sleep();
            Console.WriteLine($"Sleeping: {animal.Sleeping}");

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    private static void Polymorphism()
    {
        Console.WriteLine(nameof(Polymorphism).ToUpper());

        foreach (var animal in Animals)
        {
            Console.WriteLine($"Animal: {animal.Name}");
            Console.WriteLine($"Move: {animal.Move()}");
            Console.WriteLine($"Sound: {animal.Sound()}");
            Console.WriteLine();
        }
    }
}
