using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Whole Numbers
            byte oneBytesWorth;     //Declaretion: by declaring and naming--you create a "box"
            oneBytesWorth = 255;    //bytes are vauled at 32bit with a nax of 255. we name the byte - oneBytesWorth, can use the word or "name" as byte - so we have declaraed byte to be called oneBytesWorth
            short smallWholeNumber = 16;    // int16
            Int16 anotherSmallNumber = 16;  // short hand for the type of bit, int16 (smallNumber"short") int32 (wholeNumber "int") int64 (largeWholeNumber "long")
            int wholeNumber = 32;           // int32
            long largeWholeNumber = 64;     // int64

            int newNumber = oneBytesWorth;

            //--Decimals
            float floatExmaple = 1.234567f;
            double doubleExmaple = 1.237909d;
            decimal decimalExample = 1.70000m;

            //--Character
            char letter = 'j';


            //-- Operators                 // integers "int" only deal in WHOLE NUMBERS
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;    // "+" and "sum"  addition
            Console.WriteLine(sum);                                     //Console.WriteLine will create print out in the parameters "()"
            int diff = numOne - numTwo;   // "-" and "diff" subtraction
            Console.WriteLine(diff);
            int prod = numOne * numTwo;   // "*" and "prod" Mulitpy 
            Console.WriteLine(prod);
            int quot = numOne / numTwo;   // "/" and "quot" divide 
            Console.WriteLine(quot);                                   // the out is in whole number so it will be 3 and not 3.2
            int remainder = numOne % numTwo;   // the operation only deal with whole number a vaule must be assign the remaider of a divided operators EX: 17/5 = 3.2 the "int remainder" would be 2 call "Modulus"
            Console.WriteLine(remainder);                              // the modulus "%" in the vaule remainder will output 2 from 17/5=3.2

            Console.WriteLine("Hello");  // when using the "" in the parameters will output what is in the "". NO "" the output will be the vaule assigned EX: sum
                                         // when running test for types, loop, case ect....with can place a line statment of Console.WriteLine to give us an output 
                                         // ...to help to determine the functionality of our code. A visible return on our code
        }

        [TestMethod]                    //"[TestMethod}" allows us to see the in solultion explorer and make tests == withou it the method "public void Reference Types()" would exist but not able to test
        public void ReferenceTypes()
        {
            //--string== are lwtter word sentence paragraphs in "".
            string stringExample = "This is a string,";  //we declare "string" we name "stringExample" we give value "=" and parameters "this is a string" == all parts equal the "string"
            string name = "Joshua";

            string declared;
            declared = "How it is initialized.";       //by declaring we give vaule 

            //  formating string
            string concatenate = stringExample + " "+ name;   // concateation slams multi things together. use a "+" is like add numbers but in a string is put together multi items Ex "this is a string joshua"
            string interpolation = $"{name}. Here is the String: {stringExample}"; //interpolation allow us to repair a string vuale with the use of the "$"and "{}" ex: Joshua. Here is the String: this is the string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolation);

            //--Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);  // the numbers in this constructor are integers "int"

            TimeSpan waitTime = randomDate - now;   //--this object will produce a date and time that is subtracted from randomDate and now -- give the diffence
            Console.WriteLine(waitTime.TotalSeconds); // ".TotalSeconds" is the dot opertator give us the properties


            //--Collections
            //Arrays
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "I" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);


            // Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            // Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            // Dictionaries
            Dictionary<char, string> keyValuePairs = new Dictionary<char, string>();
            keyValuePairs.Add('j', "josh");

            // Other Collections
            SortedList<int, string> sortedKeyVaulePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();
        }
    }
}
