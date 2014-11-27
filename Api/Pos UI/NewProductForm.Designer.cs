namespace Pos.UI
{
    partial class NewProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductForm));
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stockNumberNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.costNum = new System.Windows.Forms.NumericUpDown();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumberNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(41, 145);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(122, 145);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // stockNumberNum
            // 
            this.stockNumberNum.Location = new System.Drawing.Point(120, 11);
            this.stockNumberNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stockNumberNum.Name = "stockNumberNum";
            this.stockNumberNum.Size = new System.Drawing.Size(100, 20);
            this.stockNumberNum.TabIndex = 4;
            this.stockNumberNum.ValueChanged += new System.EventHandler(this.StockNumberNum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stock Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Name:";
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(120, 43);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(100, 20);
            this.itemName.TabIndex = 7;
            this.itemName.TextChanged += new System.EventHandler(this.itemName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost (For Us):";
            // 
            // costNum
            // 
            this.costNum.DecimalPlaces = 2;
            this.costNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.costNum.Location = new System.Drawing.Point(120, 76);
            this.costNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costNum.Name = "costNum";
            this.costNum.Size = new System.Drawing.Size(100, 20);
            this.costNum.TabIndex = 9;
            this.costNum.ValueChanged += new System.EventHandler(this.costNum_ValueChanged);
            // 
            // priceNum
            // 
            this.priceNum.DecimalPlaces = 2;
            this.priceNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNum.Location = new System.Drawing.Point(120, 109);
            this.priceNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(100, 20);
            this.priceNum.TabIndex = 10;
            this.priceNum.ValueChanged += new System.EventHandler(this.priceNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price (For Them):";
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 181);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.costNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stockNumberNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            ((System.ComponentModel.ISupportInitialize)(this.stockNumberNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown stockNumberNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown costNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown priceNum;
    }
}