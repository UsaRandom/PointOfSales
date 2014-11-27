namespace Pos.UI
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            this.listOfProducts = new System.Windows.Forms.DataGridView();
            this.StockNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.costLbl = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.completeReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOfProducts)).BeginInit();
            this.summaryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfProducts
            // 
            this.listOfProducts.AllowUserToAddRows = false;
            this.listOfProducts.AllowUserToDeleteRows = false;
            this.listOfProducts.AllowUserToResizeColumns = false;
            this.listOfProducts.AllowUserToResizeRows = false;
            this.listOfProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listOfProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockNumber,
            this.ItemName,
            this.Price,
            this.Quantity});
            this.listOfProducts.Location = new System.Drawing.Point(12, 12);
            this.listOfProducts.Name = "listOfProducts";
            this.listOfProducts.ReadOnly = true;
            this.listOfProducts.RowHeadersVisible = false;
            this.listOfProducts.Size = new System.Drawing.Size(346, 267);
            this.listOfProducts.TabIndex = 0;
            // 
            // StockNumber
            // 
            this.StockNumber.FillWeight = 70F;
            this.StockNumber.HeaderText = "SN";
            this.StockNumber.Name = "StockNumber";
            this.StockNumber.ReadOnly = true;
            this.StockNumber.Width = 70;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 120F;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 120;
            // 
            // Price
            // 
            this.Price.FillWeight = 78F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 78;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 75F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 75;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(374, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(462, 32);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(82, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // summaryBox
            // 
            this.summaryBox.Controls.Add(this.costLbl);
            this.summaryBox.Controls.Add(this.countLbl);
            this.summaryBox.Controls.Add(this.lbl2);
            this.summaryBox.Controls.Add(this.lbl1);
            this.summaryBox.Location = new System.Drawing.Point(374, 86);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(170, 97);
            this.summaryBox.TabIndex = 3;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Return Summary";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(111, 56);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(34, 13);
            this.costLbl.TabIndex = 3;
            this.costLbl.Text = "$0.00";
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(132, 33);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(13, 13);
            this.countLbl.TabIndex = 2;
            this.countLbl.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(15, 56);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(58, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Total Cost:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(15, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Total Items:";
            // 
            // completeReturn
            // 
            this.completeReturn.Location = new System.Drawing.Point(402, 216);
            this.completeReturn.Name = "completeReturn";
            this.completeReturn.Size = new System.Drawing.Size(117, 43);
            this.completeReturn.TabIndex = 4;
            this.completeReturn.Text = "Complete Return";
            this.completeReturn.UseVisualStyleBackColor = true;
            this.completeReturn.Click += new System.EventHandler(this.completeReturnButton_click);
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 291);
            this.Controls.Add(this.completeReturn);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listOfProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Form";
            ((System.ComponentModel.ISupportInitialize)(this.listOfProducts)).EndInit();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfProducts;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.Button completeReturn;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}