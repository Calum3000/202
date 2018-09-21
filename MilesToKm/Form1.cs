using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int userinput = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // changes the label text for distance in kilometres
            label2.Text = "Distance in kilometres is";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // changes the label text for distance in kilometres
            label2.Text = "Distance in miles is";
        }

        private void button1_Click(object sender, EventArgs e)
        {   

            // gets user input (will need to be int for conversion)
            userinput = Convert.ToInt32(textBox1.Text);
            // convert 
            userinput = Convert.ToInt32(userinput * 1.60934);
            // displays the user input
            label2.Text = "Distance in kilometres is " +  userinput.ToString("N2");
        }
    }
}
