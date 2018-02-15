using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello30
{
    class  Program
    {

        public static void Main(string[] args)
        {
            for (int row = 10; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("-");

                }
                Console.WriteLine();

            }
            for (int row = 1; row >= 1; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("-");
                }
                Console.ReadLine();
            }
            for (int row = 10; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("-");

                }

                Console.WriteLine();
               
            }
            for (int row = 1; row >= 1; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("-");

                }

                Console.ReadLine();
            }

        }
    }
}


//namespace hello29
//{

//    class Program
//    {

//        public static void Main(string[]args)
//        {

//            //output the Fibonacci series up until that number.

//            int i, count, f1 = 0, f2 = 1, f3 = 0;
//            Console.Write("Enter the Limit : ");
//            count = int.Parse(Console.ReadLine());
//            Console.WriteLine(f1);
//            Console.WriteLine(f2);
//            for (i = 0; i <= count; i++)
//            {
//                f3 = f1 + f2;
//                Console.WriteLine(f3);
//                f1 = f2;
//                f2 = f3;
//            }
//            Console.ReadLine();




//        }
       
//    }
        
//}

////namespace hello28
////{
////    class Program
////    {
////        public static void Main(string[] args)
////        {
////            {
////                /*
////                Write a program that outputs the 3 first perfect numbers. 
////                A perfect number is a number where all its positive divisors sums up to the actual number. 
////                The first number is 28, where 14 + 7 + 4 + 2 + 1 = 28. 
////                Tip: look at the previous exercise and build on top of it.
////                */

////                Console.WriteLine("Please enter the number you want to check:");
////                int number = int.Parse(Console.ReadLine());
////                int perfectNumberCount = 0;
////                string PerfectNumbers_found = "";
////                string allDivisibleNumbers = "";

////                // catch 3 perfect number, check all.
////                for (int j = number; number >= 1; j--)   // run 'number' times
////                {
////                    int numberCopy = number;
////                    int sum;
////                    // iterate all values possible of numberCopy &
////                    for (int i = numberCopy; numberCopy >= 1; i--) // run 'number' times
////                    {
////                        sum = 0;
////                        // check modulo
////                        int moduloResult = numberCopy % i;
////                        // store modulo %
////                        if (moduloResult == 0)
////                        {
////                            // concatinating all 'number's which result in modulo zero
////                            allDivisibleNumbers = allDivisibleNumbers + " " + i.ToString();
////                            sum += i;
////                        }

////                        // "perfect number" logic
////                        // i.e.: if the sum of all modulo result of 'number' is equal to 'number'
////                        if (sum == numberCopy || sum != 0)
////                        {
////                            perfectNumberCount++;
////                            PerfectNumbers_found = PerfectNumbers_found + "  " + sum.ToString();
////                            Console.WriteLine("the first three perfect numbers are  {0}.", PerfectNumbers_found);
////                        }
////                        // printing perfect numbers, and ending the loop when necessary 3 perfect numbers found.
////                        if (perfectNumberCount == 3)
////                        {
////                            Console.WriteLine("Stop checking further, we found 3 perfect numbers!");
////                            Console.WriteLine("Perfect numbers are:  {0}.", PerfectNumbers_found);
////                            Console.ReadLine();
////                            break;
////                        }
////                        else if (i == numberCopy && perfectNumberCount == 3)
////                        {
////                            Console.WriteLine("we found 3 perfect numbers!");
////                            Console.WriteLine("Perfect numbers are:  {0}.", PerfectNumbers_found);
////                            Console.ReadLine();
////                            break;
////                        }
////                        // ending loop because not all three perfect numbers found.
////                        else if (i == numberCopy && perfectNumberCount != 3)
////                        {
////                            Console.WriteLine("we couldn't found 3 perfect numbers!");
////                            Console.WriteLine("Perfect numbers are:  {0}.", PerfectNumbers_found);
////                            Console.ReadLine();
////                            break;
////                        }
////                        Console.WriteLine("This is the result of all divisible numbers of {0} number-item(s) : {1}", number, allDivisibleNumbers);
////                        numberCopy--;
////                    }
////                    number--;
////                    Console.ReadLine();

////                }
////            }
////        }
////    }
////}





