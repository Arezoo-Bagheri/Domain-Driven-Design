namespace DDDExample.EventSourcing
{
    public class PersonEmailUpdated : IEvent
    {
        public string Email { get; set; }
    }

}