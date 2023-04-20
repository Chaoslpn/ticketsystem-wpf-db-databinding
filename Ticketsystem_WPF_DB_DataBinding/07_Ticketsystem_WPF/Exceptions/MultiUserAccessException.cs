using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ticketsystem_WPF.Exceptions
{
    public class MultiUserAccessException : Exception
    {
        public MultiUserAccessException(string msg) : base(msg)
        {
        }

        public MultiUserAccessException()
        {
        }
    }
}
