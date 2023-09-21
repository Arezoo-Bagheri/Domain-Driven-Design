using System.Runtime.Serialization;

namespace DDDExample.ValueObjects.FactoryMethodSample
{
    [Serializable]
    internal class LastNameIsRequired : Exception
    {
        public LastNameIsRequired()
        {
        }

        public LastNameIsRequired(string? message) : base(message)
        {
        }

        public LastNameIsRequired(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LastNameIsRequired(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}