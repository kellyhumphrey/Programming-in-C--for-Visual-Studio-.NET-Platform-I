using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GatesCandyStore_HumphreyKelly
{
    public partial class ExperimentalForm : Form
    {
        private string name;
        private double quantity;
        private double candyCost;
        private double extendedCost;

        public ExperimentalForm()
        {
            InitializeComponent();
        }

        private void ExperimentalForm_Load(object sender, EventArgs e)
        {
            string[] candyArray = new string[3];

            candyArray[0] = "Everlasting Gobstoppers ($199.99)";
            candyArray[1] = "Hair Toffee ($299.99)";
            candyArray[2] = "Three Course Dinner Chewing Gum ($399.99)";

            for (int i = 0; i < 3; i++)
            {
                candyComboBox.Items.Add(candyArray[i]);
            }
            nameLabel.Text = name + " selected:";
        }

        private void candyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            choiceLabel.Text = candyComboBox.Text;
        }

        private void quantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (candyComboBox.SelectedIndex == 0)
            {
                candyCost = 199.99;
            }
            else if (candyComboBox.SelectedIndex == 1)
            {
                candyCost = 299.99;
            }
            else if (candyComboBox.SelectedIndex == 2)
            {
                candyCost = 399.99;
            }

            quantity = Double.Parse(quantityComboBox.Text);
            extendedCost = quantity * candyCost;
            extendedCostLabel.Text = "$" + extendedCost.ToString();
        }

        public string getCandy()
        {
            return candyComboBox.Text;
        }

        public string getQuantity()
        {
            return quantityComboBox.Text;
        }

        public string getExtendedCost()
        {
            return extendedCost.ToString();
        }

        public void setName(string buyerName)
        {
            name = buyerName;
        }

        private void chocolateButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
