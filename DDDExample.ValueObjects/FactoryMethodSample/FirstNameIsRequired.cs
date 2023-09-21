using System.Runtime.Serialization;

namespace DDDExample.ValueObjects.FactoryMethodSample
{
    [Serializable]
    internal class FirstNameIsRequired : Exception
    {
        public FirstNameIsRequired()
        {
        }

        public FirstNameIsRequired(string? message) : base(message)
        {
        }

        public FirstNameIsRequired(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FirstNameIsRequired(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}