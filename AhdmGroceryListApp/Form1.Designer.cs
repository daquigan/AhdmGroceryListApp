namespace AhdmGroceryListApp
{
    partial class Form1
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
            dataGridViewShoppingList = new DataGridView();
            btnLoadShoppingList = new Button();
            btnOpenAddGroceries = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShoppingList).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewShoppingList
            // 
            dataGridViewShoppingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShoppingList.Location = new Point(12, 12);
            dataGridViewShoppingList.Name = "dataGridViewShoppingList";
            dataGridViewShoppingList.RowHeadersWidth = 51;
            dataGridViewShoppingList.Size = new Size(363, 221);
            dataGridViewShoppingList.TabIndex = 0;
            // 
            // btnLoadShoppingList
            // 
            btnLoadShoppingList.Location = new Point(12, 239);
            btnLoadShoppingList.Name = "btnLoadShoppingList";
            btnLoadShoppingList.Size = new Size(175, 49);
            btnLoadShoppingList.TabIndex = 1;
            btnLoadShoppingList.Text = "Load Shopping List";
            btnLoadShoppingList.UseVisualStyleBackColor = true;
            btnLoadShoppingList.Click += btnLoadShoppingList_Click;
            // 
            // btnOpenAddGroceries
            // 
            btnOpenAddGroceries.Location = new Point(193, 239);
            btnOpenAddGroceries.Name = "btnOpenAddGroceries";
            btnOpenAddGroceries.Size = new Size(182, 49);
            btnOpenAddGroceries.TabIndex = 2;
            btnOpenAddGroceries.Text = "Add Groceries";
            btnOpenAddGroceries.UseVisualStyleBackColor = true;
            btnOpenAddGroceries.Click += btnOpenAddGroceries_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 314);
            Controls.Add(btnOpenAddGroceries);
            Controls.Add(btnLoadShoppingList);
            Controls.Add(dataGridViewShoppingList);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewShoppingList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewShoppingList;
        private Button btnLoadShoppingList;
        private Button btnOpenAddGroceries;
    }
}
