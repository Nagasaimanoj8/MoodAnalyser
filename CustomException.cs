using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
      public class CustomException:Exception
        {
            public ExceptionType type;

            public enum ExceptionType
            {
             Null_Type_Exception,
            Empty_Type_Exception,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS
        }
            public CustomException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
    }

