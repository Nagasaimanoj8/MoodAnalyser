using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Mood Analyser Program");
            MoodAnalyser moodAnalyser = new MoodAnalyser("Happy");
            Console.WriteLine(moodAnalyser.Mood()); 
            Console.ReadLine();

        }
    }
}

