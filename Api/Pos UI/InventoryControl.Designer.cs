namespace Pos.UI
{
    partial class InventoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listOfItems = new System.Windows.Forms.DataGridView();
            this.stockNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.itemNameSearch = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.listOfItems)).BeginInit();
            this.inventoryMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfItems
            // 
            this.listOfItems.AllowUserToAddRows = false;
            this.listOfItems.AllowUserToDeleteRows = false;
            this.listOfItems.AllowUserToOrderColumns = true;
            this.listOfItems.AllowUserToResizeColumns = false;
            this.listOfItems.AllowUserToResizeRows = false;
            this.listOfItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listOfItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNumber,
            this.itemName,
            this.quantity,
            this.cost,
            this.price,
            this.discontinued});
            this.listOfItems.Location = new System.Drawing.Point(15, 55);
            this.listOfItems.MultiSelect = false;
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.RowHeadersVisible = false;
            this.listOfItems.RowTemplate.ContextMenuStrip = this.inventoryMenuStrip;
            this.listOfItems.Size = new System.Drawing.Size(710, 353);
            this.listOfItems.TabIndex = 0;
            this.listOfItems.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfItems_CellMouseEnter);
            // 
            // stockNumber
            // 
            this.stockNumber.Frozen = true;
            this.stockNumber.HeaderText = "Stock Number";
            this.stockNumber.Name = "stockNumber";
            this.stockNumber.ReadOnly = true;
            this.stockNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // itemName
            // 
            this.itemName.FillWeight = 207F;
            this.itemName.Frozen = true;
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemName.Width = 207;
            // 
            // quantity
            // 
            this.quantity.Frozen = true;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cost
            // 
            this.cost.Frozen = true;
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // price
            // 
            this.price.Frozen = true;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // discontinued
            // 
            this.discontinued.Frozen = true;
            this.discontinued.HeaderText = "Discontinued";
            this.discontinued.Name = "discontinued";
            this.discontinued.ReadOnly = true;
            this.discontinued.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // inventoryMenuStrip
            // 
            this.inventoryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProductToolStripMenuItem});
            this.inventoryMenuStrip.Name = "inventoryMenuStrip";
            this.inventoryMenuStrip.Size = new System.Drawing.Size(161, 26);
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.updateProductToolStripMenuItem_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(464, 17);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(170, 20);
            this.searchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightGray;
            this.searchButton.Location = new System.Drawing.Point(650, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // itemNameSearch
            // 
            this.itemNameSearch.AutoSize = true;
            this.itemNameSearch.Checked = true;
            this.itemNameSearch.Location = new System.Drawing.Point(59, 18);
            this.itemNameSearch.Name = "itemNameSearch";
            this.itemNameSearch.Size = new System.Drawing.Size(127, 17);
            this.itemNameSearch.TabIndex = 3;
            this.itemNameSearch.TabStop = true;
            this.itemNameSearch.Text = "Search by Item Name";
            this.itemNameSearch.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(266, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Search by Stock Number";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.itemNameSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.listOfItems);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(742, 425);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfItems)).EndInit();
            this.inventoryMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfItems;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton itemNameSearch;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ContextMenuStrip inventoryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discontinued;
    }
}