//namespace hello27
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());
//            int moduloResult;
//            string allDivNum = "";
//            for (int i = 1; i <= number; i++)
//            {
//                moduloResult = number % i;
//                if (moduloResult == 0)
//                {
//                    string m = i.ToString();
//                    allDivNum = allDivNum + m;
//                    if (i != number)
//                    {
//                        allDivNum = allDivNum + ",";
//                    }
//                }
//            }
//                 Console.WriteLine("the number is divisible by {0}.", allDivNum);
//                 Console.ReadLine();
//        }
//    }
//}


   
////namespace hello26
////{
////    class Program
////    {

////        public static void Main(string[] args)
////        {

////            int count = 0;
////            int sum = 0;
////            int number = 0;

////            {
////                Console.Write("\n\n");// drop 2 rows of space
////                Console.Write("Please enter a number:\n");
////                Console.Write("-------------------------"); 
////                Console.Write("\n\n");// drop 2 rows of space
////                number = Convert.ToInt32(Console.ReadLine());
////            } 
////            // Begin do-while loop.
////            // ... Terminates when number equals -1.
            
////            do
////            {
////                count++;
////                sum += number;
////                Console.Write("\n\n");// drop 2 rows of space
////                Console.WriteLine("Please Enter a new number: ");
////                Console.Write("\n\n");// drop 2 rows of space
////                number = Convert.ToInt32(Console.ReadLine());
////            } while (number != -1);

////            Console.WriteLine("Count: " + count);
////            Console.WriteLine("Sum: " + sum);
////            Console.WriteLine("Average: " + sum / count);

////            Console.ReadLine();


////        }

////    }

////}


//namespace hello25
//{
//    class Program
//    {


//        public static void Main(string[] args)
//        {
//            //int n = int.Parse(Console.ReadLine());
//            for (int row = 10; row >= 1; row--)
//            {
//                for (int col = 1; col <= row; col++)
//                {
//                    Console.Write("-");

//                }
//                Console.WriteLine();


//            }
//            Console.ReadLine();
//        }
//    }
//}



