using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
 
{

    //Exercise 1.6 – Inheritance Write an employee class and a client class that are descendants of the person class. //
    //Implement a salary property on the employee class and create a constructor that calls the base person class 
    //constructor passing the information it needs.On both classes, override the ToStringmethod and let them return 
    //a distinct message depending whether they’re clients and employees.Call the method you created in exercise 3 with
    //both an employee and a client object. 

    class Employee : Person
    {
        string[] testArray;
        private int salary;
        public List<SaleTransaction>listSales = new List<SaleTransaction>(); 

        public Employee(string firstName, string lastName, int age, int salary): base(firstName,lastName,age)
        {
            this.salary = salary;
        }
        public override string ToString()
        {
            return "I am an Employee: " + base.ToString() + " \nMy salary is " + salary + "\n";
        }

        public void AddSale(Client Klient, string produktNamn, double Pris)
        {
            SaleTransaction tempSale = new SaleTransaction(Klient, produktNamn, Pris);
            listSales.Add(tempSale);
        }
    }

}
