using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEqualityEthan
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }

        private bool StringsAreEqual(String one, String two)
        {
            // declare local variables
            bool isEqual = false;

            string string1;
            string string2;

            string1 = Convert.ToString(this.txtString1);
            string2 = Convert.ToString(this.txtString2);

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
            string one;
            string two;

            one = Convert.ToString(this.txtString1);
            two = Convert.ToString(this.txtString2);

            StringsAreEqual(one, two);
        }
    }
}
