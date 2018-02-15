using System;

namespace Exercise11
{



    class Program
    {
       
        static void Main(string[] args)
        { 
            Person p1 = new Person("Salim", "El Hajjar", 99);
            Console.WriteLine(p1);
            p1.Speak();
            ////Console.WriteLine("");
            ////Person p2 = new Person("Pamela", "Andersson", 35);
            ////Console.WriteLine(p2);
            ////Console.WriteLine("");
            ////p2.Speak();
            ////Console.WriteLine("");
            ////Person p3 = new Person("Kalle", "Svensson", 28);
            ////Console.WriteLine(p3);
            ////p3.Speak();
            ////Console.WriteLine("");
            ////Person p4 = new Person("Kim", "Kardashian", 43);
            ////Console.WriteLine(p4);
            ////Console.WriteLine("");
            ////p4.Speak();
            Console.WriteLine("");
            //Exercise 1.3 – Printing the person class directly
            //Try using the Console.WriteLine to write out the person object to the screen by passing the object as parameter. 
            //That is, Console.WriteLine( personObj ). What is the output? 
            Employee e1 = new Employee ("Mikael", "El Hajjar", 99, 12000);
            Client c1 = new Client("Alireza", "Nasrollahzadeh", 38);
            //Console.WriteLine(e1);
            //Console.WriteLine(c1);
            Console.WriteLine("Initiated Persons " + " " +  Person.personCounter + " \n" );

            e1.AddSale(c1, "melon", 45);
            //e1.listSales;
            foreach (SaleTransaction o in e1.listSales)
            {
                Console.WriteLine(o.ToString() );
            }
            Console.ReadLine();

        }
        
        
    }

}


////public class Person
////{
////    private string Firstname { get; set; }
////    private string Surname { get; set; }

////    public Person(string firstname, string surname)
////    {
////        this.Firstname = firstname;
////        this.Surname = surname;

////    }
////    public string GetFullName()
////    {
////        string fullname = String.Format("Firstname is: {0}, Surname is {1}", Firstname, Surname);
////        return fullname;
////    }
////}