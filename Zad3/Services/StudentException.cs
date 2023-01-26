using System.Runtime.Serialization;

namespace Zad3.Services
{
    [Serializable]
    internal class StudentException : Exception
    {
        public StudentException()
        {
        }

        public StudentException(string? message) : base(message)
        {
        }

        public StudentException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StudentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}