using System;
using System.Data.SqlClient;

namespace UABNotas
{
    public class DatabaseException : Exception
    {
        public DatabaseException() { }

        public DatabaseException(string message)
            : base(message) { }

        public DatabaseException(string message, Exception inner)
            : base(message, inner) { }
    }
}
