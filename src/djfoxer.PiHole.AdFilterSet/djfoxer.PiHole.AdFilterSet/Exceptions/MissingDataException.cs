﻿using System;
using System.Runtime.Serialization;

namespace djfoxer.PiHole.AdFilterSet.Exceptions
{
    [Serializable]
    public class MissingDataException : Exception
    {
        public MissingDataException()
        {
        }

        public MissingDataException(string message) : base(message)
        {
        }

        public MissingDataException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
