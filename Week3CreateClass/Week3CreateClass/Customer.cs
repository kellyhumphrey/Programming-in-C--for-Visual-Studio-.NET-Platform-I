using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseClass
{
    internal class Customer
    {
        #region Fields

        public string contactName;
        private static int totalCompanies = 0;
        private string mCompanyName;
        private decimal mAnnualSales;
        #endregion End Fields

        #region Constructors
        public Customer()
        {
            mCompanyName = "Not assigned";
            mAnnualSales = 0;
            contactName = "Not assigned";
            totalCompanies++;
        }
        public Customer(string name, decimal sales, string contactName)
        {
            mCompanyName = name;
            mAnnualSales = sales;
            this.contactName = contactName;
            totalCompanies++;
        }
        #endregion End Constructors

        #region Properties
        public string CompanyName
        {
            get
            {
                return mCompanyName;
            }
        }
        public decimal AnnualSales
        {
            get
            {
                return mAnnualSales;
            }
            set
            {
                if (value >= 0)
                {
                    mAnnualSales = value;
                }
                else
                {
                    mAnnualSales = 0;
                }
            }
        }
        #endregion Properties

        #region Methods
        public decimal NewSales(decimal amount)
        {
            if (amount >= 0)
            {
                return mAnnualSales += amount;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return "Customer Data: \n\t" +
            "Company Name: " + mCompanyName + "\n\t" +
            "Annual Sales: " + mAnnualSales.ToString("C") + "\n\t" +
            "Contact Name: " + contactName + "\n\n\t\t" +
            "Total number of Companies: " + totalCompanies + "\n";
        }
        #endregion End Methods
    }
}
