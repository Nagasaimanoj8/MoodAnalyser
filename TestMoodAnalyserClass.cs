using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserDemo;

namespace MsTestMethodAnalyserProject
{
    [TestClass]
        public class TestMoodAnalyserClass
        {
            [TestMethod]
            public void GivenMessageReturnMood()
            {
                //Arrange
                string message = "I am in Sad mood";
                string expected = "Sad";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);

                //Act
                string actual = moodAnalyser.Mood();
                //Assert
                Assert.AreEqual(expected, actual);

            }

        }
    }
