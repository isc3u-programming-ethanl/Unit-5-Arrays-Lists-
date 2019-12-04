/*
 * Created by: Ethan L
 * Created on: 12/01/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program gets numbers from the user (in a text box) and adds them to a list box.
 * It then calculates the average and displays it in a label
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAverageEthanL
{
    public partial class frmListAverage : Form
    {
        // create global list
        List<int> myListOfIntegers = new List<int>();

        public frmListAverage()
        {
            InitializeComponent();
        }

        private int CalculateAverage(ref List<int> listOfInts)
        {
            // declare local variables
            int average = 0;
            int sum = 0;
            int counter;

            // calculate the sum of all the values in the list
            for (counter = 0; counter < listOfInts.Count; counter++)
            {
                sum = sum + listOfInts[counter];
            }

            // calculate the average of the values in the list
            average = sum / listOfInts.Count;

            return average;
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userMark = -1;


            // convert the value in the textbox to an integer
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            // if the user did not enter a valid number, write the error to the command line
            catch (Exception parseError)
            {
                Console.WriteLine("An error occurred: '{0}'", parseError);
            }
            // check if the user entered a number between 0 and 100
            if ( (userMark >= 0) && (userMark <= 100 ) )
            {
                // add the mark to the listbox
                this.lstNumbers.Items.Add(userMark);

                // add the mark to the list
                myListOfIntegers.Add(userMark);
            }
            // otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            int average;

            // if the amount of elements in the list is 0
            if (myListOfIntegers.Count == 0)
            {
                MessageBox.Show("Please enter a valid mark", "Invalid Number");
            }
            else
            {
                // call the function
                average = CalculateAverage(ref myListOfIntegers);
                // display the average in a label
                this.lblAnswer.Text = "The Average Is: " + average;
            }

        }
    }
}
