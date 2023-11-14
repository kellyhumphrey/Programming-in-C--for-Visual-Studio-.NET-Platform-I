using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatesCandyStore_HumphreyKelly
{
    public partial class ChocolateForm : Form
    {
        private string name;
        private double quantity;
        private double candyCost;
        private double extendedCost;

        public ChocolateForm()
        {
            InitializeComponent();
        }

        private void ChocolateForm_Load(object sender, EventArgs e)
        {
            string[] candyArray = new string[3];

            candyArray[0] = "Dark  ($1.00)";
            candyArray[1] = "Milk  ($1.25)";
            candyArray[2] = "White  ($1.50)";

            for (int i = 0; i < 3; i++)
            {
                ChocolateComboBox.Items.Add(candyArray[i]);
            }
            ChocolateNameLabel.Text = name + " selected:";

        }



        private void ChocolateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChocolateChoiceLabel.Text = ChocolateComboBox.Text;
        }

        private void chocolateQtyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(ChocolateComboBox.SelectedIndex == 0)
            {
                candyCost = 1.00;
            }
            else if (ChocolateComboBox.SelectedIndex == 1)
            {
                candyCost = 1.25;
            }
            else if (ChocolateComboBox.SelectedIndex == 2)
            {
                candyCost = 1.50;
            }

            quantity = Double.Parse(chocolateQtyComboBox.Text);
            extendedCost = quantity * candyCost;
            ExtCostLabel.Text = "$" + extendedCost.ToString();
        }        

        public string getCandy()
        {
            return ChocolateComboBox.Text;
        }

        public string getQuantity()
        {
            return chocolateQtyComboBox.Text;
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







        //Disregard all methods below
        private void StaticChocLabel4_Click(object sender, EventArgs e)
        {
            //Pass - Method accidently created via doubleclick on design tab
        }
        private void ChocolateChoiceLabel_Click(object sender, EventArgs e)
        {
            //Pass - Method accidently created via doubleclick on design tab
        }
        private void ChocolateNameLabel_Click(object sender, EventArgs e)
        {
            //Pass - Method accidently created via doubleclick on design tab
        }
        private void StaticLabel4_Click(object sender, EventArgs e)
        {
            //Pass - Method accidently created via doubleclick on design tab
        }
    }
}
