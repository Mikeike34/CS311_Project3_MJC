using System.DirectoryServices.ActiveDirectory;

namespace CS311_Project3_MJC
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {

        }

        float toppings = 0; //variable to keep track of the price of toppings selected
        String italianSausage = "";
        String pepperoni = "";
        String sausage = "";
        String canadianBacon = "";
        String onion = "";
        String greenPepper = "";
        String blackOlives = "";
        String greenOlives = "";
        String bananaPeppers = "";
        String jalepeno = "";
        String extraCheese = "";
        String mushroom = "";
        String pizzaSize = "none";
        String crustType = "No Crust";


        //Toppings and keeping track of their pricing
        private void chkItalian_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbItalian.Checked)
            {
                toppings = toppings + 2;
                italianSausage = "Spicy Italian Sausage\n";
            }
            if (!ckbItalian.Checked)
            {
                toppings = toppings - 2;
                italianSausage = "";
            }
        }

        private void ckbPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPepperoni.Checked)
            {
                toppings = toppings + 2;
                pepperoni = "Pepperoni\n";
            }
            if (!ckbPepperoni.Checked)
            {
                toppings = toppings - 2;
                pepperoni = "";
            }
        }

        private void ckbSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSausage.Checked)
            {
                toppings = toppings + 2;
                sausage = "Sausage\n";
            }
            if (!ckbSausage.Checked)
            {
                toppings = toppings - 2;
                sausage = "";
            }
        }

        private void ckbCanadianBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCanadianBacon.Checked)
            {
                toppings = toppings + 2;
                canadianBacon = "Canadian Bacon\n";
            }
            if (!ckbCanadianBacon.Checked)
            {
                toppings = toppings - 2;
                canadianBacon = "";
            }
        }

        private void ckbOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOnion.Checked)
            {
                toppings = toppings + 1;
                onion = "Onion\n";
            }
            if (!ckbOnion.Checked)
            {
                toppings = toppings - 1;
                onion = "";
            }
        }

        private void ckbGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGreenPepper.Checked)
            {
                toppings = toppings + 1;
                greenPepper = "Green Pepper\n";
            }
            if (!ckbGreenPepper.Checked)
            {
                toppings = toppings - 1;
                greenPepper = "";
            }
        }

        private void ckbBlackOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBlackOlives.Checked)
            {
                toppings = toppings + 1;
                blackOlives = "Black Olives\n";
            }
            if (!ckbBlackOlives.Checked)
            {
                toppings = toppings - 1;
                blackOlives = "";
            }
        }

        private void ckbGreenOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGreenOlives.Checked)
            {
                toppings = toppings + 1;
                greenOlives = "Green Olives\n";
            }
            if (!ckbGreenOlives.Checked)
            {
                toppings = toppings - 1;
                greenOlives = "";
            }
        }

        private void ckbBananaPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBananaPeppers.Checked)
            {
                toppings = toppings + 1;
                bananaPeppers = "Banana Peppers\n";
            }
            if (!ckbBananaPeppers.Checked)
            {
                toppings = toppings - 1;
                bananaPeppers = "";
            }
        }

        private void ckbJalepeno_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbJalepeno.Checked)
            {
                toppings = toppings + 1;
                jalepeno = "Jalepeno\n";
            }
            if (!ckbJalepeno.Checked)
            {
                toppings = toppings - 1;
                jalepeno = "";
            }
        }

        private void ckbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbExtraCheese.Checked)
            {
                toppings = toppings + 1;
                extraCheese = "Extra Cheese\n";
            }
            if (!ckbExtraCheese.Checked)
            {
                toppings = toppings - 1;
                extraCheese = "";
            }
        }

        private void ckbMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMushroom.Checked)
            {
                toppings = toppings + 1;
                mushroom = "Mushrooms\n";
            }
            if (!ckbMushroom.Checked)
            {
                toppings = toppings - 1;
                mushroom = "";
            }
        }



        //Summarizing the order and price
        private void Summarize()
        {
            float subTotal = 0; //variable to keep track of the subTotal
            float sizePrice = 0; //variable to keep track of the pizza size price


            //crust type output to the order summary
            //String crustType = "No Crust";
            if (rdoThin.Checked)
            {
                crustType = "Thin Crust";
            }
            else if (rdoRegular.Checked)
            {
                crustType = "Regular Crust";
            }
            else if (rdoThick.Checked)
            {
                crustType = "Thick Crust";
            }

            //Pizza Size Pricing and output to Order Summary
            //String pizzaSize = cboSize.GetItemText(cboSize.SelectedItem);

            if (pizzaSize == "Small")
            {
                sizePrice = 2;
            }
            else if (pizzaSize == "Medium")
            {
                sizePrice = 5;
            }
            else if (pizzaSize == "Large")
            {
                sizePrice = 10;
            }
            else if (pizzaSize == "X-Large")
            {
                sizePrice = 15;
            }
            else if (pizzaSize == "Ginormous")
            {
                sizePrice = 20;
            }

            rtfOrderSummary.SelectedText += "You ordered a " + pizzaSize + " pizza with " + crustType + " and the following toppings:\n";

            //adding toppings to order summary
            rtfOrderSummary.SelectionBullet = true;
            rtfOrderSummary.SelectedText += pepperoni;
            rtfOrderSummary.SelectedText += sausage;
            rtfOrderSummary.SelectedText += canadianBacon;
            rtfOrderSummary.SelectedText += italianSausage;
            rtfOrderSummary.SelectedText += onion;
            rtfOrderSummary.SelectedText += greenPepper;
            rtfOrderSummary.SelectedText += blackOlives;
            rtfOrderSummary.SelectedText += greenOlives;
            rtfOrderSummary.SelectedText += bananaPeppers;
            rtfOrderSummary.SelectedText += jalepeno;
            rtfOrderSummary.SelectedText += extraCheese;
            rtfOrderSummary.SelectedText += mushroom;
            rtfOrderSummary.SelectionBullet = false;

            //assigning values to subTotal, Tax, and Total
            subTotal = sizePrice + toppings;
            txtSubTotal.Text = subTotal.ToString("C");
            double tax = subTotal * .06;
            double total = subTotal + tax;
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");



        }//end Summarize

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rtfOrderSummary.Clear();
            Summarize();
            
            
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            pizzaSize = cboSize.GetItemText(cboSize.SelectedItem);
        }
    }
}
