using System.Runtime.Serialization;

namespace DDDExample.ValueObjects.FactoryMethodSample
{
    [Serializable]
    internal class FirstNameLengthIsInValid : Exception
    {
        public FirstNameLengthIsInValid()
        {
        }

        public FirstNameLengthIsInValid(string? message) : base(message)
        {
        }

        public FirstNameLengthIsInValid(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FirstNameLengthIsInValid(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}