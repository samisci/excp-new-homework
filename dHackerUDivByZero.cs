using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class HackerUFormatException : Exception
    {
        public HackerUFormatException(string messege) : base(messege)
        {

        }
    }
    class HackerUIndexOutOfRangeException : Exception
    {
        public HackerUIndexOutOfRangeException(string messege) : base(messege)
        {

        }
    }
    class HackerUDivideByZeroException : Exception
    {
        public HackerUDivideByZeroException(string messege) : base(messege)
        {

        }
    }
}
