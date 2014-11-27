namespace Pos.UI
{
   partial class ItemSearchUI
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
          this.components = new System.ComponentModel.Container();
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSearchUI));
          this.searchByItemName = new System.Windows.Forms.RadioButton();
          this.searchBox = new System.Windows.Forms.TextBox();
          this.searchByStockNumber = new System.Windows.Forms.RadioButton();
          this.searchButton = new System.Windows.Forms.Button();
          this.resultGroupBox = new System.Windows.Forms.GroupBox();
          this.label5 = new System.Windows.Forms.Label();
          this.stockNumberLbl = new System.Windows.Forms.Label();
          this.cashLbl = new System.Windows.Forms.Label();
          this.quantityLbl = new System.Windows.Forms.Label();
          this.productNameLbl = new System.Windows.Forms.Label();
          this.productListBox = new System.Windows.Forms.ListBox();
          this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
          this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.acceptButton = new System.Windows.Forms.Button();
          this.cancelButton = new System.Windows.Forms.Button();
          this.quantityNum = new System.Windows.Forms.NumericUpDown();
          this.quantityReturnLbl = new System.Windows.Forms.Label();
          this.resultGroupBox.SuspendLayout();
          this.contextMenuStrip1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).BeginInit();
          this.SuspendLayout();
          // 
          // searchByItemName
          // 
          this.searchByItemName.AutoSize = true;
          this.searchByItemName.Checked = true;
          this.searchByItemName.Location = new System.Drawing.Point(58, 48);
          this.searchByItemName.Name = "searchByItemName";
          this.searchByItemName.Size = new System.Drawing.Size(127, 17);
          this.searchByItemName.TabIndex = 1;
          this.searchByItemName.TabStop = true;
          this.searchByItemName.Text = "Search by Item Name";
          this.searchByItemName.UseVisualStyleBackColor = true;
          // 
          // searchBox
          // 
          this.searchBox.Location = new System.Drawing.Point(13, 18);
          this.searchBox.Name = "searchBox";
          this.searchBox.Size = new System.Drawing.Size(341, 20);
          this.searchBox.TabIndex = 2;
          // 
          // searchByStockNumber
          // 
          this.searchByStockNumber.AutoSize = true;
          this.searchByStockNumber.Location = new System.Drawing.Point(254, 48);
          this.searchByStockNumber.Name = "searchByStockNumber";
          this.searchByStockNumber.Size = new System.Drawing.Size(144, 17);
          this.searchByStockNumber.TabIndex = 3;
          this.searchByStockNumber.Text = "Search by Stock Number";
          this.searchByStockNumber.UseVisualStyleBackColor = true;
          // 
          // searchButton
          // 
          this.searchButton.Location = new System.Drawing.Point(360, 16);
          this.searchButton.Name = "searchButton";
          this.searchButton.Size = new System.Drawing.Size(75, 23);
          this.searchButton.TabIndex = 4;
          this.searchButton.Text = "Search";
          this.searchButton.UseVisualStyleBackColor = true;
          this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
          // 
          // resultGroupBox
          // 
          this.resultGroupBox.Controls.Add(this.label5);
          this.resultGroupBox.Controls.Add(this.stockNumberLbl);
          this.resultGroupBox.Controls.Add(this.cashLbl);
          this.resultGroupBox.Controls.Add(this.quantityLbl);
          this.resultGroupBox.Controls.Add(this.productNameLbl);
          this.resultGroupBox.Controls.Add(this.productListBox);
          this.resultGroupBox.Location = new System.Drawing.Point(13, 88);
          this.resultGroupBox.Name = "resultGroupBox";
          this.resultGroupBox.Size = new System.Drawing.Size(422, 150);
          this.resultGroupBox.TabIndex = 5;
          this.resultGroupBox.TabStop = false;
          this.resultGroupBox.Text = "Results";
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label5.Location = new System.Drawing.Point(190, 16);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(105, 13);
          this.label5.TabIndex = 5;
          this.label5.Text = "Selected Product";
          // 
          // stockNumberLbl
          // 
          this.stockNumberLbl.AutoSize = true;
          this.stockNumberLbl.Location = new System.Drawing.Point(204, 110);
          this.stockNumberLbl.Name = "stockNumberLbl";
          this.stockNumberLbl.Size = new System.Drawing.Size(78, 13);
          this.stockNumberLbl.TabIndex = 4;
          this.stockNumberLbl.Text = "Stock Number:";
          // 
          // cashLbl
          // 
          this.cashLbl.AutoSize = true;
          this.cashLbl.Location = new System.Drawing.Point(204, 86);
          this.cashLbl.Name = "cashLbl";
          this.cashLbl.Size = new System.Drawing.Size(34, 13);
          this.cashLbl.TabIndex = 3;
          this.cashLbl.Text = "Price:";
          // 
          // quantityLbl
          // 
          this.quantityLbl.AutoSize = true;
          this.quantityLbl.Location = new System.Drawing.Point(204, 62);
          this.quantityLbl.Name = "quantityLbl";
          this.quantityLbl.Size = new System.Drawing.Size(49, 13);
          this.quantityLbl.TabIndex = 2;
          this.quantityLbl.Text = "Quantity:";
          // 
          // productNameLbl
          // 
          this.productNameLbl.AutoSize = true;
          this.productNameLbl.Location = new System.Drawing.Point(204, 37);
          this.productNameLbl.Name = "productNameLbl";
          this.productNameLbl.Size = new System.Drawing.Size(78, 13);
          this.productNameLbl.TabIndex = 1;
          this.productNameLbl.Text = "Product Name:";
          // 
          // productListBox
          // 
          this.productListBox.ContextMenuStrip = this.contextMenuStrip1;
          this.productListBox.FormattingEnabled = true;
          this.productListBox.Location = new System.Drawing.Point(45, 16);
          this.productListBox.Name = "productListBox";
          this.productListBox.ScrollAlwaysVisible = true;
          this.productListBox.Size = new System.Drawing.Size(120, 121);
          this.productListBox.TabIndex = 0;
          this.productListBox.SelectedIndexChanged += new System.EventHandler(this.productListBox_SelectedIndexChanged);
          // 
          // contextMenuStrip1
          // 
          this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
          this.contextMenuStrip1.Name = "contextMenuStrip1";
          this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
          // 
          // testToolStripMenuItem
          // 
          this.testToolStripMenuItem.Name = "testToolStripMenuItem";
          this.testToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
          this.testToolStripMenuItem.Text = "test";
          // 
          // acceptButton
          // 
          this.acceptButton.Enabled = false;
          this.acceptButton.Location = new System.Drawing.Point(270, 248);
          this.acceptButton.Name = "acceptButton";
          this.acceptButton.Size = new System.Drawing.Size(75, 23);
          this.acceptButton.TabIndex = 6;
          this.acceptButton.Text = "Accept";
          this.acceptButton.UseVisualStyleBackColor = true;
          this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
          // 
          // cancelButton
          // 
          this.cancelButton.Location = new System.Drawing.Point(351, 248);
          this.cancelButton.Name = "cancelButton";
          this.cancelButton.Size = new System.Drawing.Size(75, 23);
          this.cancelButton.TabIndex = 7;
          this.cancelButton.Text = "Cancel";
          this.cancelButton.UseVisualStyleBackColor = true;
          // 
          // quantityNum
          // 
          this.quantityNum.Enabled = false;
          this.quantityNum.Location = new System.Drawing.Point(129, 251);
          this.quantityNum.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
          this.quantityNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
          this.quantityNum.Name = "quantityNum";
          this.quantityNum.Size = new System.Drawing.Size(82, 20);
          this.quantityNum.TabIndex = 8;
          this.quantityNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
          // 
          // quantityReturnLbl
          // 
          this.quantityReturnLbl.AutoSize = true;
          this.quantityReturnLbl.Enabled = false;
          this.quantityReturnLbl.Location = new System.Drawing.Point(63, 253);
          this.quantityReturnLbl.Name = "quantityReturnLbl";
          this.quantityReturnLbl.Size = new System.Drawing.Size(49, 13);
          this.quantityReturnLbl.TabIndex = 9;
          this.quantityReturnLbl.Text = "Quantity:";
          // 
          // ItemSearchUI
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(447, 281);
          this.Controls.Add(this.quantityReturnLbl);
          this.Controls.Add(this.quantityNum);
          this.Controls.Add(this.cancelButton);
          this.Controls.Add(this.acceptButton);
          this.Controls.Add(this.resultGroupBox);
          this.Controls.Add(this.searchButton);
          this.Controls.Add(this.searchByStockNumber);
          this.Controls.Add(this.searchBox);
          this.Controls.Add(this.searchByItemName);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "ItemSearchUI";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Item Search";
          this.Load += new System.EventHandler(this.ItemSearchUI_Load);
          this.resultGroupBox.ResumeLayout(false);
          this.resultGroupBox.PerformLayout();
          this.contextMenuStrip1.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.RadioButton searchByItemName;
      private System.Windows.Forms.TextBox searchBox;
      private System.Windows.Forms.RadioButton searchByStockNumber;
      private System.Windows.Forms.Button searchButton;
      private System.Windows.Forms.GroupBox resultGroupBox;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label stockNumberLbl;
      private System.Windows.Forms.Label cashLbl;
      private System.Windows.Forms.Label quantityLbl;
      private System.Windows.Forms.Label productNameLbl;
      private System.Windows.Forms.ListBox productListBox;
      private System.Windows.Forms.Button acceptButton;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.NumericUpDown quantityNum;
      private System.Windows.Forms.Label quantityReturnLbl;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
   }
}