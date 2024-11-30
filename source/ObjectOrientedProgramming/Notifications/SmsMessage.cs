namespace ObjectOrientedProgramming;

public sealed record SmsMessage(string To, string Body) : IMessage;
