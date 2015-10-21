using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterationDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int number =Convert.ToInt16(numberTextBox.Text);

            for(int i = 1; i <=number; i ++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
