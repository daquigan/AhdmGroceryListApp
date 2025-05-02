namespace AhdmGroceryListApp
{
    partial class Form2
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
            lblItemName = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblItemCount = new Label();
            txtItemName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnAddItem = new Button();
            listBoxGroceries = new ListBox();
            btnCreateJson = new Button();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(12, 35);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(86, 20);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Item Name:";
            lblItemName.Click += label1_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 72);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 104);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // lblItemCount
            // 
            lblItemCount.AutoSize = true;
            lblItemCount.Location = new Point(149, 422);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(121, 20);
            lblItemCount.TabIndex = 3;
            lblItemCount.Text = "Items added: 0/5";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(104, 28);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(218, 27);
            txtItemName.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(104, 65);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(218, 27);
            txtQuantity.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(104, 104);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(218, 27);
            txtPrice.TabIndex = 6;
            txtPrice.TextChanged += textBox3_TextChanged;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(350, 55);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(86, 47);
            btnAddItem.TabIndex = 7;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // listBoxGroceries
            // 
            listBoxGroceries.FormattingEnabled = true;
            listBoxGroceries.Location = new Point(12, 157);
            listBoxGroceries.Name = "listBoxGroceries";
            listBoxGroceries.Size = new Size(424, 164);
            listBoxGroceries.TabIndex = 8;
            // 
            // btnCreateJson
            // 
            btnCreateJson.Location = new Point(118, 336);
            btnCreateJson.Name = "btnCreateJson";
            btnCreateJson.Size = new Size(204, 49);
            btnCreateJson.TabIndex = 9;
            btnCreateJson.Text = "Create JSON File";
            btnCreateJson.UseVisualStyleBackColor = true;
            btnCreateJson.Click += btnCreateJson_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 508);
            Controls.Add(btnCreateJson);
            Controls.Add(listBoxGroceries);
            Controls.Add(btnAddItem);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemName);
            Controls.Add(lblItemCount);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblItemName);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblItemCount;
        private TextBox txtItemName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnAddItem;
        private ListBox listBoxGroceries;
        private Button btnCreateJson;
    }
}