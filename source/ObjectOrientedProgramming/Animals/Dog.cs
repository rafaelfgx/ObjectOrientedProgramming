namespace ObjectOrientedProgramming;

public sealed record Dog : Animal
{
    public Dog() : base(nameof(Dog)) { }

    public override string Sound() => "Bark";
}
