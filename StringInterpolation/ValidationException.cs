using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    public class ValidationException : Exception
    {
        public List<String> Exceptions { get; private set; }
        public ValidationException(List<String> exceptions)
        {
            Exceptions = exceptions;
        }
    }
}
