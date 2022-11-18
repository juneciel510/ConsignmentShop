namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.itemListBoxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.ShoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(106, 40);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(405, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // itemListbox
            // 
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.Location = new System.Drawing.Point(53, 136);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(300, 238);
            this.itemListbox.TabIndex = 1;
            // 
            // itemListBoxLabel
            // 
            this.itemListBoxLabel.AutoSize = true;
            this.itemListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListBoxLabel.Location = new System.Drawing.Point(50, 120);
            this.itemListBoxLabel.Name = "itemListBoxLabel";
            this.itemListBoxLabel.Size = new System.Drawing.Size(71, 13);
            this.itemListBoxLabel.TabIndex = 2;
            this.itemListBoxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(410, 222);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(114, 31);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // ShoppingCartListBoxLabel
            // 
            this.ShoppingCartListBoxLabel.AutoSize = true;
            this.ShoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartListBoxLabel.Location = new System.Drawing.Point(566, 120);
            this.ShoppingCartListBoxLabel.Name = "ShoppingCartListBoxLabel";
            this.ShoppingCartListBoxLabel.Size = new System.Drawing.Size(87, 13);
            this.ShoppingCartListBoxLabel.TabIndex = 5;
            this.ShoppingCartListBoxLabel.Text = "Shopping Cart";
            this.ShoppingCartListBoxLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.Location = new System.Drawing.Point(568, 136);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(300, 238);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(754, 380);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(114, 31);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.ShoppingCartListBoxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemListBoxLabel);
            this.Controls.Add(this.itemListbox);
            this.Controls.Add(this.headerText);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.Label itemListBoxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label ShoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
    }
}

