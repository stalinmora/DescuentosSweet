using System;
using System.Data.Entity.Core;
using System.Runtime.Serialization;

namespace DescuentosSweet.Data
{
    [Serializable]
    internal class ConnectionFailedException : Exception
    {
        private EntityException ex;

        public ConnectionFailedException()
        {
        }

        public ConnectionFailedException(EntityException ex)
        {
            this.ex = ex;
        }

        public ConnectionFailedException(string message) : base(message)
        {
        }

        public ConnectionFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConnectionFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}