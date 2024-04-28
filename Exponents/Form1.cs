using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Zulisa Rodriguez
 * Date: 04/28/2024
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE

            // INPUT

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */

            // OUTPUT
            // set the output to visible

            // turn the Go button off
            if (int.TryParse(xInputTextBox.Text, out int number))
            {
                // PROCESS
                int squaredNumber = Square(number);
                int cubedNumber = Cube(number);

                // OUTPUT
                xOutputLabel.Text = $"Square: {squaredNumber}, Cube: {cubedNumber}";
                xOutputLabel.Visible = true;

                // turn the Go button off
                xGoButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        public int Square(int num)
        {
           
        }

        public int Cube(int num)
        {
            
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            // turn the output to invisible
            // turn the Go button back on
            
        }

    }
}
