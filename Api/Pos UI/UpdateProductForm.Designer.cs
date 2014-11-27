namespace Pos.UI
{
    partial class UpdateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductForm));
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.quantityNum = new System.Windows.Forms.NumericUpDown();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.costNum = new System.Windows.Forms.NumericUpDown();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameBox
            // 
            this.itemNameBox.Location = new System.Drawing.Point(124, 12);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(163, 20);
            this.itemNameBox.TabIndex = 3;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Location = new System.Drawing.Point(13, 15);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(61, 13);
            this.itemNameLbl.TabIndex = 4;
            this.itemNameLbl.Text = "Item Name:";
            // 
            // quantityNum
            // 
            this.quantityNum.Location = new System.Drawing.Point(124, 38);
            this.quantityNum.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.quantityNum.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.quantityNum.Name = "quantityNum";
            this.quantityNum.Size = new System.Drawing.Size(163, 20);
            this.quantityNum.TabIndex = 5;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(13, 40);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(49, 13);
            this.quantityLbl.TabIndex = 6;
            this.quantityLbl.Text = "Quantity:";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(13, 66);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(71, 13);
            this.costLbl.TabIndex = 7;
            this.costLbl.Text = "Cost (For Us):";
            // 
            // costNum
            // 
            this.costNum.DecimalPlaces = 2;
            this.costNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.costNum.Location = new System.Drawing.Point(124, 64);
            this.costNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.costNum.Name = "costNum";
            this.costNum.Size = new System.Drawing.Size(163, 20);
            this.costNum.TabIndex = 8;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(13, 92);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(88, 13);
            this.priceLbl.TabIndex = 9;
            this.priceLbl.Text = "Price (For Them):";
            // 
            // priceNum
            // 
            this.priceNum.DecimalPlaces = 2;
            this.priceNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNum.Location = new System.Drawing.Point(124, 90);
            this.priceNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(163, 20);
            this.priceNum.TabIndex = 10;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(124, 122);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(213, 122);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 157);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.costNum);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.quantityNum);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.itemNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemNameBox;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.NumericUpDown costNum;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.NumericUpDown priceNum;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown quantityNum;
    }
}