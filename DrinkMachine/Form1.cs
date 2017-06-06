using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
  Spencer Henze
  ITM 225
  Homework 7
  10/31/16
 */
namespace DrinkMachine
{
    struct Soda
    {
        public string sodaName;
        public double price;
        public int drinksLeft;
    } // end Soda structure declaration

    
    public partial class Form1 : Form
    {

        public double totalSales = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //declare an array to hold the drink objects so that their properties can be called on
        const int SIZE = 5;
        Soda[] inventory = new Soda[SIZE];
        
        //begin writing code for the different selections:
        private void colaImage_Click(object sender, EventArgs e)
        {
            if (inventory[0].drinksLeft > 0) //checks to make sure there are drinks available before continuing
            {
                Soda cola = new Soda(); // make a new object from the "Soda" structure and name it "cola"
                cola.drinksLeft = inventory[0].drinksLeft; // set the "drinksLeft" property for the "cola" object equal to the index value that was set in the form load event.
                cola.sodaName = "Cola";
                cola.price = 1.00;
                inventory[0].drinksLeft--; //decrease the number of cola drinks left

                //Display drinks left
                colaDisplayLabel.Text = inventory[0].drinksLeft.ToString();
                //add price to, and display totalSales
                totalSales = totalSales + cola.price;
                salesDisplayLabel.Text = totalSales.ToString("C");

                //Let the user know the item is vending
                MessageBox.Show("Great Choice! Your " + cola.sodaName + " is vending.\nMake another selection or click 'Exit' to finish.", "Vending", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else //if there are no more drinks available of the selected type, display this message.
            {
                MessageBox.Show("Oh no! Looks like that one's sold out.\nTry another selection", "Sold Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        } // end cola click event (process repeated for each item)

        private void lemonLimeImage_Click(object sender, EventArgs e)
        {
            if (inventory[1].drinksLeft > 0) //Checks to see if there are drinks available
            {
                Soda lemLime = new Soda();
                lemLime.drinksLeft = inventory[1].drinksLeft;
                lemLime.sodaName = "Lemon Lime";
                lemLime.price = 1.00;
                inventory[1].drinksLeft--;

                //Display drinks left
                lemonLimeDisplayLabel.Text = inventory[1].drinksLeft.ToString();
                //add price to and display totalSales
                totalSales = totalSales + lemLime.price;
                salesDisplayLabel.Text = totalSales.ToString("C");

                MessageBox.Show("Ahh, so refreshing! Your " + lemLime.sodaName + " is vending.\nMake another selection or click 'Exit' to finish.", "Vending", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Oh no! Looks like that one's sold out.\nTry another selection", "Sold Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }



        } // end Lemon Lime click event

        private void rootBeerImage_Click(object sender, EventArgs e)
        {
            if (inventory[2].drinksLeft > 0)
            {
                Soda rootBeer = new Soda();
                rootBeer.drinksLeft = inventory[2].drinksLeft;
                rootBeer.sodaName = "Root Beer";
                rootBeer.price = 1.00;
                inventory[2].drinksLeft--;

                //Display drinks left
                rootBeerDisplayLabel.Text = inventory[2].drinksLeft.ToString();
                //add price to and display totalSales
                totalSales = totalSales + rootBeer.price;
                salesDisplayLabel.Text = totalSales.ToString("C");

                MessageBox.Show("Classic choice! Your " + rootBeer.sodaName + " is vending.\nMake another selection or click 'Exit' to finish.", "Vending", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Oh no! Looks like that one's sold out.\nTry another selection", "Sold Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }



        } // end Root Beer click event

        private void grapeSodaImage_Click(object sender, EventArgs e)
        {
            if (inventory[3].drinksLeft > 0)
            {
                Soda grapeSoda = new Soda();
                grapeSoda.drinksLeft = inventory[3].drinksLeft;
                grapeSoda.sodaName = "Grape Soda";
                grapeSoda.price = 1.50;
                inventory[3].drinksLeft--;

                //Display drinks left
                grapeDisplayLabel.Text = inventory[3].drinksLeft.ToString();
                //add price to and display totalSales
                totalSales = totalSales + grapeSoda.price;
                salesDisplayLabel.Text = totalSales.ToString("C");

                MessageBox.Show("Fun choice! Your " + grapeSoda.sodaName + " is vending.\nMake another selection or click 'Exit' to finish.", "Vending", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Oh no! Looks like that one's sold out.\nTry another selection", "Sold Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        } // end Grape Soda click event

        private void creamSodaImage_Click(object sender, EventArgs e)
        {
            if (inventory[4].drinksLeft > 0)
            {
                Soda creamSoda = new Soda();
                creamSoda.drinksLeft = inventory[4].drinksLeft;

                creamSoda.sodaName = "Cream Soda";
                creamSoda.price = 1.50;
                inventory[4].drinksLeft--;

                //Display drinks left
                creamSodaDisplayLabel.Text = inventory[4].drinksLeft.ToString();
                //add price to and display totalSales
                totalSales = totalSales + creamSoda.price;
                salesDisplayLabel.Text = totalSales.ToString("C");

                MessageBox.Show("Sweet choice! Your " + creamSoda.sodaName + " is vending.\nMake another selection or click 'Exit' to finish.", "Vending", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Oh no! Looks like that one's sold out.\nTry another selection", "Sold Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        } // end Cream Soda click event

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int index = 0; index < inventory.Length; index++) // steps through the loop and set each object's "drinksLeft" property to 20.
            {
                inventory[index].drinksLeft = 20;
            } // end of loop

            //Display the value in its respective label.
            colaDisplayLabel.Text = inventory[0].drinksLeft.ToString();
            lemonLimeDisplayLabel.Text = inventory[1].drinksLeft.ToString();
            rootBeerDisplayLabel.Text = inventory[2].drinksLeft.ToString();
            grapeDisplayLabel.Text = inventory[3].drinksLeft.ToString();
            creamSodaDisplayLabel.Text = inventory[4].drinksLeft.ToString();
            salesDisplayLabel.Text = totalSales.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
