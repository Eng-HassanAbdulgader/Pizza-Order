using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       



        void  UpdateSize()
        {
            UpdateTotelPrice();
            if(rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if (rbMeduim.Checked)
            {
                lblSize.Text = "Meduim";
                return;
            }
            if (rbLarg.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotelPrice();
            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                sToppings = "Extra chees";
            }
            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }
            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }
            if (chkGreenPappers.Checked)
            {
                sToppings += ", GreenPappers";
            }
            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }
            lblToping.Text = sToppings;
        }

        void UpdateCrust()
        {
            UpdateTotelPrice();
            if (rbThinCrust.Checked)
            {
                lblCrustType.Text= "Thin Crust";
                return ;
            }
            if(rbThinkCrust.Checked)
            {
               lblCrustType.Text = "Think Crust";
                return ;    
            }

        }

        void UpdateWhereToEat()
        {
            UpdateTotelPrice();
            if(rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return ;
            }
            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
                return ;
            }
        }

        float GetSelectedSizePrice()
        { 
            if(rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            else if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }

            else
            {
                return Convert.ToSingle(rbLarg.Tag);
            }

        }

        float CalculateToppingPrice()
        {
            float ToppingsTotelPrice = 0;
            if (chkExtraChees.Checked)
            {
                ToppingsTotelPrice += Convert.ToSingle(chkExtraChees.Tag);
            }
            if (chkGreenPappers.Checked)
            {
                ToppingsTotelPrice += Convert.ToSingle(chkGreenPappers.Tag);
            }
            if (chkMushrooms.Checked)
            {
                ToppingsTotelPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            else if (chkOlives.Checked)
            {
                ToppingsTotelPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkOnion.Checked)
            {
                ToppingsTotelPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if(chkTomatoes.Checked)
            {
                ToppingsTotelPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            return ToppingsTotelPrice;

        }

        float GetSelectedCrustPrice()
        {
           
            if (rbThinCrust.Checked)
            {
               return  Convert.ToSingle(rbThinCrust.Tag);

            }
            else
            {
               return Convert.ToSingle(rbThinkCrust.Tag);
            }
           
        }

        float CaluclateTotelPrice()
        {
            return GetSelectedSizePrice()+GetSelectedCrustPrice() + CalculateToppingPrice();
        }

        void UpdateTotelPrice()
        {

            lbPrice.Text = "$" + CaluclateTotelPrice().ToString();
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
           UpdateTotelPrice();
        }

        void ResetForm()
        {
            //reset Groups
            grSize.Enabled = true;
            grToppings.Enabled = true;
            grCrust.Enabled = true;
            grWhereToEat.Enabled = true;
            grWhereToEat.Enabled = true;
            
            rbMeduim.Checked = true;
            rbThinCrust.Checked = true;
            chkExtraChees.Checked = false;
            chkGreenPappers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;    
            
            rbEatIn.Checked = true ;

            btnOrderPizza.Enabled = true ;


            UpdateOrderSummary();

        }



        //here
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblToping_Click(object sender, EventArgs e)
        {

        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        //yep

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnOrderPizza.Enabled=false;
                grSize.Enabled=false;
                grToppings.Enabled=false;
                grCrust.Enabled=false;
                grWhereToEat.Enabled=false;

            }
            else
            {
                MessageBox.Show("Please Update Your Order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        
    }
}
