using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserDemo;

namespace MsTestMethodAnalyserProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MsgSadMood()
        {
            //Arrange
            string msg = "I am in sad mood";
            string expected = "SAD";

            MoodAnalyser mood = new MoodAnalyser(msg);
            //Act
            string actual = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given_message_return_In_Any_Mood_return_Happy_message()
        {
            //Arrange
            string msg = "I am in Any Mood";
            MoodAnalyser mood = new MoodAnalyser(msg);
            //Act
            string expected = "HAPPY";
            string actual = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
    