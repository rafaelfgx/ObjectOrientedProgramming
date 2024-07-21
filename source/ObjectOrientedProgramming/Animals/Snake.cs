namespace ObjectOrientedProgramming;

public sealed record Snake : Animal
{
    public Snake() : base(nameof(Snake)) { }

    public override string Sound() => "Hiss";
}
