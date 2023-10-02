using Newtonsoft.Json;

namespace DDDExample.EventSourcing
{
    public class EventDataRepositpry
    {
        private readonly List<EventData> eventDatas = new List<EventData>();

        public EventDataRepositpry()
        {
            eventDatas.Add(new EventData
            {
                EventDataId = 1,
                EntityType = nameof(Person),
                EventType = nameof(PersonCreated),
                EntityId = 1,
                EventSerializedData = JsonConvert.SerializeObject(new PersonCreated
                {
                    Email = "RL@gmail.com",
                    FirstName = "Rahim",
                    LastName = "Lotfi",
                    Id = 1
                })
            });

            eventDatas.Add(new EventData
            {
                EventDataId = 2,
                EntityType = nameof(Person),
                EventType = nameof(PersonEmailUpdated),
                EntityId = 1,
                EventSerializedData = JsonConvert.SerializeObject(new PersonEmailUpdated
                {
                    Email = "Lotfi@gmail.com"
                })
            });

            eventDatas.Add(new EventData
            {
                EventDataId = 3,
                EntityType = nameof(Person),
                EventType = nameof(PersonCreated),
                EntityId = 2,
                EventSerializedData = JsonConvert.SerializeObject(new PersonCreated
                {
                    Email = "Arezoo@gmail.com",
                    FirstName = "Arezoo",
                    LastName = "Bagheri",
                    Id = 2
                })
            });

            eventDatas.Add(new EventData
            {
                EventDataId = 4,
                EntityType = nameof(Person),
                EventType = nameof(PersonEmailUpdated),
                EntityId = 1,
                EventSerializedData = JsonConvert.SerializeObject(new PersonEmailUpdated
                {
                    Email = "RahimLotfi@gmail.com"
                })
            });

        }

        public List<EventData> GetEventDatas(string entityType, int entityId)
        {
            List<EventData> result = eventDatas.
                            Where(c => c.EntityType == entityType && c.EntityId == entityId).
                            ToList();

            return result;
        }
    }

}