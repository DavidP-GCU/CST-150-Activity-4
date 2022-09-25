using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class activity4 : Form
    {
        public activity4()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Create Variables
            double seconds; // User Input in seconds. 
            double total; // Total after conversion. 

            //Gather Data from user. 
            seconds = double.Parse(userInputSeconds.Text);

            // Create If-Else-If Statement
            if (seconds >= 60 && seconds < 3600)
            {
                total = seconds / 60; // Convert user seconds to minutes. 

                userTotal.Text = total.ToString(); //userTotal.Text = double.TryParse(userTotal.Text, out);
            }
            else if (seconds >= 3600 && seconds < 86400) 
            {
                total = seconds / 3600; // Convert user seconds to hours. 
                userTotal.Text = total.ToString();
            }
            else if (seconds >= 86400)
            {
                total = seconds / 86400; // Convert user seconds to days. 
                userTotal.Text = total.ToString();
            }
            else // If user inputs number below 60. 
            {
                MessageBox.Show("Please enter a number that is equal to or greater than 60");

            }

        }
    }
}
