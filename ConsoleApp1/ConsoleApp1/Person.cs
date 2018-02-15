using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise11
{
    //Exercise 1.1 – Creating a class
    //Create a class that represents a person. Let the class hold information about the person first
    //name, last name and age. Let the constructor take in above data as parameters and create get only
    //functionality. Write a method in the Program class that takes t he person - datatype as a parameter
    //and print out the information about that person. Create a few person objects and pass into the function

    public class Person
    {
        private string first;
        private string last;
        private int personAge;
        public static int personCounter;

        public Person(string firstName, string lastName, int age)
        {
            first = firstName;
            last = lastName;
            personAge = age;
            personCounter++;
        }

        public string firsttName
        {
            get
            {
                return first;
            }
        }

        public string lastName

        {
            get
            {
                return last;
            }
        }

        public int age

        {
            get
            {
                return personAge;
            }
        }
        //Exercise 1.2 – Adding methods to the class 
        //Add a method Speak that writes out “Hello my name is {first name} {last name}” to the screen when calling it on a person object

        public void Speak()
        {
            Console.WriteLine("Hello my name is " + first + " " + last);
        }

        //override the default ToString() method in the person class

        public override string ToString()
        {
            return "\nMyfirst name is: " + first + " \n" + "My last name is: "+ last + " \n" + "My age is " + personAge + " " ;

        }
        
        
    }

}
