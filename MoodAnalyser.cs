using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        public string msg;
        public MoodAnalyser(string msg)
        {
            this.msg = msg;
        }

        public string AnalyseMood()
        {
            if (msg.ToLower().Contains("sad"))
                return "SAD";

            else
                return "HAPPY";
        }
    }
}
