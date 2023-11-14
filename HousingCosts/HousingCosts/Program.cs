using System;
using System.Windows.Forms;


namespace HousingCosts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal housePrice;
            decimal averageHousePrice;
            decimal totalHousePrices = 0;
            int count = 0;
            string output;
            int _myVariable = 10; 
            output = "House Price:\n";
            Console.Write("Enter house price (-1 to Quit): ");
            housePrice = Convert.ToDecimal(Console.ReadLine());
            while (housePrice != -1)
            {
                output += housePrice.ToString("C");
                totalHousePrices += housePrice;
                count++;
                if (housePrice < 350000)
                    output += "\t *";
                else
                    output += "\t ";
                output += "\n";
                Console.Write("Enter house price (-1 to Quit): ");
                housePrice = Convert.ToDecimal(Console.ReadLine());
            }
            averageHousePrice = totalHousePrices / count;
            output += "\nAverage Price: " + averageHousePrice.ToString("C");
            MessageBox.Show(output, "House Prices", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

        }
    }
}
