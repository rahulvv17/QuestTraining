using System;
using System.Runtime.Serialization;

namespace CustomExceptionExample
{
    [Serializable]
    internal class AgeOutOfRangeException : Exception
    {
        public AgeOutOfRangeException()
        {
        }

        public AgeOutOfRangeException(string message) : base(message)
        {
        }

        public AgeOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}