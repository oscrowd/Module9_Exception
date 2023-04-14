using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    public class MyException : Exception
    {
        public MyException()
        { }

        public MyException(string message) : base(message)
        { }

    }

    public class ExceptionMessage : MyException
    {
        public ExceptionMessage(string _exceptionMessage) : base(_exceptionMessage) 
        { 
        
        }
    }

}
