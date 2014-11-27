namespace Pos.UI
{
    partial class ChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeForm));
            this.provideLbl = new System.Windows.Forms.Label();
            this.changeList = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // provideLbl
            // 
            this.provideLbl.AutoSize = true;
            this.provideLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provideLbl.Location = new System.Drawing.Point(16, 39);
            this.provideLbl.Name = "provideLbl";
            this.provideLbl.Size = new System.Drawing.Size(186, 13);
            this.provideLbl.TabIndex = 0;
            this.provideLbl.Text = "Please Provide the Following Change:";
            // 
            // changeList
            // 
            this.changeList.FormattingEnabled = true;
            this.changeList.Location = new System.Drawing.Point(12, 64);
            this.changeList.Name = "changeList";
            this.changeList.Size = new System.Drawing.Size(197, 108);
            this.changeList.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(134, 181);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(57, 10);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(97, 18);
            this.totalLbl.TabIndex = 3;
            this.totalLbl.Text = "Total: $0.00";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 213);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.changeList);
            this.Controls.Add(this.provideLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label provideLbl;
        private System.Windows.Forms.ListBox changeList;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label totalLbl;
    }
}