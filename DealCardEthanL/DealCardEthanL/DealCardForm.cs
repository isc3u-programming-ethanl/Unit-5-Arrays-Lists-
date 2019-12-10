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
        // create global list of card images
        List<Image> listOfCardImages = new List<Image>();

        // create random number generator
        Random randomNumberGenerator;

        public frmDealCard()
        {
            // generate the randomNumberGenerator object
            randomNumberGenerator = new Random();

            InitializeComponent();
        }
        private void NewDeck()
        {
            // clear the image and card value lists
            listOfCardImages.Clear();

            // set the picture boxes to the red_back picture
            this.picCard1.Image = Properties.Resources.yellow_back;
            this.picCard2.Image = Properties.Resources.yellow_back;
            this.picCard3.Image = Properties.Resources.yellow_back;
            this.picCard4.Image = Properties.Resources.yellow_back;
            this.picCard5.Image = Properties.Resources.yellow_back;
            this.picCard6.Image = Properties.Resources.yellow_back;

            // add the card images to the card image list
            listOfCardImages.Add(Properties.Resources._2C);
            listOfCardImages.Add(Properties.Resources._2D);
            listOfCardImages.Add(Properties.Resources._2H);
            listOfCardImages.Add(Properties.Resources._2S);
            listOfCardImages.Add(Properties.Resources._3C);
            listOfCardImages.Add(Properties.Resources._3D);
            listOfCardImages.Add(Properties.Resources._3H);
            listOfCardImages.Add(Properties.Resources._3S);
            listOfCardImages.Add(Properties.Resources._4C);
            listOfCardImages.Add(Properties.Resources._4D);
            listOfCardImages.Add(Properties.Resources._4H);
            listOfCardImages.Add(Properties.Resources._4S);
            listOfCardImages.Add(Properties.Resources._5C);
            listOfCardImages.Add(Properties.Resources._5D);
            listOfCardImages.Add(Properties.Resources._5H);
            listOfCardImages.Add(Properties.Resources._5S);
            listOfCardImages.Add(Properties.Resources._6C);
            listOfCardImages.Add(Properties.Resources._6D);
            listOfCardImages.Add(Properties.Resources._6H);
            listOfCardImages.Add(Properties.Resources._6S);
            listOfCardImages.Add(Properties.Resources._7C);
            listOfCardImages.Add(Properties.Resources._7D);
            listOfCardImages.Add(Properties.Resources._7H);
            listOfCardImages.Add(Properties.Resources._7S);
            listOfCardImages.Add(Properties.Resources._8C);
            listOfCardImages.Add(Properties.Resources._8D);
            listOfCardImages.Add(Properties.Resources._8H);
            listOfCardImages.Add(Properties.Resources._8S);
            listOfCardImages.Add(Properties.Resources._9C);
            listOfCardImages.Add(Properties.Resources._9D);
            listOfCardImages.Add(Properties.Resources._9H);
            listOfCardImages.Add(Properties.Resources._9S);
            listOfCardImages.Add(Properties.Resources._10C);
            listOfCardImages.Add(Properties.Resources._10D);
            listOfCardImages.Add(Properties.Resources._10H);
            listOfCardImages.Add(Properties.Resources._10S);
            listOfCardImages.Add(Properties.Resources.AC);
            listOfCardImages.Add(Properties.Resources.AD);
            listOfCardImages.Add(Properties.Resources.AH);
            listOfCardImages.Add(Properties.Resources.AS);
            listOfCardImages.Add(Properties.Resources.JC);
            listOfCardImages.Add(Properties.Resources.JD);
            listOfCardImages.Add(Properties.Resources.JH);
            listOfCardImages.Add(Properties.Resources.JS);
            listOfCardImages.Add(Properties.Resources.KC);
            listOfCardImages.Add(Properties.Resources.KD);
            listOfCardImages.Add(Properties.Resources.KH);
            listOfCardImages.Add(Properties.Resources.KS);
            listOfCardImages.Add(Properties.Resources.QC);
            listOfCardImages.Add(Properties.Resources.QD);
            listOfCardImages.Add(Properties.Resources.QH);
            listOfCardImages.Add(Properties.Resources.QS);

            // update the cards left text
            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();
        }
        private void DealCard(ref PictureBox picCard1, int randomIndex)
        {
            // Declare local variables
            Image card;
            randomIndex = randomNumberGenerator.Next(0, listOfCardImages.Count());

            // Get the card image from randomIndex
            card = listOfCardImages[randomIndex];

            // Put the card Image in the picture box pass by reference
            picCard1.Image = card;

            // Remove the image from the listOfImages
            listOfCardImages.RemoveAt(randomIndex);

            // Update the card total label
            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();
        }
        private void CheckForNoCards()
        {
            if (listOfCardImages.Count() == 0)
            {
                MessageBox.Show("Reshuffling the deck!", "Out Of Cards");
                NewDeck();
            }
        }
        private void PicCard1_Click(object sender, EventArgs e)
        {
            int card1 = 0;
            DealCard(ref picCard1, card1);
            CheckForNoCards();
        }
        private void PicCard2_Click(object sender, EventArgs e)
        {
            int card2 = 0;
            DealCard(ref picCard2, card2);
            CheckForNoCards();
        }
        private void PicCard3_Click(object sender, EventArgs e)
        {
            int card3 = 0;
            DealCard(ref picCard3, card3);
            CheckForNoCards();
        }
        private void PicCard4_Click(object sender, EventArgs e)
        {
            int card4 = 0;
            DealCard(ref picCard4, card4);
            CheckForNoCards();
        }
        private void PicCard5_Click(object sender, EventArgs e)
        {
            int card5 = 0;
            DealCard(ref picCard5, card5);
            CheckForNoCards();
        }
        private void PicCard6_Click(object sender, EventArgs e)
        {
            int card6 = 0;
            DealCard(ref picCard6, card6);
            CheckForNoCards();
        }
        private void FrmDealCard_Load(object sender, EventArgs e)
        {
            // update the cards left text
            this.lblCardTotal.Text = "Cards Left: " + listOfCardImages.Count();
            NewDeck();
        }
    }
}
