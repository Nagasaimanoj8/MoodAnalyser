using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoodAnalyserDemo
{
    public class MoodAnalyse
    {
        private string message;


        public MoodAnalyse(string message)
        {
            this.message = message;
            Console.WriteLine("parameterised constructor");
            Console.WriteLine(message);
        }
        public MoodAnalyse()
        {
            this.message = null;
            Console.WriteLine("default constructor");
        }
        public string AnalyserMethod()
        {
            try
            {
                if (!String.IsNullOrEmpty(message))
                {
                    if (message.ToUpper().Contains("SAD"))
                        return "SAD";
                    else if (message.ToUpper().Contains("HAPPY") || message.ToUpper().Contains("ANY"))
                        return "HAPPY";
                    else
                        return "HAPPY";
                }
                else if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.Empty_Type_Exception, "mood should not be empty");
                }
                else
                    throw new NullReferenceException();

            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.Null_Type_Exception, "Mood Should not be NULL");
            }
        }

    }
}
