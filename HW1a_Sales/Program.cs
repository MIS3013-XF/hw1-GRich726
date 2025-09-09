// HW1a Sales Total

// Your Name:
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
            
            Console.WriteLine("How many tickets are you buying? "); //ticket amount
            string ticketamountInput = Console.ReadLine();
            int ticketamount = Convert.ToInt32(ticketamountInput);
            
            Console.WriteLine("What is the price for each football ticket?"); //ticket price
            string ticketpriceInput = Console.ReadLine();
            int ticketprice = Convert.ToInt32(ticketpriceInput);

            //double SalesTax = 8.5;
            //double subtotal = product +  
            
        }
    }
}
