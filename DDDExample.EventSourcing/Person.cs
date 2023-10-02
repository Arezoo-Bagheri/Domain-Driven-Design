namespace DDDExample.EventSourcing
{
    public class Person : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public void LoadFromEvents(List<IEvent> list)
        {
            foreach (var item in list)
            {
                switch (item.GetType().Name)
                {
                    case "PersonCreated":
                        LoadCreattion(item as PersonCreated);
                        break;

                    case "PersonEmailUpdated":
                        LoadEmailChanged(item as PersonEmailUpdated);
                        break;
                }
            }
        }

        private void LoadCreattion(PersonCreated personCreated)
        {
            Id = personCreated.Id;
            FirstName = personCreated.FirstName;
            LastName = personCreated.LastName;
            Email = personCreated.Email;
        }

        private void LoadEmailChanged(PersonEmailUpdated emailUpdated)
        {
            Email = emailUpdated.Email;
        }

    }

}