using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateVehicle_KellyHumphrey
{
    internal class Vehicle
    {
        #region Fields
        public string carCompany;
        public string model;
        
        private int yearMade;
        private decimal salesPrice;
        private string VIN;
        private DateTime dateReceived;
        private static int numberVehiclesCreated = 1;
        private bool availableForSale;
        private string sold;
        

        #endregion End Fields

        #region Constructors

        public Vehicle() : this("Not Specified", "Not Specified", 0, (decimal) 0.00, "Not Specified")
        {
            this.availableForSale = true;
            this.sold = newSale(availableForSale);

            this.dateReceived = DateTime.Now;
            numberVehiclesCreated++;
        }
        
        public Vehicle(string carCompany, string model, int yearMade, decimal salesPrice, string VIN)
        {
            this.carCompany = carCompany;
            this.model = model;
            this.availableForSale = true;
            this.sold = newSale(availableForSale);

            //use properties to perform checks before assigning values to code
            this.yearMade = newYearMade(yearMade); //return 0 if not in valide date range (1990 to current year)
            this.salesPrice = newSalesPrice(salesPrice); //return decimal value of 0.00 if input is less than 0.00 
            this.VIN = newVIN(VIN); //return "illegal, check" if character length of input string is not 17

            this.dateReceived = DateTime.Now;
            numberVehiclesCreated++;
        }

        #endregion End Constructors

        #region Properties
        public int newYearMade(int yearMade) 
        {
            if (yearMade >= 1990 || yearMade <= Int32.Parse(DateTime.Now.Year.ToString()))
            {
                return this.yearMade = yearMade;
            }
            else
            {
                return this.yearMade = 0;
            }
        }

        public decimal newSalesPrice(decimal salesPrice)
        {
            if (salesPrice >= (decimal) 0.00)
            {
                return salesPrice;
            }
            else
            {
                return (decimal) 0.00;
            }
        }

        public string newVIN(string VIN)
        {
            if (VIN.Length == 17)
            {
                return VIN;
            }
            else
            {
                return "Illegal, check";
            }
        }

        public string newSale(bool availableForSale)
        {
            if (availableForSale)
            {
                return "No";
            }
            else
            {
                return "Yes";
            }
        }

        #endregion End Properties

        #region Methods
        public override string ToString()
        {
            return "Car Company \t\t Model \t\t Year Made \t\t Sales Price \t\t VIN \t\t Date Received \t\t Sold \n"
                + carCompany + "\t\t" + model + "\t\t" + yearMade + "\t\t" + string.Format("{0:C}", salesPrice) + "\t\t" + VIN + "\t\t" + dateReceived + "\t\t" + sold;
        }

        public string totalNumberOfCars()
        {
            return "Total Number of cars created:  " + numberVehiclesCreated;
        }

        public string buyCar()
        {
            availableForSale = false;
            sold = newSale(availableForSale);

            return "Car Company \t\t Model \t\t Year Made \t\t Sales Price \t\t VIN \t\t Date Received \t\t Sold \n"
                + this.carCompany + "\t\t" + this.model + "\t\t" + this.yearMade + "\t\t" + string.Format("{0:C}", this.salesPrice) + "\t\t" + this.VIN + "\t\t" + this.dateReceived + "\t\t" + this.sold;
        }

        

        #endregion End Methods

    }
}
 