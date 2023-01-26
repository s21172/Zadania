using System.Runtime.Serialization;

namespace Zad3.Services
{
    [Serializable]
    internal class StudentDuplicatedException : Exception
    {
        public StudentDuplicatedException()
        {
        }

        public StudentDuplicatedException(string? message) : base(message)
        {
        }

        public StudentDuplicatedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StudentDuplicatedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}