using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlMultiScript.Class
{
    public class ExceptionOperations:ApplicationException
    {
        public ExceptionOperations() : base() { }
        public ExceptionOperations(string str) : base(str) { }

        public override string ToString()
        {
            return Message;
        }
    }
}
