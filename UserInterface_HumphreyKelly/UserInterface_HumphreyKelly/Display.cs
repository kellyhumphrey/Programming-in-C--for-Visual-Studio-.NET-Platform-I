using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface_HumphreyKelly
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Display_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormA myFormA = new FormA();
            myFormA.Show();
        }

        private void formBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormB myFormB = new FormB();
            myFormB.ShowDialog();
        }

        private void callAMessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox (from Diplay form) has been activated... ");
        }
    }
}
