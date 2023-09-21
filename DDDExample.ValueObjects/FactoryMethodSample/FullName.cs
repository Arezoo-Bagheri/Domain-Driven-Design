namespace DDDExample.ValueObjects.FactoryMethodSample
{
    public class FullName : BaseValueObject<FullName>
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private FullName()
        {
        }

        public static FullName Create(string firstName, string lastName)
        {
            Validate(firstName, lastName);

            return new FullName
            {
                FirstName = firstName,
                LastName = lastName
            };
        }

        private static void Validate(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new FirstNameIsRequired();
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new LastNameIsRequired();
            }
        }

        public static FullName CreateCheckLenght(string firstName, string lastName)
        {
            CheckLenght(firstName, lastName);

            return new FullName
            {
                FirstName = firstName,
                LastName = lastName
            };
        }

        private static void CheckLenght(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new FirstNameIsRequired();
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new LastNameIsRequired();
            }

            if (firstName.Length < 2)
            {
                throw new FirstNameLengthIsInValid();
            }
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }

        protected override bool IsEqual(FullName other)
        {
            throw new NotImplementedException();
        }
    }
}
