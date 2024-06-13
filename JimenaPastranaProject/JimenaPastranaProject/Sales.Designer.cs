namespace JimenaPastranaProject
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CashLabel = new Label();
            TotalLabel = new Label();
            CardLabel = new Label();
            NumberTotal = new Label();
            NumberCash = new Label();
            NumberCard = new Label();
            salesBackToMain = new Label();
            SuspendLayout();
            // 
            // CashLabel
            // 
            CashLabel.AutoSize = true;
            CashLabel.BackColor = Color.White;
            CashLabel.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            CashLabel.Location = new Point(304, 278);
            CashLabel.Margin = new Padding(4, 0, 4, 0);
            CashLabel.Name = "CashLabel";
            CashLabel.Size = new Size(142, 71);
            CashLabel.TabIndex = 0;
            CashLabel.Text = "Cash";
            CashLabel.Click += CashLabel_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.BackColor = Color.White;
            TotalLabel.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLabel.Location = new Point(304, 93);
            TotalLabel.Margin = new Padding(4, 0, 4, 0);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(141, 71);
            TotalLabel.TabIndex = 1;
            TotalLabel.Text = "Total";
            TotalLabel.Click += TotalLabel_Click;
            // 
            // CardLabel
            // 
            CardLabel.AutoSize = true;
            CardLabel.BackColor = Color.White;
            CardLabel.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            CardLabel.Location = new Point(304, 390);
            CardLabel.Margin = new Padding(4, 0, 4, 0);
            CardLabel.Name = "CardLabel";
            CardLabel.Size = new Size(139, 71);
            CardLabel.TabIndex = 2;
            CardLabel.Text = "Card";
            CardLabel.Click += CardLabel_Click;
            // 
            // NumberTotal
            // 
            NumberTotal.AutoSize = true;
            NumberTotal.BackColor = Color.White;
            NumberTotal.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            NumberTotal.Location = new Point(590, 93);
            NumberTotal.Margin = new Padding(4, 0, 4, 0);
            NumberTotal.Name = "NumberTotal";
            NumberTotal.Size = new Size(112, 71);
            NumberTotal.TabIndex = 3;
            NumberTotal.Text = "No.";
            NumberTotal.Click += NumberTotal_Click;
            // 
            // NumberCash
            // 
            NumberCash.AutoSize = true;
            NumberCash.BackColor = Color.White;
            NumberCash.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            NumberCash.Location = new Point(590, 278);
            NumberCash.Margin = new Padding(4, 0, 4, 0);
            NumberCash.Name = "NumberCash";
            NumberCash.Size = new Size(112, 71);
            NumberCash.TabIndex = 4;
            NumberCash.Text = "No.";
            NumberCash.Click += NumberCash_Click;
            // 
            // NumberCard
            // 
            NumberCard.AutoSize = true;
            NumberCard.BackColor = Color.White;
            NumberCard.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            NumberCard.Location = new Point(590, 390);
            NumberCard.Margin = new Padding(4, 0, 4, 0);
            NumberCard.Name = "NumberCard";
            NumberCard.Size = new Size(112, 71);
            NumberCard.TabIndex = 5;
            NumberCard.Text = "No.";
            NumberCard.Click += NumberCard_Click;
            // 
            // salesBackToMain
            // 
            salesBackToMain.AutoSize = true;
            salesBackToMain.BackColor = Color.White;
            salesBackToMain.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            salesBackToMain.Location = new Point(446, 530);
            salesBackToMain.Margin = new Padding(4, 0, 4, 0);
            salesBackToMain.Name = "salesBackToMain";
            salesBackToMain.Size = new Size(137, 71);
            salesBackToMain.TabIndex = 6;
            salesBackToMain.Text = "Back";
            salesBackToMain.Click += salesBackToMain_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1143, 750);
            Controls.Add(salesBackToMain);
            Controls.Add(NumberCard);
            Controls.Add(NumberCash);
            Controls.Add(NumberTotal);
            Controls.Add(CardLabel);
            Controls.Add(TotalLabel);
            Controls.Add(CashLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CashLabel;
        private Label TotalLabel;
        private Label CardLabel;
        private Label NumberTotal;
        private Label NumberCash;
        private Label NumberCard;
        private Label salesBackToMain;
    }
}