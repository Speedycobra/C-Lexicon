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

        public void AddSale(Client Klient, string produktNamn, float Pris)
        {
            SaleTransaction tempSale = new SaleTransaction(Klient, produktNamn, Pris);
            listSales.Add(tempSale);
        }
        /*Exercise 1.8 – Calculating some sales statistics Just storing each sales does not do us much good since 
         * the company is interested in how many sales an employee has made and how much money he have earned for the company. 
         * Now, they want you to create a few methods in the employee class that calculates these things. 
         * Let the first method be GetNumberOfSales(), which returns the number of sales. 
         * Let the second method be GetSalesTotal() that sums up the money sold for each element. 
         * Let the third method be to calculate the average sale for the employee. 
         * Then lastly, create a method that prints out the sales statistics for a specific employee. 
         */
        public int GetNumberOfSales()
        {
            return listSales.Count;
        }

        public float GetSalesTotal()
        {
            float totalsale = 0;
            foreach (SaleTransaction sale in listSales)
            {
                totalsale += sale.productPrice;
            }
            return totalsale;
        }
        
        public float GetSalesAverage()
        {
            return GetSalesTotal() / GetNumberOfSales();
        }

        public void printStatistics() {
            Console.WriteLine("Following is statistic for " + firstName + " " + lastName + "!");
            Console.WriteLine("Number of sales: " + GetNumberOfSales());
            Console.WriteLine("Sales total: $" + GetSalesTotal());
            Console.WriteLine("Average sales: $" + GetSalesAverage());
        }


    }


}
