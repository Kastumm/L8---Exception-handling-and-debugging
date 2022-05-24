#define GOODBYE
using System;

namespace LessonL8
{
    public sealed class Rupor //Sealed class - can not be inherited, but can be instantiated
    {
        public string user = "K";
        public string Hello = "Hello!";
        public string ChristmasHello = $"Merry Christmas!!!";
    }
    public static class LessonL8
    {
        public static void Main(string[] args)
        {
#if HELLO
            Console.WriteLine("Hello");
#endif
#if GOODBYE
            Console.WriteLine("Good Bye!");
#else
            Console.WriteLine("I am still here!");
#endif
        }
    }

    public sealed class Zero 
    {
        public int a = 5;
        public int b = 0;

        public double DivideByZero(int a, int b) //Checks input argument and throws exception
        {
            if (b == 0)
            {
                throw new ArithmeticException("Attempted to divide by Zero");
            }
            double c = a / b;
            return c;
        }
    }

    public class Person
    {
        public string Name = "Emil";
        public string? FamilyName = null;

        public void RegistrationApproval(string Name, string FamilyName) //Checks input argument and throws exception
        {

            if (Name == null)
            {
                throw new ArgumentNullException("Name is Misssing");
            }
            if (FamilyName == null)
            {
                throw new ArgumentNullException("Family Name is Missing");
            }
        }

        public void Catcher() //Write try-catch-finally block with multiple catch statements
        {
            try
            {
                RegistrationApproval(Name, FamilyName);
            }
            catch (ArithmeticException)
            {
                throw new Exception("Something went wrong, please make sure you are not dividing by 0");
            }
            catch (ArgumentNullException)
            {
                throw new Exception("There is nothing in there.");
            }
            finally
            {
                if (FamilyName == null)
                {
                    FamilyName = "K";
                }
            }


        }
    }
    ///In my Project
    //Declare implicit typed varible using keyword var
    //Debug class use for output / Portfolio / DeletTransaction()


}