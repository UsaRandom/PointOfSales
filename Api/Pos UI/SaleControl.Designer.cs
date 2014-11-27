namespace Pos.UI
{
    partial class SaleControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalCashLbl = new System.Windows.Forms.Label();
            this.taxCashLbl = new System.Windows.Forms.Label();
            this.subTotalCashLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.listOfProducts = new System.Windows.Forms.DataGridView();
            this.StockNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeSale = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalCashLbl);
            this.groupBox1.Controls.Add(this.taxCashLbl);
            this.groupBox1.Controls.Add(this.subTotalCashLbl);
            this.groupBox1.Controls.Add(this.totalLbl);
            this.groupBox1.Controls.Add(this.taxLbl);
            this.groupBox1.Controls.Add(this.subtotalLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(500, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Summary";
            // 
            // totalCashLbl
            // 
            this.totalCashLbl.AutoSize = true;
            this.totalCashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCashLbl.Location = new System.Drawing.Point(151, 110);
            this.totalCashLbl.Name = "totalCashLbl";
            this.totalCashLbl.Size = new System.Drawing.Size(44, 18);
            this.totalCashLbl.TabIndex = 7;
            this.totalCashLbl.Text = "$0.00";
            // 
            // taxCashLbl
            // 
            this.taxCashLbl.AutoSize = true;
            this.taxCashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxCashLbl.Location = new System.Drawing.Point(151, 55);
            this.taxCashLbl.Name = "taxCashLbl";
            this.taxCashLbl.Size = new System.Drawing.Size(44, 18);
            this.taxCashLbl.TabIndex = 6;
            this.taxCashLbl.Text = "$0.00";
            // 
            // subTotalCashLbl
            // 
            this.subTotalCashLbl.AutoSize = true;
            this.subTotalCashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalCashLbl.Location = new System.Drawing.Point(151, 37);
            this.subTotalCashLbl.Name = "subTotalCashLbl";
            this.subTotalCashLbl.Size = new System.Drawing.Size(44, 18);
            this.subTotalCashLbl.TabIndex = 4;
            this.subTotalCashLbl.Text = "$0.00";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(17, 110);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(51, 18);
            this.totalLbl.TabIndex = 2;
            this.totalLbl.Text = "Total:";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(17, 55);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(40, 18);
            this.taxLbl.TabIndex = 1;
            this.taxLbl.Text = "Tax:";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Location = new System.Drawing.Point(17, 37);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(85, 18);
            this.subtotalLbl.TabIndex = 0;
            this.subtotalLbl.Text = "Sub Total:";
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
            this.Quantity,
            this.Price});
            this.listOfProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listOfProducts.Location = new System.Drawing.Point(18, 13);
            this.listOfProducts.Name = "listOfProducts";
            this.listOfProducts.ReadOnly = true;
            this.listOfProducts.RowHeadersVisible = false;
            this.listOfProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listOfProducts.ShowEditingIcon = false;
            this.listOfProducts.Size = new System.Drawing.Size(458, 398);
            this.listOfProducts.TabIndex = 2;
            this.listOfProducts.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfProducts_CellMouseEnter);
            // 
            // StockNumber
            // 
            this.StockNumber.FillWeight = 50F;
            this.StockNumber.Frozen = true;
            this.StockNumber.HeaderText = "SN";
            this.StockNumber.Name = "StockNumber";
            this.StockNumber.ReadOnly = true;
            this.StockNumber.Width = 50;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 225F;
            this.ItemName.Frozen = true;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 225;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 80F;
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 80;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // completeSale
            // 
            this.completeSale.BackColor = System.Drawing.Color.LightGray;
            this.completeSale.Enabled = false;
            this.completeSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeSale.Location = new System.Drawing.Point(532, 302);
            this.completeSale.Name = "completeSale";
            this.completeSale.Size = new System.Drawing.Size(157, 46);
            this.completeSale.TabIndex = 3;
            this.completeSale.Text = "Complete Sale";
            this.completeSale.UseVisualStyleBackColor = false;
            this.completeSale.Click += new System.EventHandler(this.completeSale_Click);
            // 
            // SaleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.completeSale);
            this.Controls.Add(this.listOfProducts);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaleControl";
            this.Size = new System.Drawing.Size(742, 425);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.DataGridView listOfProducts;
        private System.Windows.Forms.Button completeSale;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label subTotalCashLbl;
        private System.Windows.Forms.Label totalCashLbl;
        private System.Windows.Forms.Label taxCashLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
