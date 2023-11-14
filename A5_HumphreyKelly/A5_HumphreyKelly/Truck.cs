using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_HumphreyKelly
{
    internal class Truck : Wheels4
    {
        int truckLoad;
        public Truck(string inventoryID, string companyName, string modelName, int productionYear, decimal salesPrice, int truckLoad)
        : base(inventoryID, companyName, modelName, productionYear, salesPrice)
        {
            this.truckLoad = truckLoad;
            Console.WriteLine("A Car class has been instantiated.");
        }

        public string getTruckLoad()
        {
            return "This truck can carry up to " + truckLoad + " pounds.";
        }

        public override string getData()
        {
            return base.TypeAndProperties() + getTruckLoad();
        }

        public override string ToString()
        {
            return base.ToString() + "Class heirarchy: Car // Wheels4 // Vehicle";
        }
    }
}
