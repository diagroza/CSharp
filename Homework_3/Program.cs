using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication4
{
    class Price
    {
        public void priceTotal(ref int price, ref int quantity)
        {
            //logical operations
            int total = price * quantity;
            Console.WriteLine("Total price is" + " " + total);
            Console.ReadLine();
        }
    }
    class Product
    {
        public static void Main(string[] args)
        {
            /* local variable definition */

            int price = 9;
            int quantity = 85;
            //defining the object for the class marks

            Price p = new Price();

            //calling marks total method for calculation

            p.priceTotal(ref price, ref quantity);
        }
    }
}