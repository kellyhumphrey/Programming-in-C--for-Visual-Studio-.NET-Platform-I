using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_HumphreyKelly
{
    public class Bicycle : Wheels2
    {
        private Boolean HasAirPump;

        public Bicycle(string inventoryID, string companyName, string modelName, int productionYear, decimal salesPrice, Boolean HasAirPump)
            :base(inventoryID, companyName, modelName, productionYear, salesPrice)
        {
            this.HasAirPump = HasAirPump;
            Console.WriteLine("A Bicyle class has been instantiated.");
        }
        public string getAirPump()
        {
            if (HasAirPump)
            {
                return "This bicyle has an air pump.";
            }
            else
            {
                return "This bicyle does not have an air pump.";
            }
        }

        public override string getData()
        {
            return base.TypeAndProperties() + getAirPump();
        }

        public override string ToString()
        {
            return base.ToString() + "Class heirarchy: Bicycle // Wheels2 // Vehicle ";
        }
    }
}
