using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserDemo;

namespace MsTestMethodAnalyserProject
{
    /// UC1.1: Given message "I am in SAD mood" returns SAD
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MsgSadMood()
        {
            //Arrange
            string msg = "I am in sad mood";
            string expected = "SAD";

            MoodAnalyse mood = new MoodAnalyse(msg);
            //Act
            string actual = mood.AnalyserMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //UC 1.2: GivenAnyMoodShouldReturnHappy
        [TestMethod]
        [DataRow("I am in any mood")]
        public void GivenAnyMoodShouldReturnHappy(string message)
        {
            //arrange
            string expected = "HAPPY";
            MoodAnalyse mood = new MoodAnalyse(message);
            //Act
            string actual = mood.AnalyserMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // 2.1[NullException]
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisCustomException_IndicatingEmptyMood()
        {
            //Arrange
            string message = null;
            string excepted = "Message cann't be null";
            try
            {
                //Act
                MoodAnalyse mood = new MoodAnalyse(message);
                string actual = mood.AnalyserMethod();
            }

            catch (CustomException exception)
            {
                Assert.AreEqual("Mood Should not be empty", exception.Message);
            }
        }
    }
}

    