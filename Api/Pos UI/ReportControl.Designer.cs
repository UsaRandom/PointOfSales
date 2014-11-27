namespace Pos.UI
{
    partial class ReportControl
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
            this.listOfSales = new System.Windows.Forms.DataGridView();
            this.SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.profitLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.subTotalLbl = new System.Windows.Forms.Label();
            this.taxTotalLbl = new System.Windows.Forms.Label();
            this.itemsTotalLbl = new System.Windows.Forms.Label();
            this.sumTlbl = new System.Windows.Forms.Label();
            this.sumPLbl = new System.Windows.Forms.Label();
            this.sumSLbl = new System.Windows.Forms.Label();
            this.sumTaxLbl = new System.Windows.Forms.Label();
            this.itemsSoldLbl = new System.Windows.Forms.Label();
            this.cashGroup = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.listOfCash = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.listOfSales)).BeginInit();
            this.reportView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cashGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfSales
            // 
            this.listOfSales.AllowUserToAddRows = false;
            this.listOfSales.AllowUserToDeleteRows = false;
            this.listOfSales.AllowUserToResizeColumns = false;
            this.listOfSales.AllowUserToResizeRows = false;
            this.listOfSales.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listOfSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleID,
            this.ItemsSold,
            this.SubTotal,
            this.Tax,
            this.Total,
            this.Profit});
            this.listOfSales.Location = new System.Drawing.Point(18, 13);
            this.listOfSales.Name = "listOfSales";
            this.listOfSales.RowHeadersVisible = false;
            this.listOfSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listOfSales.RowTemplate.ContextMenuStrip = this.reportView;
            this.listOfSales.ShowEditingIcon = false;
            this.listOfSales.Size = new System.Drawing.Size(458, 398);
            this.listOfSales.TabIndex = 3;
            this.listOfSales.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfSales_CellMouseEnter);
            // 
            // SaleID
            // 
            this.SaleID.FillWeight = 41F;
            this.SaleID.Frozen = true;
            this.SaleID.HeaderText = "ID";
            this.SaleID.Name = "SaleID";
            this.SaleID.ReadOnly = true;
            this.SaleID.Width = 41;
            // 
            // ItemsSold
            // 
            this.ItemsSold.FillWeight = 105F;
            this.ItemsSold.Frozen = true;
            this.ItemsSold.HeaderText = "# of Items Sold";
            this.ItemsSold.Name = "ItemsSold";
            this.ItemsSold.ReadOnly = true;
            this.ItemsSold.Width = 105;
            // 
            // SubTotal
            // 
            this.SubTotal.FillWeight = 78F;
            this.SubTotal.Frozen = true;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 78;
            // 
            // Tax
            // 
            this.Tax.FillWeight = 80F;
            this.Tax.HeaderText = "Sales Tax";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 80;
            // 
            // Total
            // 
            this.Total.FillWeight = 75F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 75;
            // 
            // Profit
            // 
            this.Profit.FillWeight = 75F;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Width = 75;
            // 
            // reportView
            // 
            this.reportView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSaleToolStripMenuItem});
            this.reportView.Name = "reportView";
            this.reportView.Size = new System.Drawing.Size(131, 26);
            // 
            // viewSaleToolStripMenuItem
            // 
            this.viewSaleToolStripMenuItem.Name = "viewSaleToolStripMenuItem";
            this.viewSaleToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.viewSaleToolStripMenuItem.Text = "View Sale";
            this.viewSaleToolStripMenuItem.Click += new System.EventHandler(this.viewSaleToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.profitLbl);
            this.groupBox1.Controls.Add(this.totalLbl);
            this.groupBox1.Controls.Add(this.subTotalLbl);
            this.groupBox1.Controls.Add(this.taxTotalLbl);
            this.groupBox1.Controls.Add(this.itemsTotalLbl);
            this.groupBox1.Controls.Add(this.sumTlbl);
            this.groupBox1.Controls.Add(this.sumPLbl);
            this.groupBox1.Controls.Add(this.sumSLbl);
            this.groupBox1.Controls.Add(this.sumTaxLbl);
            this.groupBox1.Controls.Add(this.itemsSoldLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(503, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Summary";
            // 
            // profitLbl
            // 
            this.profitLbl.AutoSize = true;
            this.profitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitLbl.Location = new System.Drawing.Point(156, 138);
            this.profitLbl.Name = "profitLbl";
            this.profitLbl.Size = new System.Drawing.Size(34, 13);
            this.profitLbl.TabIndex = 9;
            this.profitLbl.Text = "$0.00";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(156, 110);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(34, 13);
            this.totalLbl.TabIndex = 8;
            this.totalLbl.Text = "$0.00";
            // 
            // subTotalLbl
            // 
            this.subTotalLbl.AutoSize = true;
            this.subTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLbl.Location = new System.Drawing.Point(156, 84);
            this.subTotalLbl.Name = "subTotalLbl";
            this.subTotalLbl.Size = new System.Drawing.Size(34, 13);
            this.subTotalLbl.TabIndex = 7;
            this.subTotalLbl.Text = "$0.00";
            // 
            // taxTotalLbl
            // 
            this.taxTotalLbl.AutoSize = true;
            this.taxTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxTotalLbl.Location = new System.Drawing.Point(156, 57);
            this.taxTotalLbl.Name = "taxTotalLbl";
            this.taxTotalLbl.Size = new System.Drawing.Size(34, 13);
            this.taxTotalLbl.TabIndex = 6;
            this.taxTotalLbl.Text = "$0.00";
            // 
            // itemsTotalLbl
            // 
            this.itemsTotalLbl.AutoSize = true;
            this.itemsTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsTotalLbl.Location = new System.Drawing.Point(156, 31);
            this.itemsTotalLbl.Name = "itemsTotalLbl";
            this.itemsTotalLbl.Size = new System.Drawing.Size(13, 13);
            this.itemsTotalLbl.TabIndex = 5;
            this.itemsTotalLbl.Text = "0";
            // 
            // sumTlbl
            // 
            this.sumTlbl.AutoSize = true;
            this.sumTlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumTlbl.Location = new System.Drawing.Point(13, 110);
            this.sumTlbl.Name = "sumTlbl";
            this.sumTlbl.Size = new System.Drawing.Size(83, 13);
            this.sumTlbl.TabIndex = 4;
            this.sumTlbl.Text = "Sum of Total:";
            // 
            // sumPLbl
            // 
            this.sumPLbl.AutoSize = true;
            this.sumPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumPLbl.Location = new System.Drawing.Point(13, 138);
            this.sumPLbl.Name = "sumPLbl";
            this.sumPLbl.Size = new System.Drawing.Size(84, 13);
            this.sumPLbl.TabIndex = 3;
            this.sumPLbl.Text = "Sum of Profit:";
            // 
            // sumSLbl
            // 
            this.sumSLbl.AutoSize = true;
            this.sumSLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumSLbl.Location = new System.Drawing.Point(13, 84);
            this.sumSLbl.Name = "sumSLbl";
            this.sumSLbl.Size = new System.Drawing.Size(109, 13);
            this.sumSLbl.TabIndex = 2;
            this.sumSLbl.Text = "Sum of Sub Total:";
            // 
            // sumTaxLbl
            // 
            this.sumTaxLbl.AutoSize = true;
            this.sumTaxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumTaxLbl.Location = new System.Drawing.Point(13, 57);
            this.sumTaxLbl.Name = "sumTaxLbl";
            this.sumTaxLbl.Size = new System.Drawing.Size(75, 13);
            this.sumTaxLbl.TabIndex = 1;
            this.sumTaxLbl.Text = "Sum of Tax:";
            // 
            // itemsSoldLbl
            // 
            this.itemsSoldLbl.AutoSize = true;
            this.itemsSoldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsSoldLbl.Location = new System.Drawing.Point(13, 31);
            this.itemsSoldLbl.Name = "itemsSoldLbl";
            this.itemsSoldLbl.Size = new System.Drawing.Size(113, 13);
            this.itemsSoldLbl.TabIndex = 0;
            this.itemsSoldLbl.Text = "Sum of Items Sold:";
            // 
            // cashGroup
            // 
            this.cashGroup.Controls.Add(this.updateButton);
            this.cashGroup.Controls.Add(this.listOfCash);
            this.cashGroup.Location = new System.Drawing.Point(503, 203);
            this.cashGroup.Name = "cashGroup";
            this.cashGroup.Size = new System.Drawing.Size(212, 200);
            this.cashGroup.TabIndex = 5;
            this.cashGroup.TabStop = false;
            this.cashGroup.Text = "Cash in Register";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightGray;
            this.updateButton.Location = new System.Drawing.Point(115, 166);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // listOfCash
            // 
            this.listOfCash.FormattingEnabled = true;
            this.listOfCash.Location = new System.Drawing.Point(19, 33);
            this.listOfCash.Name = "listOfCash";
            this.listOfCash.Size = new System.Drawing.Size(174, 121);
            this.listOfCash.TabIndex = 0;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cashGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listOfSales);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(742, 425);
            this.Load += new System.EventHandler(this.ReportControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfSales)).EndInit();
            this.reportView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cashGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfSales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label itemsSoldLbl;
        private System.Windows.Forms.Label taxTotalLbl;
        private System.Windows.Forms.Label itemsTotalLbl;
        private System.Windows.Forms.Label sumTlbl;
        private System.Windows.Forms.Label sumPLbl;
        private System.Windows.Forms.Label sumSLbl;
        private System.Windows.Forms.Label sumTaxLbl;
        private System.Windows.Forms.Label profitLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label subTotalLbl;
        private System.Windows.Forms.GroupBox cashGroup;
        private System.Windows.Forms.ListBox listOfCash;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ContextMenuStrip reportView;
        private System.Windows.Forms.ToolStripMenuItem viewSaleToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;

    }
}
