using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    [Serializable]
    public class SubtractionNegativeErrorException : Exception
    {
        public SubtractionNegativeErrorException() 
            :base()
        {
            // Add implementation.
        }
        public SubtractionNegativeErrorException(string message)
            : base(message)
        {
            // Add implementation.
        }
        public SubtractionNegativeErrorException(string message, Exception innerException)
             : base(message, innerException) 
        {
            // Add implementation.
        }

        // This constructor is needed for serialization.
        protected SubtractionNegativeErrorException(SerializationInfo info, StreamingContext context)
             : base(info, context)
        {
            // Add implementation.
        }
    }
}
