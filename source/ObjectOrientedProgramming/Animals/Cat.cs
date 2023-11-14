namespace ObjectOrientedProgramming;

public sealed record Cat : Animal
{
    public Cat() : base(nameof(Cat)) { }

    public override string Sound() => "Meow";
}
