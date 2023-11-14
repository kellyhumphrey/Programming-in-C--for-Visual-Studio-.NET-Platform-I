using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_UsingEnums
{
    public partial class Main : Form
    {
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
        public enum Months: byte { January,February,March,April,May,June,July,August,
        September,October,Novemenber,December};
        

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DayComboBox.Items.Add(Day.Monday);
            DayComboBox.Items.Add(Day.Tuesday);
            DayComboBox.Items.Add(Day.Wednesday);
            DayComboBox.Items.Add(Day.Thursday);
            DayComboBox.Items.Add(Day.Friday);
            DayComboBox.Items.Add(Day.Saturday);
            DayComboBox.Items.Add(Day.Sunday);
        }

        private void DayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayMenuResultLabel.Text = DayComboBox.SelectedItem.ToString();
        }

        private void UseEnumButton_Click(object sender, EventArgs e)
        {
            Months aMonth = Months.December;
            int theDay = (int)aMonth;

            MessageBox.Show("The month is " + Months.December.ToString() +
                " = the number " + theDay.ToString());

            switch(aMonth)
            {
                case Months.January:
                    MessageBox.Show("January was chosen...");
                    break;
                case Months.December:
                    MessageBox.Show("December was chosen...");
                    break;
            }
        }
    }
}
