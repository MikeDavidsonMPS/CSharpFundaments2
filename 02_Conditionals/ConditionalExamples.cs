using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (isTrue)
            {
                //Do something here
            }

            int age = 24;

            if (age > 17)
            {
                Console.WriteLine("you're and adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("you're Still a Kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("you're far too young to be on a computer");
            }
            else
            {
                Console.WriteLine("You're not even born yet");
            }


            if (age > 65 && age < 18)
            {
                // And comparison &&
            }

            if (age <= 65 || age >= 18)
            {
                //Or comparison ||
            }

            if (age == 17)
            {
                //is equal too
            }

            if (age != 19)
            {
                //Not equal too
                // ! bang operator
            }
        }

        [TestMethod]
        public void SwitchCases()     //condition SwitchCase = =
        {
            int age = 42;

            switch (age)
            {
                case 18:
                    //code for if age 18
                    break;
                case 19:
                    // Code for if age 19
                    break;
                case 20:
                    // code for if age 20
                    break;
                case 21:
                case 22:
                case 23:
                    // code here for 21-23
                    break;
                default:
                    // catch all code
                    Console.WriteLine("You are not 18-23");
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            // bool someVariable = (boolaen statement)  > trueValue : falseValue;

            bool isAge = (age == 24) ? true : false;
        }
    }
}
