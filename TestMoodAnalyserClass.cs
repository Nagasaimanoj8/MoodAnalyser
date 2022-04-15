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
        


    }
}
    