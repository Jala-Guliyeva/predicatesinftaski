using System;
using System.Collections.Generic;
using System.Text;

namespace Sinf_taski_3._29.Exceptions
{
    internal class EmployeeAlreadyExistsException:Exception
    {
        public EmployeeAlreadyExistsException(string message) : base(message)
        {
            Console.WriteLine("boshdur");
        }
    }
}
