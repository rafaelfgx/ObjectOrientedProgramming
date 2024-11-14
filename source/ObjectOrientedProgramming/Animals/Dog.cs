namespace ObjectOrientedProgramming;

public sealed record Dog() : Animal(nameof(Dog))
{
    public override string Sound() => "Bark";
}
