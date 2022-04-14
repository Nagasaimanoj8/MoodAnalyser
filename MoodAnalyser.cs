using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        public string message;
        //parameterized constructor
        public MoodAnalyser (string message)
        {
            this.message = message;
        }
        //Method to return the type of Mood
        public string Mood()
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
