using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlour
{
    public partial class Form1 : Form
    {
        int pizzaPrice =7;
        double toppingsPrice =1.25;
        int toppingsAmount;
        double total;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)

        {
            try
            {
                toppingsAmount = Convert.ToInt32(toppingsTextbox.Text);
                total = pizzaPrice + toppingsPrice * toppingsAmount;

                priceLabel.Text = $"The price of the pizza with {toppingsAmount} toppings is {total}";
            }
            catch
            {

            }
        }

        private void NumberOfToppings_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
