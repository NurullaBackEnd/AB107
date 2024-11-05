using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_With_List_
{
        public class NotAvailableException : Exception
        {
            public NotAvailableException(string message) : base(message) { }
        }
}
