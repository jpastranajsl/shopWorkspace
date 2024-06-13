using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JimenaPastranaProject
{
    public partial class Checkout : Form
    {
        private double total;
        private int PaymentMethod { get; set; } //0:cash, 1:card

        public Checkout(double total)
        {
            InitializeComponent();
            this.total = total;
            // Now you can use 'this.total' to display the total wherever needed in this form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
             Number.Text = "Total: $" + total;
        }

        private void Number_Click(object sender, EventArgs e)
        {
                Number.Text = $"{total:C2}"; // Update 'label1' with the total
        }


        private void Cash_Click(object sender, EventArgs e)
        {
            PaymentMethod = 0;
            if (PaymentMethod == 0)
            {
                Cash.BackColor = Color.Pink;
                Card.BackColor = Color.White;
            }
            else
                Cash.BackColor = Color.White;

        }

        private void Card_Click(object sender, EventArgs e)
        {
            PaymentMethod = 1;
            if (PaymentMethod == 1)
            {
                Card.BackColor = Color.Pink;
                Cash.BackColor = Color.White;
            }
            
            else
                Card.BackColor = Color.White;

        }

        private void ReturnToMain_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void RegisterSale_Click(object sender, EventArgs e)
        {
            if (PaymentMethod == 0)//cash
            {
                Register.Cash += total;
            }
            else //card
            {
                Register.Card += total;
            }

            // Reset the Main form
            Main main = new Main();
            main.ResetForm();
            main.Show();
            this.Close();
        }
    }
}
