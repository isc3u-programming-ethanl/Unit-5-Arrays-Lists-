/*
 * Created by: Ethan L
 * Created on: 12/04/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #41 - File Read/Write
 * This program compares 2 strings line by line in an "input.txt" file. 
 * It will output to an "output.txt" file saying line by line "True" meaning equal. OR "False" meaning not equal.
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

        public bool StringsAreEqual(String one, String two)
        {
            // declare local variables
            bool isEqual = false;

            string string1;
            string string2;

            int length1;
            int length2;

            length1 = one.Length;
            length2 = two.Length;

            // if the length of the first string is equal to the length of the second string
            // convert string1 and string2 to uppercase (or lowercase)
            if (length1 == length2)
            {
                string1 = one.ToUpper();
                string2 = two.ToUpper();

                // if string1 is equal to string2
                if (string1 == string2)
                {
                    // set isEqual to true
                    isEqual = true;
                }
            }
            // return the isEqual value
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

                if (StringsAreEqual(words[0], words[1]) == true)
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
            
        }

        private void FrmFileReadWrite_Load(object sender, EventArgs e)
        {
            this.lblOutput.Hide();
        }
    }
}
