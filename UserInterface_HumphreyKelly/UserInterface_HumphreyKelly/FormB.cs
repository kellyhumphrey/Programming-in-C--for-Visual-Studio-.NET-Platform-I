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
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void FormB_Load(object sender, EventArgs e)
        {

        }

        private void callMessageBox1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox 1 has been activated... ");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void callMessageBox2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox 2 has been activated... ");
        }

        private void FormBExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
