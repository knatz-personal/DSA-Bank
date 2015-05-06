using System;
using System.Runtime.Serialization;

namespace DSABusinessServices.CustomExceptions
{
        [Serializable]
    public class DataListException : Exception
    {
        public DataListException()
            : base("Failed to load list.")
        {
        }

        public DataListException(string message)
            : base(message)
        {
        }

        public DataListException(string message, Exception inner) :
            base(message, inner)
        {
        }

        public DataListException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}