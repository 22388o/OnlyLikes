namespace Events;

public class Message
{
    public string? Type { get; set; }
    public string? SubscriptionId { get; set; }
    public string? Payload { get; set; }
}