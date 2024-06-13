using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JimenaPastranaProject
{
    public partial class Main : Form
    {
        public Filter filter { get; set; }
        public Cart cart { get; set; }
        public Main()
        {
            InitializeComponent();
            ListOfProducts.ReadFile("Input.txt");
            filter = new Filter();

            cart = new Cart();

            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            deleteProduct.Click += deleteProduct_Click;
            textBox1.Click += textBox1_TextChanged;

            UpdateTotalLabel();
        }

        private void RefreshTotalDataGridView1()
        {
            // Bind the Cart to dataGridView1
            dataGridView1.DataSource = cart.AddedItems.Select(item => new
            {
                Enumeration = cart.AddedItems.IndexOf(item) + 1,
                Name = item.Item1.Product_Name,
                Quantity = item.Item2,
                IndividualPrice = item.Item1.Product_Price,
                OverallPrice = item.Item1.Product_Price * item.Item2
            }).ToList();

            // Refresh the destination DataGridView
            dataGridView1.Refresh();

            // Update the total label
            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            // Calculate total based on the items in the cart
            double total = cart.AddedItems.Sum(item => item.Item1.Product_Price * item.Item2);

            // Update the label text
            totalCartMain.Text = $"Total: ${total:F2}";
        }


        private void search_Click(object sender, EventArgs e)
        {
            filter.SearchMethod(codeInsert.Text);

            // Clear the existing data in dataGridView2
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = filter.Matches;
            dataGridView2.Refresh();
        }


        private void codeInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void setAmount_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Check if there is a selected row in dataGridView1
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Check if the selected index is valid
                if (selectedIndex >= 0 && selectedIndex < cart.AddedItems.Count)
                {
                    // Update the quantity for the selected item in the Cart
                    int newQuantity;
                    if (int.TryParse(textBox1.Text, out newQuantity))
                    {
                        // Ensure the new quantity is greater than zero
                        newQuantity = Math.Max(1, newQuantity);

                        // Update the quantity
                        cart.AddedItems[selectedIndex] = (cart.AddedItems[selectedIndex].Item1, newQuantity);

                        // Refresh the dataGridView1 with updated cart items
                        RefreshDataGridView1();
                        UpdateTotalLabel();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid quantity.");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            
            double total = cart.AddedItems.Sum(item => item.Item1.Product_Price * item.Item2);
            Checkout checkout = new Checkout(total);
            checkout.Show();
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is a selected row in dataGridView2
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected Product from the source DataGridView
                Product selectedProduct = dataGridView2.SelectedRows[0].DataBoundItem as Product;
                
                if (selectedProduct != null)
                {
                    // Check if the product is already in the cart
                    var existingItem = cart.AddedItems.Find(item => item.Item1 == selectedProduct);

                    if (existingItem.Item1 != null)
                    {
                        // Product is already in the cart, update the quantity
                        int index = cart.AddedItems.FindIndex(item => item.Item1 == selectedProduct);
                        cart.AddedItems[index] = (selectedProduct, existingItem.Item2 + 1);
                    }
                    else
                    {
                        // Product is not in the cart, add it
                        cart.AddedItems.Add((selectedProduct, 1)); // Default quantity is 1
                    }

                    // Bind the Cart to dataGridView1
                    dataGridView1.DataSource = cart.AddedItems.Select(item => new
                    {
                        Enumeration = cart.AddedItems.IndexOf(item) + 1,
                        Name = item.Item1.Product_Name,
                        Quantity = item.Item2,
                        IndividualPrice = item.Item1.Product_Price,
                        OverallPrice = item.Item1.Product_Price * item.Item2
                    }).ToList();

                    dataGridView1.Refresh();
                    UpdateTotalLabel();
                }
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Remove the corresponding item from the Cart
                cart.AddedItems.RemoveAt(selectedIndex);

               
                RefreshDataGridView1();
                UpdateTotalLabel();
            }
        }

        private void RefreshDataGridView1()
        {
            // Bind the Cart to dataGridView1
            dataGridView1.DataSource = cart.AddedItems.Select(item => new
            {
                Enumeration = cart.AddedItems.IndexOf(item) + 1,
                Name = item.Item1.Product_Name,
                Quantity = item.Item2,
                IndividualPrice = item.Item1.Product_Price,
                OverallPrice = item.Item1.Product_Price * item.Item2
            }).ToList();

            
            dataGridView1.Refresh();
        }

        private void totalCartMain_Click(object sender, EventArgs e)
        {

        }

        public void ResetForm()
        {
            // Clear the cart
            cart.AddedItems.Clear();

            // Clear the DataGridViews
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            Refresh();
        }

    }
}