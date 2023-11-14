using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateVehicle_KellyHumphrey
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Vehicle car1 = new Vehicle("Aston Martin", "Vantage", 2012, (decimal) 59000.00, "SA007678901234567");
            Console.WriteLine(car1.ToString());

            Vehicle car2 = new Vehicle("Chevrolet", "Malibu", 2009, (decimal) 5995.00, "V2345678901234567");
            Console.WriteLine(car2.ToString());

            Vehicle car3 = new Vehicle("Chevrolet", "Camaro", 2011, (decimal) 19000.00, "V123X03456J201344");
            Console.WriteLine(car3.ToString());

            Vehicle car4 = new Vehicle("Chevrolet", "Camaro", 2015, (decimal) 30888.00, "JKL3456789001234");
            Console.WriteLine(car4.ToString());

            Vehicle car5 = new Vehicle("Chevrolet", "Corvette", 2016, (decimal) 71995.00, "AJ234567876L12345");
            Console.WriteLine(car5.ToString());

            Vehicle car6 = new Vehicle("Chevrolet", "Corvette", 1973, (decimal) 11000.00, "H1234T65432456789");
            Console.WriteLine(car6.ToString());

            Vehicle car7 = new Vehicle("Ford", "Model A", 1930, (decimal)9000.00, "No VIN");
            Console.WriteLine(car7.ToString());

            Vehicle car8 = new Vehicle("Ford", "F-150 Raptor", 2017, (decimal)-89000, "R456789LWQ2345678");
            Console.WriteLine(car8.ToString());

            Vehicle car9 = new Vehicle("Toyota", "Camry", 2018, (decimal)22560.00, "T0234566789LA1234");
            Console.WriteLine(car9.ToString());

            Vehicle car10 = new Vehicle("Toyota", "Solara", 2005, (decimal)7000.00, "L2345B78901234567");
            Console.WriteLine(car10.ToString());
            Console.WriteLine(car10.totalNumberOfCars());











        }
    }
}
