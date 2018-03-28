using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodTest

{
    class Program

    {
        static void Main(string[] args)
        {
            String mystring;
            long mylong;
            double mydouble;
            
            //mystring = "C# is a powerful and flexible programming language. Like all programming languages, it can be used to create a variety of applications. It belongs to C family and inherently has lots of things carried from C programming language. It is the ideal choice of all .net developers for the reason that Microsoft has developed C# with features of popular languages to develop different types of .net applications.";
            mystring = "12365478345678";
            //mystring = "248.7";
            mylong = mystring.ToLong();
            mydouble = mystring.ToDouble();

            Console.WriteLine("My String is: " + mystring);
            Console.WriteLine("Long number is: " + mylong * 6);
            Console.WriteLine("Double is: " + mydouble * 6);

            Console.WriteLine("Count: {0}", mystring.WordCount());


            // Uppercase words in these strings.
            const string value1 = "something in the way";
            const string value2 = "dot net PERLS";
            const string value3 = "String_two;three";
            const string value4 = "sam";
            // ... Compute the uppercase strings.
            Console.WriteLine(value1.UppercaseWords());
            Console.WriteLine(value2.UppercaseWords());
            Console.WriteLine(value3.UppercaseWords());
            Console.WriteLine(value4.UppercaseWords());
            Console.ReadKey(true);
        }
    }
}

