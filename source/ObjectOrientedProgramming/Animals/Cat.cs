namespace ObjectOrientedProgramming;

public sealed record Cat() : Animal(nameof(Cat))
{
    public override string Sound() => "Meow";
}
