using System;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string myString; //C# needs variable type in declaration (like Java)

            //no "primitive data types"! everything is a class, basic ones are just included in System and aliased

            myString = ".NET";

            Console.WriteLine(myString);

            //like Java, if, else if and else are the same
            //for, while, and do-while loops same
            //switch statement the same
            //some type conversion automatic
            //Generics exist

            //compile-time type inference for variables with var, but must be initialized! 
            //Copies type of right hand side.
            //Can use var when type is obvious from context or when it is obnoxiously long??
            var somedata = "String type";
            //var otherdata; //Left Statement wouldn't work

            reverse(somedata);

            //alt-shift-F is auto-Format code!

            //ctrl-. gives suggested ways of fixing errors, like importing (using) namespaces.
            //Namespace similar to Java package. Want it to match folder structure (dots for subfolders)

        }

        //static funcition callable from main (doesn't need an instantiated object to call it)
        static string reverse(string inputString)
        {
            string reversedString = "";
            foreach (char ch in inputString)  //foreach(type nameOfCurrentVarOfTheType in nameOfCollectionOfVarsOfTheType)  !/*  */
            {
                reversedString = ch + reversedString; //pre-pend character
            }

            return reversedString;
        }



    }
}
