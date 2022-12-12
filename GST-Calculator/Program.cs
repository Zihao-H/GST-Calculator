/* Prgram Name:GST Calculator
 * Developer:Zih Hao Huang
 * Date:15/09/2022
 * Algorithm
 * 1.Initially client enters the Product name, Quantity and product cost
 * 2.select whether the GST must be added to it or that the cost has GST is already included.
 * 3.calculation based on the user’s choice. GST 15% is charged for the product.
 * 4.Adding GST to your prices (for example, $100 plus GST for a total of $115)
 * 5.taking GST off the price you receive (for example, $100 including GST, which is 3/23 of $100, or $13.04)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GST_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {// Declaration of Variables
            float num1 = 0, num2 = 0, total = 0;
            double gst;
            // Ask user to enter item name
            Console.WriteLine("Please enter the item name:");
            string i = Convert.ToString(Console.ReadLine());
            // Ask user to enter items purchased 
            Console.WriteLine("Enter the number of items purchased :");
            num1 = Convert.ToSingle(Console.ReadLine());
            // Ask user to enter price of the item
            Console.WriteLine("Enter the price of the item :");
            num2 = Convert.ToSingle(Console.ReadLine());
            total = num1 * num2;
            Console.WriteLine("Your item name is  " + i + "    Purchase price :{0}", total);

            //let user choice Y (with GST) or N (taking off the GST)
            char withGST;
            Console.WriteLine("Do you want to add GST?   Please enter Y/N");
            withGST = Convert.ToChar(Console.ReadLine());
            {
                if (withGST == 'Y')
                {
                    gst = 0.15;
                    Console.WriteLine("Your price with GST : {0}", total * gst + total);
                }
                else
                {
                    gst = 0.1304;
                    Console.WriteLine("taking GST off the price you receive : {0}", total * gst);
                }
            }
            Console.ReadKey();
        }
    }
}
