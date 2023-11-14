using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_HumphreyKelly
{
    internal class Car : Wheels4
    {
        int passengers;

        public Car(string inventoryID, string companyName, string modelName, int productionYear, decimal salesPrice, int passengers)
        : base(inventoryID, companyName, modelName, productionYear, salesPrice)
        {
            this.passengers = passengers;
            Console.WriteLine("A Car class has been instantiated.");
        }

        public string getPassenger()
        {
            return "This car can hold up to " + passengers + " passengers.";
        }

        public override string getData()
        {
            return base.TypeAndProperties() + getPassenger();
        }

        public override string ToString()
        {
            return base.ToString() + "Class heirarchy: Car // Wheels4 // Vehicle";
        }
    }
}
