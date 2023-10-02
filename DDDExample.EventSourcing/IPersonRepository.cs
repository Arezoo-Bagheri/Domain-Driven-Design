namespace DDDExample.EventSourcing
{
    public interface IPersonRepository
    {
        Person Get(int id);
    }

}