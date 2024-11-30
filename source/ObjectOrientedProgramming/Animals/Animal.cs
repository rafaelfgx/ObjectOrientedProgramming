namespace ObjectOrientedProgramming;

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
