// HW1a Sales Total

// Your Name: Gabe Richardson
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            Console.WriteLine("What product are you buying? "); //product
            string product = Console.ReadLine();
            
            Console.WriteLine("What is the quantity of your purchase? "); //ticket amount
            string productamountInput = Console.ReadLine();
            int productamount = Convert.ToInt32(productamountInput);
            
            Console.WriteLine("What is the individual price? "); //ticket price
            string productpriceInput = Console.ReadLine();
            int productprice = Convert.ToInt32(productpriceInput);

            double subtotal = (productamount * productprice); //subtotal
            double salestax = 0.085;
            double saletaxamount = (subtotal * salestax);
            double finaltotal = (subtotal + saletaxamount);

            //printing outputs
            Console.WriteLine("     Your subtotal is: " + subtotal);
            Console.WriteLine("     Your sales tax is " + saletaxamount);
            Console.WriteLine("     Your total is: " + finaltotal);
        }
    }
}
