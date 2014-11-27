namespace Pos.UI
{
    partial class SaleDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleDetailForm));
            this.listOfItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOfItems)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfItems
            // 
            this.listOfItems.AllowUserToAddRows = false;
            this.listOfItems.AllowUserToDeleteRows = false;
            this.listOfItems.AllowUserToResizeColumns = false;
            this.listOfItems.AllowUserToResizeRows = false;
            this.listOfItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.Price});
            this.listOfItems.Location = new System.Drawing.Point(12, 12);
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.RowHeadersVisible = false;
            this.listOfItems.Size = new System.Drawing.Size(322, 197);
            this.listOfItems.TabIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 159F;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 159;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 80F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Price
            // 
            this.Price.FillWeight = 80F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(259, 215);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // SaleDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 247);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.listOfItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaleDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Detail";
            ((System.ComponentModel.ISupportInitialize)(this.listOfItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button okButton;
    }
}