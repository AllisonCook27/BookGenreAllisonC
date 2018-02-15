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
            lblBook1.Text = "hello";
            lblBook2.Text = "hello";
            lblBook3.Text = "hello";
        }

        private void mniHorror_Click(object sender, EventArgs e)
        {
            //when this menu item is clicked it changes the book titles
            lblBook1.Text = "hello";
            lblBook2.Text = "hello";
            lblBook3.Text = "hello";
        }

        private void mniMystery_Click(object sender, EventArgs e)
        {
            //when this menu item is clicked it changes the book titles
            lblBook1.Text = "hello";
            lblBook2.Text = "hello";
            lblBook3.Text = "hello";
        }

        private void mniAction_Click(object sender, EventArgs e)
        {
            //when this menu item is clicked it changes the book titles
            lblBook1.Text = "hello";
            lblBook2.Text = "hello";
            lblBook3.Text = "hello";
        }
    }
}
