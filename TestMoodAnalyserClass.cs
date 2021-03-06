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
                Console.WriteLine("Custom Exception :" + exception);
                Assert.AreEqual(excepted, exception.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Worst Case Exception :" + ex);
            }
        }
        //3.1: Given_Null_Mood_Should_Throw_MoodAnalysisCustomException_IndicatingNullMood
        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisCustomException_IndicatingNullMood()
        {//Arrange
            string message = null;
            try
            {
                //Act
                MoodAnalyse mood = new MoodAnalyse(message);
                string actual = mood.AnalyserMethod();
            }

            catch (CustomException exception)
            {
                //Assert
                Assert.AreEqual("Mood Should not be NULL", exception.Message);
            }
        }
        //3.2GivenMoodAnalyserClass_ShouldReturn_MoodAnalyserObject
        [TestMethod]
        [TestCategory("Empty Exception")]
        public void GivenEmptyShouldReturnCustomException()
        {
            
            ///Arrange 
            string message = "";
            string excepted = "Message cann't be Empty";
            try
            {
                //Act
                MoodAnalyse mood = new MoodAnalyse(message);
                string actual = mood.AnalyserMethod();
            }
            catch (CustomException ex)
            {
                //Addert
                Console.WriteLine("Custom Exception :" + ex);
                Assert.AreEqual(excepted, ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Worst Case Exception :" + ex);
            }
        }
        //Test Case 4.1 to match both class name and constructor name
        [TestMethod]
        public void CreateObjectOfMoodAnalyserClass()
        {
            //Arrange
            MoodAnalyse mood = new MoodAnalyse();
            //Act
            var objectFromFactory = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyse", "MoodAnalyse", null);
            //Assert
            objectFromFactory.Equals(mood);

        }
        //Test Case 4.2 To return exception when wrong class name is passed
        [TestMethod]
        public void CreateObjectOfMoodAnalyserClassWithWrongClassName()
        {
            //Arrange
            MoodAnalyse mood = new MoodAnalyse();
            //Act
            try
            {
                var objectFromFactory = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyseWrong", "MoodAnalyse", null);
            }
            //Assert
            catch (CustomException exception)
            {
                Assert.AreEqual("No such class found", exception.Message);
            }

        }
        //Test Case 4.3 To return exception for wrong constructor name
        [TestMethod]
        public void CreateObjectOfMoodAnalyserClassWithWrongConstructor()
        {
            //Arrange
            MoodAnalyse mood = new MoodAnalyse();
            //Act
            try
            {
                var objectFromFactory = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyse", "MoodAnalyseWrong", null);
            }
            //Assert
            catch (CustomException exception)
            {
                Assert.AreEqual("No such constructor found", exception.Message);
            }
        }
        //TC_5.1 - Given MoodAnalyser when proper message pass to Parameterized constructor then return mood analyser object
        [TestMethod]
        public void CreateParameterizedObjectOfMoodAnalyserClass()
        {
            //Arrange

            MoodAnalyse mood = new MoodAnalyse();
            //Act
            var obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyse", "MoodAnalyse", "HAPPY");
            //Assert
            obj.Equals(mood);
        }
        //TC 5.2 When a wrong class name is passed then throw exception
        [TestMethod]
        public void CreateParameterizedObjectOfMoodAnalyseInvalidClassName()
        {
            //Arrange
            MoodAnalyse mood = new MoodAnalyse();

            //Act
            try
            {
                var obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyseWrong", "MoodAnalyse", "HAPPY");
            }
            //Assert
            catch (CustomException exception)
            {
                Assert.AreEqual("No such class found", exception.Message);
            }

        }
        //TC 5.3 When a wrong costructor name is passed then throw an exception
        [TestMethod]
        public void CreateParameterizedObjectOfMoodAnalyseInvalidConstructor()
        {
            //Arrange
            MoodAnalyse mood = new MoodAnalyse();

            //Act
            try
            {
                var obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyse", "MoodAnalyseWrong", "HAPPY");
            }
            //Assert
            catch (CustomException exception)
            {
                Assert.AreEqual("No such constructor found", exception.Message);
            }
        }
        [TestMethod]
        //TC 6.1 : Given 'Happy' message when proper should return 'Happy Mood'.

        public void GivenHappyMessage_InvokeAnalyseMoodMethod_ShouldReturnHappyMoodMessage()
        {
            //arrange
            MoodAnalyse mood = new MoodAnalyse("I am in happy mood");

            //Act
            object actual = MoodAnalyserFactory.InvokeAnalyserMethod("MoodAnalyser.MoodAnalyse", "MoodAnalyse", "i am in happy mood", "AnalyserMethod");
            //Assert
            Assert.AreEqual("HAPPY", actual);
        }
        [TestMethod]

        //TC 6.2 : Given Improper method name must return mood analyser custom exception
        public void GivenHappyMessage_WhenImproperMethod_ShouldThrowMoodAnalysisException()
        {
            //Act
            try
            {
                MoodAnalyse mood = new MoodAnalyse("I am in happy mood");
                object expected = mood.AnalyserMethod();
                object actual = MoodAnalyserFactory.InvokeAnalyserMethod("MoodAnalyser.MoodAnalyse", "MoodAnalyse", "i am in happy mood", "InvalidMethod");
            }
            catch (CustomException exception)
            {
                //Assert
                Assert.AreEqual("method not found", exception.Message);
            }
        }
    }
}
        

    