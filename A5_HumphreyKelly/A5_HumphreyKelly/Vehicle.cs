using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_HumphreyKelly
{
    public abstract class Vehicle
    {
        protected string inventoryID;
        protected string companyName;
        protected string modelName;
        private int productionYear;
        private decimal salesPrice;
        private static int creationTracker = 0;

        public Vehicle(string inventoryID, string companyName, string modelName, int productionYear, decimal salesPrice)
        {
            this.inventoryID = inventoryID; 
            this.companyName = companyName;
            this.modelName = modelName; 
            this.productionYear = productionYear;   
            this.salesPrice = salesPrice;
            creationTracker++;
        }

        public string getHeader()
        {
            return "\nVehicle information Report\nIventory ID \t\t Company Name \t\t Model Name \t\t Production Year \t Sales Price \t Additional Infomration";
        }
        public string getProperties()
        {
            return "\n" + inventoryID + "\t\t\t" + companyName + "\t\t\t" + modelName + "\t\t\t" + productionYear + "\t\t\t" + salesPrice.ToString("C");
        }
        
        public override string ToString()
        {
            return "Vehicles created: " + creationTracker + ". ";
        }

        public abstract string getData();
    }
}