//namespace hello24
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {

//            int m = 1;
//            Console.Write(" please enter the power that you need \t");
//            int n = int.Parse(Console.ReadLine());
//            double power = 0;
//            for (int i = 1; i < 11; i++)
//            {
//                m = i;
//                power = Math.Pow(m, n);
//                string mm = String.Format(CultureInfo.InvariantCulture,"{0:#,#}", power);
//                Console.WriteLine("{0} raised to the power of {1} is equal to {2} ", m, n, mm);
//                Console.WriteLine();
//            }

//            Console.ReadLine();

//        }

//    }
//}   


/* lotto
 * for (int i1 = 1; i1 <= 44; i1++)

            {

                for (int i2 = i1 + 1; i2 <= 45; i2++)

                {

                    for (int i3 = i2 + 1; i3 <= 46; i3++)

                    {

                        for (int i4 = i3 + 1; i4 <= 47; i4++)

                        {

                            for (int i5 = i4 + 1; i5 <= 48; i5++)

                            {

                                for (int i6 = i5 + 1; i6 <= 49; i6++)

                                {

                                    Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4 + " " + i5 + " " + i6);

                                }

                            }

                        }

                    }

                }

            }
            */

/*
 * int n = int.Parse(Console.ReadLine());

for (int row = 1; row <= n; row++)

{

        for (int col = 1; col <= row; col++)

        {

             Console.Write(col + " ");

        }

        Console.WriteLine();

}
*/
//namespace hello23
//{
//    class Program
//    {

//        public static void Main(string[] args)
//        {


//            int val = 0;
//            for (int i = 1; i < 11; i++)
//            {
//                val = i;
//                for (int j = 1; j < 11; j++)
//                {
//                    Console.Write("{0}\t ", val);
//                    val += i;
//                }

//                Console.Write("\n");
//            }

//            Console.ReadLine();



//            //Console.Write("Multiplication table:\n");

//            //for (int i = 1; i <= 10; i++)
//            //{

//            //    for (int j = 1; j <= 10; j++)
//            //    {
//            //        Console.Write(i * j + " ");
//            //    }
//            //    Console.Write("\n");
//            //    Console.ReadLine();
//            //}


//            //Console.Write("Multiplication table:\n");
//            //int n = 1;

//            //for (int i = 1; i <= 10; i++)
//            //{
//            //    Console.Write(n + " X " + i + " = " + (n * i) + "\n");
//            //}
//            //Console.ReadLine();



//            //int isa = 1;
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Console.Write("{0} ", isa);
//            //    isa++;
//            //}
//            //Console.Write("\n");

//            //int rowstartPoint = 1;
//            //for (int j = 1; j < 11; j++) //run 10 times
//            //{
//            //    for (int i = 0; i < 10; i++) //run 10 times
//            //    {
//            //        Console.Write("{0} ", rowstartPoint + j); //print row_num_23*2
//            //        rowstartPoint++;
//            //    }
//            //    Console.Write("\n");
//            //    rowstartPoint = j++;
//            //    //multiplication_num++;
//            //}
//            //Console.Write("\n");
//            //Console.ReadLine();


//            //for (int i = 0; i <= 10; i++)
//            //{
//            //    Console.Write("{0}\t", i);
//            //    for (int j = 1; j <= 10; j++)
//            //    {
//            //        Console.Write("{0}\t", i * j);
//            //    }
//            //    Console.WriteLine();
//            //}

//            //Console.ReadLine();

//        }
//    }
//}

//namespace hello22
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            // Taking input of a number
//            Console.WriteLine("Please enter a number:");
//            int inputa = int.Parse(Console.ReadLine());
//            // checking if it's greater than zero
//            if (inputa > 0)
//            {
//                for (int i = 0; i < inputa; i++)
//                {
//                    if (i % 2 == 0)
//                    {
//                        Console.Write("{0}\n", i);
//                    }
//                }

//            }
//            Console.ReadLine();
//        }
//    }
//}

//namespace hello21
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            // Taking input of a number
//            Console.WriteLine("Please enter a number:");
//            int inputa = int.Parse(Console.ReadLine());
//            // checking if it's greater than zero
//            if (inputa > 0)
//            {
//                for (int i = inputa - 1; i >= 0; i--)
//                {
//                    Console.Write("{0}", i);
//                    if (i > 1)
//                    {
//                        Console.Write(",");
//                    }
//                    if (i == 1)
//                    {
//                        Console.Write(" and ");
//                    }
//                }
//                Console.Write(".\n");
//            }
//            Console.ReadLine();

//        }
//    }
//}


//namespace hello20
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            // Taking input of a number
//            Console.WriteLine("Please enter a number:");
//            int inputa = int.Parse(Console.ReadLine());
//            // checking if it's greater than zero
//            if (inputa > 0)
//            {
//                for (int i = 0; i < inputa; i++)
//                {
//                    Console.Write("{0}", i);
//                    if (i != inputa - 1 && i != (inputa - 2))
//                    {
//                        Console.Write(",");
//                    }
//                    if (i == (inputa - 2))
//                    {
//                        Console.Write(" and ");
//                    }
//                }
//                Console.Write("\n");


//            }
//            Console.ReadLine();
//        }

//    }
//}




//namespace hello19
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            // taking user input of colour
//            Console.WriteLine("Please enter colour name:");
//            string inputa = Console.ReadLine();
//            // checking if the colour exists.
//            // printing out the name of the colour with the same colours.
//            switch (inputa)
//            {
//                case "red":
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("{0}", inputa);
//                    break;

//                case "blue":
//                    Console.ForegroundColor = ConsoleColor.Blue;
//                    Console.WriteLine("{0}", inputa);
//                    break;

//                case "green":
//                    Console.ForegroundColor = ConsoleColor.Green;
//                    Console.WriteLine("{0}", inputa);
//                    break;

//                case "yellow":
//                    Console.ForegroundColor = ConsoleColor.Yellow;
//                    Console.WriteLine("{0}", inputa);
//                    break;

//                default:
//                    // If it doesn’t displaying an error message
//                    Console.WriteLine("Error: Color not found!");
//                    break;
//            }
//            Console.ReadLine();

//        }
//    }
//}
//namespace hello18
//{
//    class Program
//    {
//        public static void Main (string[] args)
//        {
//            //user type in a number
//            Console.WriteLine("Please enter a number:");
//            int inputa = int.Parse(Console.ReadLine());
//            //Checking if the number is in the range 10 <= number <= 20
//            if (10 <= inputa)
//            {
//                Console.WriteLine("Yes, it is in the range 10 <=.");
//                if (10 <= inputa && inputa <= 20)
//                {
//                    Console.WriteLine("Yes, it is in the range <= 20.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("It's not in the range.");
//            }
//            Console.ReadLine();
//        }
//    }
//}


//namespace hello17
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            double result;
//            // two numbers: a and b. & Convert them into integers
//            Console.WriteLine("Please enter first number a:");
//            int inputa = int.Parse(Console.ReadLine());

//            Console.WriteLine("Please enter se3cond number b:");
//            int inputb = int.Parse(Console.ReadLine());
//            //casting one of the integers to a double number
//            double inputaDouble = (double) inputa;

//            //result = a + b, a – b, a* b and a / b;
//            result = inputaDouble + inputb;
//            Console.WriteLine("Result of a + b is: {0}.", result);
//            result = inputaDouble - inputb;
//            Console.WriteLine("Result of a – b is: {0}.", result);

//            // Make a check before dividing that b is not zero
//            // display a message that it cannot be divided (if)
//            // & show the result from a + b, a – b, a * b and a / b to the user with a descriptive label
//            if (inputb != 0)
//            {
//                result = inputaDouble / inputb;
//                Console.WriteLine("Result of a / b is: {0}.", result);
//            }
//            else
//            {
//                Console.WriteLine("Second input value is zero. It can not be divided.");
//            }

//            Console.ReadLine();
//        }

//    }
//}


//namespace hello16
//{
//    class Program
//    {
//        public static void Main(string[] args)
//       {
//            int input;
//            // Displaying 3 different options that the user can choose from
//            Console.WriteLine("Please enter \n\"1\" to print \"Stockholm\" \n\"2\" to print \"Göteborg\" \n\"3\" to print \"Malmö\" \nYour choice:");
//            // saving user input
//            input = int.Parse(Console.ReadLine());


//            // Removing the options after the choice.
//            Console.Clear();

//            // Displaying a different message, depending on the choice
//            switch (input)
//            {
//                case 1:
//                    Console.WriteLine("You entered 1.");
//                    Console.WriteLine("Stockholm");
//                    break;
//                case 2:
//                    Console.WriteLine("You entered 2.");
//                    Console.WriteLine("Göteborg");
//                    break;
//                case 3:
//                    Console.WriteLine("You entered 3.");
//                    Console.WriteLine("Malmö");
//                    break;
//                default:        // Display a message, if the choice is not valid
//                    Console.WriteLine("Your choice is not valid.\n");
//                    break;
//            }
//            Console.ReadLine();

//        }
//    }
//}

//namespace hello15
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            // storing the user typed text
//            string input = Console.ReadLine();
//            // checking whether the length of the string is greater than 25
//            if (input.Length > 25)
//            {
//                Console.WriteLine("Yes, it's greater than 25.");
//            }
//            else
//            {
//                Console.WriteLine("No, it's not greater than 25.");
//            }
//            Console.ReadLine();
//        }
//    }
//}


//namespace hello14
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            // storing the user typed text
//            string input = Console.ReadLine();
//            // checking whether the word “city” occurs in the string
//            int pos_of_text_occurance_14 = input.IndexOf("city");

//            // display a message to the user at what position “city” occured
//            if (pos_of_text_occurance_14 != -1)
//            {
//                Console.WriteLine("We have found \"City\" in the text at {0} position of index. \nFor no-technical folks, it's {1} character in text.", pos_of_text_occurance_14, pos_of_text_occurance_14 + 1);
//            }
//            else
//            {
//                Console.WriteLine("Sorry we have found \"City\" in the text.");
//            }
//            Console.ReadLine()
//        }
//    }
//}


//namespace hello
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter a name: ");
//            String input = Console.ReadLine();

//            if (input == "Bob" || input == "Alice")
//            {
//                Console.WriteLine("Hi " + input);
//            }
//            else
//            {
//                Console.WriteLine("Goodbye " + input + "!");
//            }
//            Console.ReadLine();
//        }
//    }
// }





//namespace hello 
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter a number: ");
//            String input = Console.ReadLine();
//            int number = Int32.Parse(input);
//            int result = number % 4;
//            if (result == 0)
//            {
//                Console.WriteLine("This number is divisible by 4");
//            }
//            else
//            {
//                Console.WriteLine("This number is not divisible by 4");
//            }
//            Console.ReadLine();
//        }
//    }
// }   


/*namespace hello11 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            String input = Console.ReadLine();
            Console.WriteLine("You chose: " + input);
            int number = Int32.Parse(input);
            double result = Math.Sqrt(number);

            Console.WriteLine("Square Root: " + result);
            result = Math.Pow(number, 2);
            Console.WriteLine("PowerOf2: " + result);
            result = Math.Pow(number, 3);
            Console.WriteLine("PowerOf3: " + result);
            result = Math.Pow(number, 10);
            Console.WriteLine("PowerOf10: " + result);
            Console.ReadLine();
        }
    }
}
        */

//public void Math
//{


//    // reading from console, and parsing into int
//    double  n = double.Parse(Console.ReadLine());
//    double sqrt_of_n;
//    double square_2_of_n;
//    double square_3_of_n;
//    double square_10_of_n;
//    Console.WriteLine(n);

//    // calculating square root of n
//    sqrt_of_n = Math.Sqrt(n);
//    // calculating square(s) of n
//    square_2_of_n = Math.Pow(n, 2);
//    square_3_of_n = Math.Pow(n, 3);
//    square_10_of_n = Math.Pow(n, 10);
//    // writing-to-console the square(s) of n
//    Console.WriteLine(square_2_of_n);
//    Console.WriteLine(square_3_of_n);
//    Console.WriteLine(square_10_of_n);
//    Console.ReadLine();
//}




//namespace Hello
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {



//            //================================================================




//            // 10 //==============================EXERCISE10.2==================
//int a = 10;
//int b = 3;
//int c = 7;
//int d = (int)(7 / 2.0f);
//double result = ((double)a / b) * 2;
//Console.WriteLine(result);              // result: 6,66
//result = a / (b + c) + 9.0f;
//Console.WriteLine(result);      // result: 10
//result = a * a / (b + c);
//Console.WriteLine(result);      // result: 10
//result = a * (b + a) - 100;
//Console.WriteLine(result);      // result: 30
//Console.ReadLine();
//            //=============================================

//            //==============================EXERCISE10.1==================
//            //int a_math = 10;
//            //double b_math = 2.0;
//            //double average = (a_math + b_math) / 2;
//            //Console.WriteLine(average);
//            ////paranthese saknas.
//            //Console.ReadLine();
//            //=============================================
//        }
//    }
//}

////====================================================Exercise9============================
////namespace Hello
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {


////string str = "(abc) and (cba) are each others reverse! same goes for (bac) and (cab)!";
////string stra = str.Substring(str.IndexOf("(a") + 1, 3);
////string strb = str.Substring(str.IndexOf("(cb") + 1, 3);
////string strc = str.Substring(str.IndexOf("(b") + 1, 3);
////string strd = str.Substring(str.IndexOf("(ca") + 1, 3);
////Console.WriteLine(stra);
////            Console.WriteLine(strb);
////            Console.WriteLine(strc);
////            Console.WriteLine(strd);

////            Console.WriteLine(stra + strb + strc + strd);
////            Console.ReadLine();
////        }
////    }
////}
////=============================================================================================

////====================================================Exercise8============================
////String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
////Console.WriteLine(str);

////                int iStart = str.IndexOf("[");
////int iEnd = str.IndexOf("]");
////String strAr = str.Substring(iStart, iEnd - iStart + 1);
////Console.WriteLine(strAr);

////                strAr = strAr.Replace(",2", "");
////                strAr = strAr.Replace(",3", "");
////                Console.WriteLine(strAr);

////                int iEnd2 = strAr.IndexOf("]");
////strAr = strAr.Insert(iEnd2, ",6");
////                strAr = strAr.Insert(iEnd2 + 2, ",10");
////                Console.WriteLine(strAr);



////Console.ReadLine();
////=============================================================================================




