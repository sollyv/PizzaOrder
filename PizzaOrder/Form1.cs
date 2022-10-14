namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbPersonal.Checked = true;
            lblAmount.Text = "0.00";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstboxname.SelectedItem = null;
            foreach(Control c in gbExtraToppings.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox cb= (CheckBox)c;
                    if (cb.Checked==true)
                    {
                        cb.Checked = false;
                    }
                }                
            }
            lblAmount.Text = "0.00";
        }

        private void SelectToppings(object sender, EventArgs e)
        {
            float price = 0.00f;
            if (cbBacon.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbChicken.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbExtraCheese.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbGreenPeppers.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbHam.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbJalapenos.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbMushrooms.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbOnion.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbPepperoni.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbPineapple.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbSalami.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbSausage.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbSweetcorn.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            if (cbTomatoes.Checked) { price += 1.75f; lblAmount.Text = price.ToString("F"); }
            else { if (!cbBacon.Checked && !cbChicken.Checked && !cbExtraCheese.Checked && !cbGreenPeppers.Checked && !cbHam.Checked && !cbJalapenos.Checked && !cbMushrooms.Checked && !cbOnion.Checked && !cbPepperoni.Checked && !cbPineapple.Checked && !cbSalami.Checked && !cbSausage.Checked && !cbSweetcorn.Checked && !cbTomatoes.Checked) { lblAmount.Text = "0.00"; } }


        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //To check if a pizza is selected or not
            if (lstboxname.SelectedItem != null)
            {
                string pizza_name=lstboxname.GetItemText(lstboxname.SelectedItem);
                string toppings_name = "";
                foreach(Control c in gbExtraToppings.Controls)
                {
                    if(c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;
                        if (cb.Checked)
                        {
                            toppings_name+= $" {cb.Text},";
                        }
                    }
                }
                
                MessageBox.Show($"Your Pizza-{pizza_name}\n\nProduct with {toppings_name}\n\nSpecial Requirements-{tbSpecialReq.Text}","Order confirmation",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Select a piza","Oops",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            

        }

        private void SizeSelection(object sender, EventArgs e)
        {
            float price=float.Parse(lblAmount.Text);
            if (rbLarge.Checked) { price += 14.99f; }
            if (rbPersonal.Checked) { price += 6.99f; }
            if (rbSmall.Checked) { price += 9.99f; }
            if (rbMedium.Checked) { price += 12.99f; }
            lblAmount.Text = price.ToString("F");
        }
    }
}