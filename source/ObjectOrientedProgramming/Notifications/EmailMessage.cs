namespace ObjectOrientedProgramming;

public sealed record EmailMessage(string To, string Body, string Subject) : IMessage;
