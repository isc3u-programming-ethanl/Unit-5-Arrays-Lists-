/*
 * Created by: Ethan L
 * Created on: 12/04/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #41 - File Read/Write
 * This program...
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

namespace FileReadWriteEthanL
{
    public partial class frmFileReadWrite : Form
    {
        public frmFileReadWrite()
        {
            InitializeComponent();
        }

        private bool StringsAreEqual(String one, String two)
        {
            // declare local variables
            bool isEqual = false;

            string string1;
            string string2;

            string1 = Convert.ToString(@"input.txt");
            string2 = Convert.ToString(@"input.txt");

            int length1;
            int length2;

            length1 = string1.Length;
            length2 = string2.Length;

            if (length1 == length2)
            {
                string1.ToUpper();
                string2.ToUpper();

                string1 = one;
                string2 = two;
            }
            if (string1 == string2)
            {
                isEqual = true;
                this.lblAnswer.Text = "These strings are equal.";
                this.lblAnswer.Show();
            }
            else
            {
                this.lblAnswer.Text = "These strings are NOT equal.";
                this.lblAnswer.Show();
            }
            return isEqual;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // Read each line of the file into a string array. Each element
            // of the array is on line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            // array of characters that I want to take out when I split the line into words (spaces, tabs)
            char[] charSeparators = new char[] { ' ', '\t' };

            // the output string where I will put my results
            string output = "";

            // go through and compare each string on each line of the file
            foreach (string line in lines)
            {
                // split each line into words and put them into an array. I am assuming there are only
                // two words on the line
                string[] words = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (StringAreEqual(words[0], words[1]) == true)
                {
                    // concatenate the output to the string. There must be \r\n so that it goes onto a new line in the text file
                    output = output + "True\r\n";
                }
                else
                {
                    // concatenate the output to the string. There must be \r\n so that it goes onto a new line in the text file
                    output = output + "False\r\n";
                }
            }

            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file. You do NOT need to call Flush() or Close().
            // If the file already exists, it overwrites the file
            System.IO.File.WriteAllText(@"output.txt", output);

            // show the label notifying the user that the process is done
            this.lblOutput.Show();

            string one;
            string two;

            one = Convert.ToString(this.txtString1);
            two = Convert.ToString(this.txtString2);
        }
    }
}
