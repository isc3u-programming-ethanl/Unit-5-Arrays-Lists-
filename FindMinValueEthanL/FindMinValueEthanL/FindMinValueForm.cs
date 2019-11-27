/*
 * Created by: Ethan L
 * Created on: 11/26/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - Find Min Value
 * This program randomly generates 10 numbers from 1-500.
 * It then stores them in a 10-slot array.
 * A function which traverses through the array and searches for the lowest value.
 * Whichever number is the lowest value, it will display the value in a label
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

namespace FindMinValueEthanL
{
    public partial class frmFindMinValue : Form
    {
        // declare global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        const int MAX_RANDOM_NUMBER = 500;

        public frmFindMinValue()
        {
            InitializeComponent();
        }

        // Function: GetMaxValue
        // Input: int[] tmpArrayOfIntegers - assume all values in the array are greater than 0
        // Output: the max value in the array
        // Description: This function accepts an array of integers, scans the array and returns the greatest value in the array
        private int GetMinValue(int[] tmpArrayOfIntegers)
        {
            int tmpMinValue = -1;
            int counter;

            for (counter = 0; counter < 10; counter++)
            {
                // if the tmpMaxValue is less than the array(counter)
                if (tmpMinValue < tmpArrayOfIntegers[counter])
                {
                    // set the tmpMaxValue to the Min Value to the array[counter]
                    tmpMinValue = tmpArrayOfIntegers.Min();
                }
            }
            // return the tmpMaxValue value
            return tmpMinValue;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;

            Random randomNumberGenerator = new Random();

            // clear list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number between 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                // assign the random number to the cell at position "counter" in the array
                arrayOfIntegers[counter] = randomNumber;

                // add the random number to the list
                this.lstNumbers.Items.Add(randomNumber);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }
            // get the max value in the array
            minValue = GetMinValue(arrayOfIntegers);

            // display the max value in the label
            this.lblMinValue.Text = "The min value is: " + minValue;
        }
    }
}
