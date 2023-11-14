using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace A5_HumphreyKelly
{
    public abstract class Wheels2 : Vehicle
    {
        public Wheels2(string inventoryID, string companyName, string modelName, int productionYear, decimal salesPrice) 
            : base(inventoryID, companyName, modelName, productionYear, salesPrice)
        {
            
        }

        public string vehicleType()
        {
            return "This is a 2-wheel vehicle.";
        }

        public string TypeAndProperties()
        {
            return base.getProperties() + "\t" + "This is a 2-wheel vehicle.";
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string getData()
        {
            return "This is a Wheels2 Class";
        }
    }
}
