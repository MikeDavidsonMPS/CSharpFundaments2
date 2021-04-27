using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{

        // METHOD Types

    [TestClass]
    public class MethodExamples
    {
        
        //BASIC UNDERSTANDING
            //Input
            //What we do
            //Output

        //Access Modifier   Return   Method Signature   (Name and list of Parameters)

        // Method: AddTwoNumbers
        public int AddTwoNumbers(int  numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        // Method: Overload Constructive
        public int AddTwoNumbers(int x)                     // example of an "overLoad" constructive method for classess
        {
            return x;
        }

        // Method: Subtract
        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        // Method: Multiply
        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        // Method: Divide
        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        // Method: Find Remainder
        private int FindRemainder(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }


        [TestMethod]
        public void MethodsTests()
        {
            int banana = AddTwoNumbers(7, 12);
            Assert.AreEqual(19, banana);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int fruitSalad = DivideTwoNumbers(10, 4);
            Assert.AreEqual(2, fruitSalad);

            int remainder = FindRemainder(10, 4);
            Assert.AreEqual(2, remainder);

        }
    }
}
