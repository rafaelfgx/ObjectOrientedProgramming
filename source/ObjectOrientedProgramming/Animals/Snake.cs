namespace ObjectOrientedProgramming;

public sealed record Snake() : Animal(nameof(Snake))
{
    public override string Sound() => "Hiss";
}
