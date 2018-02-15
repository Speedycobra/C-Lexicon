////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace Sales
////{
////    //    class Sales
////    //    {
////    //    }
////    //}
////    public class Sales
////    {
////        // class variables
////        private static double total_sale;
////        private static int total_quantity;

////        // Instance variables
////        private String product;
////        private double daily_sale;
////        private int daily_quantity;
////        public Sales(String name, double cost, int amount)
////        {
////            product = name;
////            daily_sale = cost;
////            daily_quantity = amount;


////            total_sale = total_sale + cost;
////            total_quantity = total_quantity + amount;
////        }

////        // class method
////        public static int getTotalQuantity()
////        {
////            return total_quantity;
////        }

////        // class method
////        public static double getTotalSale()
////        {
////            return total_sale;
////        }

////        // instance method
////        public double getSale()
////        {
////            return daily_sale;
////        }

////        // instance method
////        public int getPieces()
////        {
////            return daily_quantity;
////        }

////        // instance method
////        public String getProduct()
////        {
////            return product;
////        }


////    }
////}
