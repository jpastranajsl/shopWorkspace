namespace JimenaPastranaProject
{
    partial class Checkout
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
            Cash = new Button();
            Card = new Button();
            ReturnToMain = new Button();
            RegisterSale = new Button();
            Number = new Label();
            SuspendLayout();
            // 
            // Cash
            // 
            Cash.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Cash.Location = new Point(356, 252);
            Cash.Margin = new Padding(4, 5, 4, 5);
            Cash.Name = "Cash";
            Cash.Size = new Size(199, 117);
            Cash.TabIndex = 0;
            Cash.Text = "Cash";
            Cash.UseVisualStyleBackColor = true;
            Cash.Click += Cash_Click;
            // 
            // Card
            // 
            Card.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Card.Location = new Point(563, 252);
            Card.Margin = new Padding(4, 5, 4, 5);
            Card.Name = "Card";
            Card.Size = new Size(195, 117);
            Card.TabIndex = 1;
            Card.Text = "Card";
            Card.UseVisualStyleBackColor = true;
            Card.Click += Card_Click;
            // 
            // ReturnToMain
            // 
            ReturnToMain.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnToMain.Location = new Point(356, 422);
            ReturnToMain.Margin = new Padding(4, 5, 4, 5);
            ReturnToMain.Name = "ReturnToMain";
            ReturnToMain.Size = new Size(199, 117);
            ReturnToMain.TabIndex = 2;
            ReturnToMain.Text = "Back";
            ReturnToMain.UseVisualStyleBackColor = true;
            ReturnToMain.Click += ReturnToMain_Click;
            // 
            // RegisterSale
            // 
            RegisterSale.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterSale.Location = new Point(563, 422);
            RegisterSale.Margin = new Padding(4, 5, 4, 5);
            RegisterSale.Name = "RegisterSale";
            RegisterSale.Size = new Size(195, 117);
            RegisterSale.TabIndex = 3;
            RegisterSale.Text = "Finish";
            RegisterSale.UseVisualStyleBackColor = true;
            RegisterSale.Click += RegisterSale_Click;
            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.BackColor = Color.White;
            Number.Font = new Font("Yu Gothic UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            Number.Location = new Point(356, 55);
            Number.Margin = new Padding(4, 0, 4, 0);
            Number.Name = "Number";
            Number.Size = new Size(402, 128);
            Number.TabIndex = 4;
            Number.Text = "Number";
            Number.TextAlign = ContentAlignment.MiddleCenter;
            Number.Click += Number_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1143, 750);
            Controls.Add(Number);
            Controls.Add(RegisterSale);
            Controls.Add(ReturnToMain);
            Controls.Add(Card);
            Controls.Add(Cash);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cash;
        private Button Card;
        private Button ReturnToMain;
        private Button RegisterSale;
        private Label Number;
    }
}