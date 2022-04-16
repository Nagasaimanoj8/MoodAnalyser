using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyserFactory
    {    
        public static object CreateMoodAnalyse(string className, string constructor, string message)
            {
                Type type = typeof(MoodAnalyse);
                if (type.Name.Equals(className) || type.FullName.Equals(className))
                {
                    if (type.Name.Equals(constructor))
                    {
                        return Activator.CreateInstance(type, message);
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "No such constructor found");
                    }
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "No such class found");
                }
            }
            public static Object InvokeAnalyserMethod(string className, string constructor, string message, string methodName)
            {
                //Get the instance of the MoodAnalyserClass and create a constructor
                object moodAnalysis = CreateMoodAnalyse(className, constructor, message);
                Type type = typeof(MoodAnalyse);
                try
                {
                    //Fetching the method info using reflection
                    MethodInfo methodInfo = type.GetMethod(methodName);
                    //Invoking the method of Mood Analyser Class
                    Object obj = methodInfo.Invoke(moodAnalysis, null);
                    return obj;
                }
                catch (NullReferenceException)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "method not found");
                }
            }
            public static Object ChangingTheMoodDynamically(string message, string fieldName)
            {
                // Get the type of the class
                Type type = typeof(MoodAnalyse);

                // Create an object of class
                object mood = Activator.CreateInstance(type);

                //Get the field and If the field is not found it throws null exception and if message is empty throw exception
                // catch the exception if thrown
                try
                {
                    // Get the field by using reflections
                    FieldInfo fieldInfo = type.GetField(fieldName);

                    // set the field value of a particular field in particular object
                    fieldInfo.SetValue(mood, message);

                    // Get the method using reflection
                    MethodInfo method = type.GetMethod("AnalyserMethod");

                    // Invoke the method using reflection
                    object methodReturn = method.Invoke(mood, null);
                    return methodReturn;
                }
                catch (NullReferenceException)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "No such field found");
                }
                catch
                {
                    throw new CustomException(CustomException.ExceptionType.Null_Type_Exception, "Mood should not be NULL");
                }
            }
        }
    }

