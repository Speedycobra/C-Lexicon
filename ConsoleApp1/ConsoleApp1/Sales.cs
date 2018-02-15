﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    /*Exercise 1.7 – Creating a sales class In this exercise we want to create a class that hold a sale transaction that an employee 
     * makes with a client. The sales class should contain a name of the product sold, the money sold for in dollars(double), 
     * and a client class that references a client. Also, create a DateTime property that hold the information about when the sale was made.
     * Let the employee class hold a collection of sales objects and implement a method that adds a new sales to the list.
     * Also, create a constructor that instantiates the sales object. 
     * The date of the sale can be created in the constructor as the current date (DateTime.Now)*/
    class SaleTransaction
    {
        public Client Client;
        private double productPrice;
        //Private int productPrice;

       private string productName;
        public int Price;
        public DateTime saleTransactionTime;

        public SaleTransaction(Client client, string productName, double productPrice)

        {
            Client = client;
            this.productName = productName;
            this.productPrice = productPrice;
            saleTransactionTime = DateTime.Now;

        }
        public override string ToString()
        {
            return Client.firsttName + " " + Client.lastName + " " + productName + " " + productPrice + " " + saleTransactionTime;

        }
    }
   
}
