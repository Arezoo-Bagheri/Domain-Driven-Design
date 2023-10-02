using Newtonsoft.Json;

namespace DDDExample.EventSourcing
{
    public class PersonRepository : IPersonRepository
    {

        EventDataRepositpry eventDataRepositpry = new EventDataRepositpry();

        public Person Get(int id)
        {
            var events = eventDataRepositpry.GetEventDatas(nameof(Person), id);
            Person person = new Person();
            List<IEvent> myevents = new List<IEvent>();

            foreach (var item in events)
            {
                switch (item.EventType)
                {
                    case nameof(PersonCreated):
                        PersonCreated personCreated = JsonConvert.DeserializeObject<PersonCreated>(item.EventSerializedData);
                        myevents.Add(personCreated);
                        break;

                    case nameof(PersonEmailUpdated):
                        PersonEmailUpdated personEmailUpdated = JsonConvert.DeserializeObject<PersonEmailUpdated>(item.EventSerializedData);
                        myevents.Add(personEmailUpdated);
                        break;
                }
            }

            person.LoadFromEvents(myevents);
            return person;

        }
    }

}