using System;
using System.Runtime.Serialization;

namespace UABNotas
{

    [Serializable]
    internal class ExceptionDataBase : Exception
    {
        public ExceptionDataBase()
        {
        }

        public ExceptionDataBase(string message) : base(message)
        {
        }

        public ExceptionDataBase(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionDataBase(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }


}
