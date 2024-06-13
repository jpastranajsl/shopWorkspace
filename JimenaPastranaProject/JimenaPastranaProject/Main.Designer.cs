namespace JimenaPastranaProject
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            codeLbl = new Label();
            amountLbl = new Label();
            textBox1 = new TextBox();
            codeInsert = new TextBox();
            search = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            matchesBindingSource = new BindingSource(components);
            filterBindingSource1 = new BindingSource(components);
            filterBindingSource = new BindingSource(components);
            Sales = new Button();
            Checkout = new Button();
            deleteProduct = new Button();
            totalCartMain = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matchesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filterBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // codeLbl
            // 
            codeLbl.AutoSize = true;
            codeLbl.Location = new Point(149, 97);
            codeLbl.Margin = new Padding(4, 0, 4, 0);
            codeLbl.Name = "codeLbl";
            codeLbl.Size = new Size(51, 25);
            codeLbl.TabIndex = 0;
            codeLbl.Text = "code";
            // 
            // amountLbl
            // 
            amountLbl.AutoSize = true;
            amountLbl.Location = new Point(141, 190);
            amountLbl.Margin = new Padding(4, 0, 4, 0);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new Size(74, 25);
            amountLbl.TabIndex = 1;
            amountLbl.Text = "amount";
            amountLbl.Click += setAmount_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 185);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // codeInsert
            // 
            codeInsert.Location = new Point(256, 92);
            codeInsert.Margin = new Padding(4, 5, 4, 5);
            codeInsert.Name = "codeInsert";
            codeInsert.Size = new Size(141, 31);
            codeInsert.TabIndex = 3;
            codeInsert.TextChanged += codeInsert_TextChanged;
            // 
            // search
            // 
            search.Location = new Point(537, 92);
            search.Margin = new Padding(4, 5, 4, 5);
            search.Name = "search";
            search.Size = new Size(107, 38);
            search.TabIndex = 4;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 317);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(814, 250);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.Location = new Point(954, 317);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(514, 250);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // matchesBindingSource
            // 
            matchesBindingSource.DataMember = "Matches";
            matchesBindingSource.DataSource = filterBindingSource1;
            // 
            // filterBindingSource1
            // 
            filterBindingSource1.DataSource = typeof(Filter);
            // 
            // filterBindingSource
            // 
            filterBindingSource.DataSource = typeof(Filter);
            // 
            // Sales
            // 
            Sales.Location = new Point(1247, 692);
            Sales.Margin = new Padding(4, 5, 4, 5);
            Sales.Name = "Sales";
            Sales.Size = new Size(107, 38);
            Sales.TabIndex = 7;
            Sales.Text = "Sales";
            Sales.UseVisualStyleBackColor = true;
            Sales.Click += Sales_Click;
            // 
            // Checkout
            // 
            Checkout.Location = new Point(1247, 773);
            Checkout.Margin = new Padding(4, 5, 4, 5);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(107, 38);
            Checkout.TabIndex = 8;
            Checkout.Text = "Finish";
            Checkout.UseVisualStyleBackColor = true;
            Checkout.Click += Checkout_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.Location = new Point(103, 591);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(112, 34);
            deleteProduct.TabIndex = 9;
            deleteProduct.Text = "Delete";
            deleteProduct.UseVisualStyleBackColor = true;
            deleteProduct.Click += deleteProduct_Click;
            // 
            // totalCartMain
            // 
            totalCartMain.AutoSize = true;
            totalCartMain.BorderStyle = BorderStyle.FixedSingle;
            totalCartMain.Location = new Point(732, 600);
            totalCartMain.Name = "totalCartMain";
            totalCartMain.Size = new Size(2, 27);
            totalCartMain.TabIndex = 11;
            totalCartMain.Click += totalCartMain_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1550, 913);
            Controls.Add(totalCartMain);
            Controls.Add(deleteProduct);
            Controls.Add(Checkout);
            Controls.Add(Sales);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(search);
            Controls.Add(codeInsert);
            Controls.Add(textBox1);
            Controls.Add(amountLbl);
            Controls.Add(codeLbl);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)matchesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)filterBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)filterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label codeLbl;
        private Label amountLbl;
        private TextBox textBox1;
        private TextBox codeInsert;
        private Button search;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button Sales;
        private Button Checkout;
        private BindingSource filterBindingSource;
        private BindingSource filterBindingSource1;
        private BindingSource matchesBindingSource;
        private Button deleteProduct;
        private Label totalCartMain;
    }
}