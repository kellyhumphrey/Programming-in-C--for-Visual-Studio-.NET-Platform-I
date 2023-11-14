using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_HumphreyKelly
{
    public class Motorcycle : Wheels2
    {
        Boolean offRoad;

        public Motorcycle(string inventoryID, string companyName, string modelName, int productionYear, decimal salesPrice, Boolean offRoad)
            : base(inventoryID, companyName, modelName, productionYear, salesPrice)
        {
            this.offRoad = offRoad;
            Console.WriteLine("A Motorcycle class has been instantiated.");
        }

        public string getOffRoad()
        {
            if (offRoad)
            {
                return "This motorcycle is designed for offroad usage.";
            }
            else
            {
                return "This motorcycle is NOT designed for offroad usage.";
            }
        }

        public override string getData()
        {
            return base.TypeAndProperties() + getOffRoad();
        }

        public override string ToString()
        {
            return base.ToString() + "Class heirarchy: Motorcycle // Wheels2 // Vehicle";
        }
    }
}
