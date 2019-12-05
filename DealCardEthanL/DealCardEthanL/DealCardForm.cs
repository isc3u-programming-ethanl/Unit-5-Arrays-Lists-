/*
 * Created by: Ethan L
 * Created on: 12/03/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #40 - Deal Card
 * This program displays 6 picture boxes, and when one of them is clicked, it will shuffle through all 52 cards in a deck.
 * When there is no cards left, it will say no more cards and reshuffle the deck.
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

namespace DealCardEthanL
{
    public partial class frmDealCard : Form
    {
        // create global lists
        List<Image> listOfImages = new List<Image>();
        List<int> listOfValues = new List<int>();

        public frmDealCard()
        {
            InitializeComponent();
        }

        private int DealCard(ref PictureBox pic, int randomIndex)
        {
            // Declare local variables
            int cardValue;
            Image card;

            // Get the card image from randomIndex
            card = listOfImages[randomIndex];

            // Put the card Image in the picture box pass by reference
            picCard1.Image = card;
            picCard2.Image = card;
            picCard3.Image = card;
            picCard4.Image = card;
            picCard5.Image = card;
            picCard6.Image = card;

            // Remove the image from the listOfImages
            listOfImages.RemoveAt(randomIndex);

            // Get the value of the card at the random value
            cardValue = listOfValues[randomIndex];

            // Remove value from listOfValues
            listOfValues.RemoveAt(randomIndex);

            // Return cardValue
            return cardValue;

        }
        private void PicCard1_Click(object sender, EventArgs e)
        {

        }

        private void PicCard2_Click(object sender, EventArgs e)
        {

        }

        private void PicCard3_Click(object sender, EventArgs e)
        {

        }

        private void PicCard4_Click(object sender, EventArgs e)
        {

        }

        private void PicCard5_Click(object sender, EventArgs e)
        {

        }

        private void PicCard6_Click(object sender, EventArgs e)
        {

        }
    }
}
