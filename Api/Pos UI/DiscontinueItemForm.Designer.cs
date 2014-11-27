namespace Pos.UI
{
    partial class DiscontinueItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscontinueItemForm));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBySN = new System.Windows.Forms.RadioButton();
            this.searchByItemName = new System.Windows.Forms.RadioButton();
            this.listOfProducts = new System.Windows.Forms.ListBox();
            this.disconButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(184, 20);
            this.searchBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(202, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBySN
            // 
            this.searchBySN.AutoSize = true;
            this.searchBySN.Checked = true;
            this.searchBySN.Location = new System.Drawing.Point(22, 42);
            this.searchBySN.Name = "searchBySN";
            this.searchBySN.Size = new System.Drawing.Size(91, 17);
            this.searchBySN.TabIndex = 2;
            this.searchBySN.TabStop = true;
            this.searchBySN.Text = "Search by SN";
            this.searchBySN.UseVisualStyleBackColor = true;
            // 
            // searchByItemName
            // 
            this.searchByItemName.AutoSize = true;
            this.searchByItemName.Location = new System.Drawing.Point(140, 42);
            this.searchByItemName.Name = "searchByItemName";
            this.searchByItemName.Size = new System.Drawing.Size(127, 17);
            this.searchByItemName.TabIndex = 3;
            this.searchByItemName.Text = "Search by Item Name";
            this.searchByItemName.UseVisualStyleBackColor = true;
            // 
            // listOfProducts
            // 
            this.listOfProducts.FormattingEnabled = true;
            this.listOfProducts.Location = new System.Drawing.Point(12, 69);
            this.listOfProducts.Name = "listOfProducts";
            this.listOfProducts.Size = new System.Drawing.Size(265, 121);
            this.listOfProducts.TabIndex = 4;
            this.listOfProducts.SelectedIndexChanged += new System.EventHandler(this.listOfProducts_SelectedIndexChanged);
            // 
            // disconButton
            // 
            this.disconButton.Enabled = false;
            this.disconButton.Location = new System.Drawing.Point(121, 196);
            this.disconButton.Name = "disconButton";
            this.disconButton.Size = new System.Drawing.Size(75, 23);
            this.disconButton.TabIndex = 5;
            this.disconButton.Text = "Discontinue";
            this.disconButton.UseVisualStyleBackColor = true;
            this.disconButton.Click += new System.EventHandler(this.disconButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(202, 196);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // DiscontinueItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 225);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.disconButton);
            this.Controls.Add(this.listOfProducts);
            this.Controls.Add(this.searchByItemName);
            this.Controls.Add(this.searchBySN);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiscontinueItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discontinue Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton searchBySN;
        private System.Windows.Forms.RadioButton searchByItemName;
        private System.Windows.Forms.ListBox listOfProducts;
        private System.Windows.Forms.Button disconButton;
        private System.Windows.Forms.Button cancelButton;
    }
}