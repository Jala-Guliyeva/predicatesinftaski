using System;
using System.Collections.Generic;
using System.Text;

namespace Sinf_taski_3._29.Exceptions
{
    internal class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message) : base(message)
        {
            Console.WriteLine("Limit doldu");
        }
    }
}
