using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_HumphreyKelly
{
    internal class TestData
    {
        static void Main(string[] args)
        {
            
            //Creation of array to contain objects
            Vehicle[] vehicleArray = new Vehicle[12];
            
            //Creatio of objects
            Bicycle myBicycle1 = new Bicycle("B0001", "Trek", "Street", 2023, 2000.00m, true);
            Bicycle myBicycle2 = new Bicycle("B0002", "Cannon", "Trainer", 2022, 1000.00m, false);
            Bicycle myBicycle3 = new Bicycle("B0003", "Franco", "Machine", 2023, 6000.00m, false);
            Motorcycle myMotorcyle1 = new Motorcycle("M0001", "Yamaha", "YZF-R1", 2023, 22000.00m, false);
            Motorcycle myMotorcyle2 = new Motorcycle("M0002", "Yamaha", "YZ250", 2023, 10000.00m, true);
            Motorcycle myMotorcyle3 = new Motorcycle("M0003", "Honda", "CBR600", 2001, 9000.00m, false);
            Car myCar1 = new Car("C0001", "Toyota", "Prius", 2014, 14000.00m, 5);
            Car myCar2 = new Car("C0002", "Mazda", "Miata", 2001, 12000.00m, 2);
            Car myCar3 = new Car("C0003", "GMA", " T.50", 1991, 2000000.00m, 3);
            Truck myTruck1 = new Truck("T0001", "Ram", "1500", 2020, 35000.00m, 5000);
            Truck myTruck2 = new Truck("T0002", "Ford", "F150", 2015, 37000.00m, 6000);
            Truck myTruck3 = new Truck("T0003", "Toyota", "Tacoma", 2015, 27000.00m, 2000);

            //Assignment of objects to array
            vehicleArray[0] = myBicycle1;
            vehicleArray[1] = myBicycle2;
            vehicleArray[2] = myBicycle3;
            vehicleArray[3] = myMotorcyle1;
            vehicleArray[4] = myMotorcyle2;
            vehicleArray[5] = myMotorcyle3;
            vehicleArray[6] = myCar1;
            vehicleArray[7] = myCar2;
            vehicleArray[8] = myCar3;
            vehicleArray[9] = myTruck1;
            vehicleArray[10] = myTruck2;
            vehicleArray[11] = myTruck3;

            //Vehicle information report
            Console.WriteLine(myBicycle1.getHeader());
            foreach (Vehicle obj in vehicleArray)
            {
                Console.WriteLine(obj.getData());
            }

            //Printout of class structures
            foreach (Vehicle obj in vehicleArray)
            {
                Console.WriteLine(obj.ToString());
            }

        }
    }
}
