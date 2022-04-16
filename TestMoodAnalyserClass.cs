﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
<<<<<<< HEAD
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
        ///UC3.1:Given null mood throw custom exception
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
        ///UC3.2: Given Empty Mood throw custom exception
        [TestMethod]
        public void Given_EmptyMood_Return_CustomException()
        {
            //Arrange
            string msg = " ";
            string expected = "Mood should not be empty";
            try
            {
                //Act
                MoodAnalyser mood = new MoodAnalyser(msg);
            }
            catch (CustomException exception)
            {
                //Assert
                Assert.AreEqual(expected, exception.Message);
            }
        }
        [TestMethod]
        public void GivenMoodAnalyserReflection_ShouldReturnObject()
        {
            //Arrange
            string msg = "null";
            object expected = new MoodAnalyser(msg);
            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyse", "MoodAnalyser");
            //Assert
            expected.Equals(obj);
        }
        /// TC-4.2 should throw NO_SUCH_CLASS exception.
        [TestMethod]
        public void GivenClassNameImproper_ShouldReturnMoodAnalysisException()
        {
            //Arrange
            string expected = "Class not found";
            try
            {
                //Act
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("Mood.AnalyzeMood", "AnalyzeMood");
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// TC-4.3 should throw NO_SUCH_CONTRUCTOR exception.
        [TestMethod]
        public void GivenConstructorNameImproper_ShouldReturnMoodAnalysisException()
        {
            //Arrange
            string expected = "Constructor not found";
            try
            {
                //Act
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzer.AnalyzeMood", "MoodAnalyzer");
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// TC-5.1 Returns the mood analyser object with parameterized constructor.
        [TestMethod]
        [TestCategory("Reflection")]
        public void GivenMoodAnalyserParameterizedConstructor_ShouldReturnObject()
        {
            //Arrange
            object expected = new MoodAnalyser("I am Parameter constructor");
            //Act
            object actual = MoodAnalyserFactory.MoodAnalyserParameterisedConstructor("MoodAnalyzer.AnalyzeMood", "AnalyzeMood", "I am Parameter constructor");
            //Assert
            expected.Equals(actual);
        }
        /// TC-5.2 should throw NO_SUCH_CLASS exception with parameterized constructor.
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        public void GivenClassNameImproperParameterizedConstructor_ShouldReturnMoodAnalysisException()
        {
            //Arrange
            string expected = "Class not found";
            try
            {
                //Act
                object actual = MoodAnalyserFactory.MoodAnalyserParameterisedConstructor("MoodAnalyser.AnalyzeMood", "AnalyzeMood", "I am Parameter constructor");
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// TC-5.3 should throw NO_SUCH_CONSTRUCTOR exception with parameterized constructor.
        [TestMethod]
        [TestCategory("Reflection")]
        public void GivenImproperParameterizedConstructorName_ShouldReturnMoodAnalysisException()
        {
            //Assert
            string expected = "Constructor not found";
            try
            {
                //Act
                object actual = MoodAnalyserFactory.MoodAnalyserParameterisedConstructor("MoodAnalyzer.AnalyzeMood", "AnalyzeMod", "I am Parameter constructor");
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
=======
>>>>>>> TC1.1_IAmInSadModdMesaageShouldReturnSad
    }
}

    