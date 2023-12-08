using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HW_Classes
{
    public class PopEmptyArrayException : Exception
    {
        public PopEmptyArrayException(string message) : base(message)
        {
        }
    }
}
