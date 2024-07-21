namespace ObjectOrientedProgramming;

public sealed record Duck : Animal
{
    public Duck() : base(nameof(Duck)) { }

    public override string Move() => "Swim";

    public override string Sound() => "Quack";
}
