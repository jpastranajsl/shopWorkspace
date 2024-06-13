using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JimenaPastranaProject
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            NumberCash.Text = Register.Cash.ToString();
            NumberCard.Text = Register.Card.ToString();
            Register.Total = Register.Cash + Register.Card;
            NumberTotal.Text = Register.Total.ToString();
        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumberTotal_Click(object sender, EventArgs e)
        {

        }

        private void CashLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumberCash_Click(object sender, EventArgs e)
        {

        }

        private void CardLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumberCard_Click(object sender, EventArgs e)
        {

        }

        private void salesBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
