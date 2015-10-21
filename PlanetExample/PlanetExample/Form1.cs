using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showPlanetNumberButton_Click(object sender, EventArgs e)
        {
            string planetName = planetNameComboBox.Text;

            if(planetName == "Planet")
            {
                MessageBox.Show("It is third position planet");
            }
            else if(planetName == "Satan")
            {
                MessageBox.Show("It is 6th position satan");
            }
            else if(planetName == "Mars")
            {
                MessageBox.Show("It is 4th position Mars");
            }
            else
            {
                MessageBox.Show("Unknown planet here ... ");
            }


        }
    }
}
