/*
 * Created by: Allison Cook
 * Created on: 15 february, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - BookGenre
 * This program shows books under a certain genre when the menu item is clicked
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

namespace BookGenreAllisonC
{
    public partial class frmBookGenre : Form
    {
        public frmBookGenre()
        {
            InitializeComponent();
        }

        private void mniFantasy_Click(object sender, EventArgs e)
        {
            //when this menu item is clicked it changes the book titles
            lblBookGenre.Text = "Fantasy";
            lblBook1.Text = "1. A Court of Thorns and Roses";
            lblBook2.Text = "2. Throne of Glass";
            lblBook3.Text = "3. Red Queen";
        }

        private void mniHorror_Click(object sender, EventArgs e)
        {
            //when this menu item is clicked it changes the book titles
            lblBookGenre.Text = "Horror";
            lblBook1.Text = "1. Ms Peregrine's Home for Peculiar Children";
            lblBook2.Text = "2. IT";
            lblBook3.Text = "3. Omens";
        }

        private void mniMystery_Click(object sender, EventArgs e)
        {
            //when this menu item is clicked it changes the book titles
            lblBookGenre.Text = "Mystery";
            lblBook1.Text = "1. Fallen";
            lblBook2.Text = "2. The Body in the Woods";
            lblBook3.Text = "3. Paper Towns";
        }

        private void mniAction_Click(object sender, EventArgs e)
        {
            //when this menu item is clicked it changes the book titles
            lblBookGenre.Text = "Action";
            lblBook1.Text = "1. City of Bones";
            lblBook2.Text = "2. Possion Princess";
            lblBook3.Text = "3. Lord of the Rings";
        }
    }
}
