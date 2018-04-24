using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj9PizzaDelivery
{
    public partial class Form1 : Form
    {
        private string order;
        private double totalCost;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmboSize.SelectedIndex = 1;
            this.cmboCrust.SelectedIndex = 0;
            this.cmboSpecialty.SelectedIndex = 0;
            this.txtBxSodaQty.Text = "0";
            this.txtBxWaterQty.Text = "0";
            order = "";
            totalCost = 0;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double drinkCost,
                pizzaCost,
                specialtyCost;
            order = "";
            order += cmboCrust.SelectedItem.ToString() + " - ";
            order += cmboSize.SelectedItem.ToString() + "\n";
            if (lstBxToppings.SelectedItems.Count > 0)
            {
                order += "Toppings:";
                foreach (string s in lstBxToppings.CheckedItems)
                {
                    order += "\n" + s;
                }//end of foreach
            }//end of if
            pizzaCost = DeterminePizzaCost( );
            if (pizzaCost != 0)
                order += "\nPizza Total: " +
                    pizzaCost.ToString("C");
            drinkCost = DetermineDrinkCost( );
            if (drinkCost != 0)
                order += "\nDrink Total: " +
                    drinkCost;
            specialtyCost = DetermineSpecialtyCost();
            if (specialtyCost != 0)
            {
                order += "\n\nSpecialty Items:\n" +
                    cmboSpecialty.SelectedItem.ToString();
            }// end of if
            order += "\n\nAmount Due: " +
                (pizzaCost + drinkCost + specialtyCost).ToString("C");
            MessageBox.Show(order,
                "B & D Pizza Express Order\n");
        }//end of button click

        private double DetermineDrinkCost()
        {
            double sodaCnt,
                waterCnt;
            totalCost = 0;
            if (txtBxSodaQty.Text != "")
            {
                while (double.TryParse(txtBxSodaQty.Text, out sodaCnt) == false)
                {
                    lblErrorMsg.Text =
                        "No drinks ordered! Quantity must be numeric.";
                    txtBxSodaQty.Text = "0";
                }//end of while
                order += "\n\nDrink Selections:\n" + sodaCnt +
                    " soda(s)";
                totalCost = sodaCnt * 1.75;
            }//end of if
            if (txtBxWaterQty.Text != "")
            {
                while (double.TryParse(txtBxWaterQty.Text, out waterCnt) == false)
                {
                    lblErrorMsg.Text =
                        "No drinks ordered! Quantity must be numeric.";
                    txtBxWaterQty.Text = "0";
                }//end of while
                order += "\n" + waterCnt + " water(s)";
            }//end of if
            return totalCost;
        }//end of DetermineDrinkCost

        //Determine Pizza Cost
        public double DeterminePizzaCost()
        {
            double cost;
            if (cmboSize.SelectedIndex == 0)
                cost = 9.95;
            else
                if (cmboSize.SelectedIndex == 1)
                    cost = 12.95;
                else
                    cost = 15.95;
            return cost + (lstBxToppings.CheckedItems.Count * 1.50);
        }//end of DeterminePizzaCost

        public double DetermineSpecialtyCost()
        {
            double cost;
            if (cmboSpecialty.SelectedIndex == 1)
            {
                cost = 5.00;
            }//end of if
            else
                if (cmboSpecialty.SelectedIndex == 2)
            {
                cost = 4.00;
            }//end of if
            else
                    if (cmboSpecialty.SelectedIndex == 3)
            {
                cost = 3.00;
            }//end of if
            else
                cost = 0;
            return cost;
        }//end of DetermineSpecialtyCost

        //Clear Form Button
        private void button1_Click(object sender, EventArgs e)
        {
            RecursiveClearTextBoxes(this.Controls);
        }

        private void RecursiveClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Clear();
                else
                    RecursiveClearTextBoxes(ctrl.Controls);
            }//end of foreach
        }//end of clear textboxes


    }//end of class
}//end of solution
