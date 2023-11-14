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
    public partial class MainForm : Form
    {
        string[] candyArray = new string[4];
        ChocolateForm chocoForm = new ChocolateForm();
        GumForm gForm = new GumForm();
        LollipopForm lForm = new LollipopForm();
        ExperimentalForm eForm = new ExperimentalForm();
        double totalCost;

        public MainForm()
        {
            InitializeComponent();
        }

        public void SelectCandyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCandyLabel.Text = SelectCandyComboBox.Text;
        }

        public void Main_Load(object sender, EventArgs e)
        {
            

            candyArray[0] = "Chocolate";
            candyArray[1] = "Gum";
            candyArray[2] = "Lollipops";
            candyArray[3] = "Experimental Candy...";
            
            for (int i = 0; i < 4; i++)
            {
                SelectCandyComboBox.Items.Add(candyArray[i]);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            //Pass
        }

        public void ProcessSelectionButton_Click(object sender, EventArgs e)
        {
            string nameString = NameTextBox.Text;
            string candyString = SelectCandyComboBox.Text;
            
            if (!string.IsNullOrEmpty(nameString))
            {
                if(candyString == "Chocolate")
                {
                    string name = NameTextBox.Text;
                    chocoForm.setName(name);
                    chocoForm.ShowDialog();
                    ChocSelectionLabel.Text = chocoForm.getCandy() + " - Ext Cost: $" + chocoForm.getExtendedCost();

                    totalCost = Double.Parse(chocoForm.getExtendedCost()) + Double.Parse(gForm.getExtendedCost()) + Double.Parse(lForm.getExtendedCost()) + Double.Parse(eForm.getExtendedCost());
                    TotalCostLabel.Text = "$" + totalCost.ToString();


                }

                else if(candyString == "Gum")
                {
                    string name = NameTextBox.Text;
                    gForm.setName(name);
                    gForm.ShowDialog();
                    GumSelectionLabel.Text = gForm.getCandy() + " - Ext Cost: $" + gForm.getExtendedCost();
                    totalCost = Double.Parse(chocoForm.getExtendedCost()) + Double.Parse(gForm.getExtendedCost()) + Double.Parse(lForm.getExtendedCost()) + Double.Parse(eForm.getExtendedCost());
                    TotalCostLabel.Text = "$" + totalCost.ToString();

                }

                else if (candyString == "Lollipops")
                {
                    string name = NameTextBox.Text;
                    lForm.setName(name);
                    lForm.ShowDialog();
                    LolSelectionLabel.Text = lForm.getCandy() + " - Ext Cost: $" + lForm.getExtendedCost();
                    totalCost = Double.Parse(chocoForm.getExtendedCost()) + Double.Parse(gForm.getExtendedCost()) + Double.Parse(lForm.getExtendedCost()) + Double.Parse(eForm.getExtendedCost());
                    TotalCostLabel.Text = "$" + totalCost.ToString();

                }

                else if (candyString == "Experimental Candy...")
                {
                    string name = NameTextBox.Text;
                    eForm.setName(name);
                    eForm.ShowDialog();
                    ExpSelectionLabel.Text = eForm.getCandy() + " - Ext Cost: $" + eForm.getExtendedCost();
                    totalCost = Double.Parse(chocoForm.getExtendedCost()) + Double.Parse(gForm.getExtendedCost()) + Double.Parse(lForm.getExtendedCost()) + Double.Parse(eForm.getExtendedCost());
                    TotalCostLabel.Text = "$" + totalCost.ToString();

                }
            }
        }


    }
}
