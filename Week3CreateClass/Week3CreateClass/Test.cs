using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseClass
{
    internal class Test
    {
        static void Main(string[] args)
        {
            
            Customer firstCustomer = new Customer();
            Console.WriteLine(firstCustomer.ToString());

            firstCustomer.NewSales(300);
            Console.WriteLine(firstCustomer.ToString());

            Customer secondCustomer = new Customer("XYZ Company",
                500000, "A Contact");
            Console.WriteLine(secondCustomer.ToString());

            secondCustomer.NewSales(4500);
            Console.WriteLine("Read sales of second customer: {0:C}",
                secondCustomer.AnnualSales);
           
      

        }
    }
}
