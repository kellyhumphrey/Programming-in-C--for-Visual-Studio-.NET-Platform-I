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
    public partial class GumForm : Form
    {
        private string name;
        private double quantity;
        private double candyCost;
        private double extendedCost;

        public GumForm()
        {
            InitializeComponent();
        }

        private void Gum_Load(object sender, EventArgs e)
        {
            string[] candyArray = new string[3];

            candyArray[0] = "Double Trouble Bubble ($0.25)";
            candyArray[1] = "Rainbow Rumble ($0.35)";
            candyArray[2] = "Plain ($0.45)";

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
                candyCost = 0.25;
            }
            else if (candyComboBox.SelectedIndex == 1)
            {
                candyCost = 0.35;
            }
            else if (candyComboBox.SelectedIndex == 2)
            {
                candyCost = 0.45;
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
