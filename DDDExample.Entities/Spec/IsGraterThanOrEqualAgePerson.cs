namespace DDDExample.Entities.Spec
{
    public class IsGraterThanOrEqualAgePerson : ISpecification<Person>
    {

        private readonly int minValidDate;

        public IsGraterThanOrEqualAgePerson(int minValidDate)
        {
            this.minValidDate = minValidDate;
        }

        public bool IsSatisfiedBy(Person entity)
        {
            var age = (DateTime.Now - entity.BirthDate).TotalDays % 365;
            return age >= minValidDate;
        }

    }
}
