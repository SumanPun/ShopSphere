namespace EventBus.Messages.Events
{
    public class BaseIntegrationEvent
    {
        public string CorrelationId { get; set; }
        public DateTime CreationTime { get; private set; }
        public BaseIntegrationEvent()
        {
            CorrelationId = Guid.NewGuid().ToString();
            CreationTime = DateTime.UtcNow;
        }
        public BaseIntegrationEvent(Guid correlationId, DateTime creationDate)
        {
            CorrelationId = correlationId.ToString();
            CreationTime = creationDate;
        }
    }
}
