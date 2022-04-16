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

            MoodAnalyser mood = new MoodAnalyser(msg);
            //Act
            string actual = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///UC1.2: Given message "I am in any mood" return HAPPY
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
        ///UC2.1:Handle null exception return as invalid
        [TestMethod]
        public void Handle_NullException_return_HAPPY()
        {
            //Arrange 
            string msg = null;
            MoodAnalyser mood = new MoodAnalyser(msg);
            //Act
            string expected = "HAPPY";
            string actual = mood.AnalyseMood();
            //Assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given_NullMood_Return_CustomException()
        {
            //Arrange
            string msg = null;
            string expected = "Mood should not be null";
            try
            {
                //Act
                MoodAnalyser mood = new MoodAnalyser(msg); ;
            }

            catch (CustomException exception)
            {
                //Assert
                Assert.AreEqual(expected, exception.Message);
            }
        }


    }
}
    