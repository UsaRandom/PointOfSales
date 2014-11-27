namespace Pos.UI
{
   partial class DataSourceSelectorUI
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSourceSelectorUI));
          this.tabControl = new System.Windows.Forms.TabControl();
          this.tabPage1 = new System.Windows.Forms.TabPage();
          this.usernameBox = new System.Windows.Forms.ComboBox();
          this.serverLocationLbl = new System.Windows.Forms.Label();
          this.passLbl = new System.Windows.Forms.Label();
          this.userLbl = new System.Windows.Forms.Label();
          this.dbNameLbl = new System.Windows.Forms.Label();
          this.passwordBox = new System.Windows.Forms.TextBox();
          this.databaseNameBox = new System.Windows.Forms.ComboBox();
          this.serverLocationBox = new System.Windows.Forms.ComboBox();
          this.xmlTab = new System.Windows.Forms.TabPage();
          this.validationGroup = new System.Windows.Forms.GroupBox();
          this.schemaLocationBox = new System.Windows.Forms.ComboBox();
          this.schemaLbl = new System.Windows.Forms.Label();
          this.validateXmlCheckBox = new System.Windows.Forms.CheckBox();
          this.xmlFileLocationBox = new System.Windows.Forms.ComboBox();
          this.fileLocationLbl = new System.Windows.Forms.Label();
          this.connectButton = new System.Windows.Forms.Button();
          this.cancelButton = new System.Windows.Forms.Button();
          this.tabControl.SuspendLayout();
          this.tabPage1.SuspendLayout();
          this.xmlTab.SuspendLayout();
          this.validationGroup.SuspendLayout();
          this.SuspendLayout();
          // 
          // tabControl
          // 
          this.tabControl.Controls.Add(this.tabPage1);
          this.tabControl.Controls.Add(this.xmlTab);
          this.tabControl.Location = new System.Drawing.Point(12, 12);
          this.tabControl.Name = "tabControl";
          this.tabControl.SelectedIndex = 0;
          this.tabControl.Size = new System.Drawing.Size(350, 157);
          this.tabControl.TabIndex = 0;
          // 
          // tabPage1
          // 
          this.tabPage1.Controls.Add(this.usernameBox);
          this.tabPage1.Controls.Add(this.serverLocationLbl);
          this.tabPage1.Controls.Add(this.passLbl);
          this.tabPage1.Controls.Add(this.userLbl);
          this.tabPage1.Controls.Add(this.dbNameLbl);
          this.tabPage1.Controls.Add(this.passwordBox);
          this.tabPage1.Controls.Add(this.databaseNameBox);
          this.tabPage1.Controls.Add(this.serverLocationBox);
          this.tabPage1.Location = new System.Drawing.Point(4, 22);
          this.tabPage1.Name = "tabPage1";
          this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
          this.tabPage1.Size = new System.Drawing.Size(342, 131);
          this.tabPage1.TabIndex = 0;
          this.tabPage1.Text = "SQL Server";
          this.tabPage1.UseVisualStyleBackColor = true;
          // 
          // usernameBox
          // 
          this.usernameBox.FormattingEnabled = true;
          this.usernameBox.Items.AddRange(new object[] {
            "",
            "PosUser"});
          this.usernameBox.Location = new System.Drawing.Point(104, 70);
          this.usernameBox.Name = "usernameBox";
          this.usernameBox.Size = new System.Drawing.Size(222, 21);
          this.usernameBox.TabIndex = 10;
          this.usernameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.usernameBox_KeyUp);
          // 
          // serverLocationLbl
          // 
          this.serverLocationLbl.AutoSize = true;
          this.serverLocationLbl.Location = new System.Drawing.Point(13, 13);
          this.serverLocationLbl.Name = "serverLocationLbl";
          this.serverLocationLbl.Size = new System.Drawing.Size(85, 13);
          this.serverLocationLbl.TabIndex = 3;
          this.serverLocationLbl.Text = "Server Location:";
          // 
          // passLbl
          // 
          this.passLbl.AutoSize = true;
          this.passLbl.Location = new System.Drawing.Point(13, 101);
          this.passLbl.Name = "passLbl";
          this.passLbl.Size = new System.Drawing.Size(56, 13);
          this.passLbl.TabIndex = 2;
          this.passLbl.Text = "Password:";
          // 
          // userLbl
          // 
          this.userLbl.AutoSize = true;
          this.userLbl.Location = new System.Drawing.Point(13, 73);
          this.userLbl.Name = "userLbl";
          this.userLbl.Size = new System.Drawing.Size(63, 13);
          this.userLbl.TabIndex = 1;
          this.userLbl.Text = "User Name:";
          // 
          // dbNameLbl
          // 
          this.dbNameLbl.AutoSize = true;
          this.dbNameLbl.Location = new System.Drawing.Point(13, 42);
          this.dbNameLbl.Name = "dbNameLbl";
          this.dbNameLbl.Size = new System.Drawing.Size(87, 13);
          this.dbNameLbl.TabIndex = 0;
          this.dbNameLbl.Text = "Database Name:";
          // 
          // passwordBox
          // 
          this.passwordBox.Location = new System.Drawing.Point(104, 98);
          this.passwordBox.Name = "passwordBox";
          this.passwordBox.PasswordChar = '*';
          this.passwordBox.Size = new System.Drawing.Size(222, 20);
          this.passwordBox.TabIndex = 7;
          this.passwordBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyDown);
          // 
          // databaseNameBox
          // 
          this.databaseNameBox.FormattingEnabled = true;
          this.databaseNameBox.Items.AddRange(new object[] {
            "",
            "PosData"});
          this.databaseNameBox.Location = new System.Drawing.Point(104, 39);
          this.databaseNameBox.Name = "databaseNameBox";
          this.databaseNameBox.Size = new System.Drawing.Size(222, 21);
          this.databaseNameBox.TabIndex = 9;
          this.databaseNameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.databaseNameBox_KeyUp);
          // 
          // serverLocationBox
          // 
          this.serverLocationBox.FormattingEnabled = true;
          this.serverLocationBox.Items.AddRange(new object[] {
            "",
            "localhost",
            "localhost\\SQLEXPRESS"});
          this.serverLocationBox.Location = new System.Drawing.Point(104, 10);
          this.serverLocationBox.Name = "serverLocationBox";
          this.serverLocationBox.Size = new System.Drawing.Size(222, 21);
          this.serverLocationBox.TabIndex = 8;
          this.serverLocationBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.serverLocationBox_KeyUp);
          // 
          // xmlTab
          // 
          this.xmlTab.Controls.Add(this.validationGroup);
          this.xmlTab.Controls.Add(this.xmlFileLocationBox);
          this.xmlTab.Controls.Add(this.fileLocationLbl);
          this.xmlTab.Location = new System.Drawing.Point(4, 22);
          this.xmlTab.Name = "xmlTab";
          this.xmlTab.Padding = new System.Windows.Forms.Padding(3);
          this.xmlTab.Size = new System.Drawing.Size(342, 131);
          this.xmlTab.TabIndex = 1;
          this.xmlTab.Text = "XML Record";
          this.xmlTab.UseVisualStyleBackColor = true;
          // 
          // validationGroup
          // 
          this.validationGroup.Controls.Add(this.schemaLocationBox);
          this.validationGroup.Controls.Add(this.schemaLbl);
          this.validationGroup.Controls.Add(this.validateXmlCheckBox);
          this.validationGroup.Location = new System.Drawing.Point(6, 48);
          this.validationGroup.Name = "validationGroup";
          this.validationGroup.Size = new System.Drawing.Size(324, 77);
          this.validationGroup.TabIndex = 3;
          this.validationGroup.TabStop = false;
          this.validationGroup.Text = "Validation";
          // 
          // schemaLocationBox
          // 
          this.schemaLocationBox.Enabled = false;
          this.schemaLocationBox.FormattingEnabled = true;
          this.schemaLocationBox.Location = new System.Drawing.Point(109, 47);
          this.schemaLocationBox.Name = "schemaLocationBox";
          this.schemaLocationBox.Size = new System.Drawing.Size(209, 21);
          this.schemaLocationBox.TabIndex = 4;
          this.schemaLocationBox.SelectedIndexChanged += new System.EventHandler(this.schemaLocationBox_SelectedIndexChanged);
          this.schemaLocationBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.schemaLocationBox_KeyUp);
          // 
          // schemaLbl
          // 
          this.schemaLbl.AutoSize = true;
          this.schemaLbl.Enabled = false;
          this.schemaLbl.Location = new System.Drawing.Point(10, 50);
          this.schemaLbl.Name = "schemaLbl";
          this.schemaLbl.Size = new System.Drawing.Size(93, 13);
          this.schemaLbl.TabIndex = 3;
          this.schemaLbl.Text = "Schema Location:";
          // 
          // validateXmlCheckBox
          // 
          this.validateXmlCheckBox.AutoSize = true;
          this.validateXmlCheckBox.Location = new System.Drawing.Point(103, 19);
          this.validateXmlCheckBox.Name = "validateXmlCheckBox";
          this.validateXmlCheckBox.Size = new System.Drawing.Size(108, 17);
          this.validateXmlCheckBox.TabIndex = 2;
          this.validateXmlCheckBox.Text = "Validate XML File";
          this.validateXmlCheckBox.UseVisualStyleBackColor = true;
          this.validateXmlCheckBox.CheckedChanged += new System.EventHandler(this.validateXmlCheckBox_CheckedChanged);
          // 
          // xmlFileLocationBox
          // 
          this.xmlFileLocationBox.FormattingEnabled = true;
          this.xmlFileLocationBox.Location = new System.Drawing.Point(82, 10);
          this.xmlFileLocationBox.Name = "xmlFileLocationBox";
          this.xmlFileLocationBox.Size = new System.Drawing.Size(244, 21);
          this.xmlFileLocationBox.TabIndex = 1;
          this.xmlFileLocationBox.SelectedIndexChanged += new System.EventHandler(this.xmlFileLocationBox_SelectedIndexChanged);
          this.xmlFileLocationBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.xmlFileLocationBox_KeyUp);
          // 
          // fileLocationLbl
          // 
          this.fileLocationLbl.AutoSize = true;
          this.fileLocationLbl.Location = new System.Drawing.Point(6, 13);
          this.fileLocationLbl.Name = "fileLocationLbl";
          this.fileLocationLbl.Size = new System.Drawing.Size(70, 13);
          this.fileLocationLbl.TabIndex = 0;
          this.fileLocationLbl.Text = "File Location:";
          // 
          // connectButton
          // 
          this.connectButton.Location = new System.Drawing.Point(206, 175);
          this.connectButton.Name = "connectButton";
          this.connectButton.Size = new System.Drawing.Size(75, 23);
          this.connectButton.TabIndex = 1;
          this.connectButton.Text = "Connect";
          this.connectButton.UseVisualStyleBackColor = true;
          this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
          // 
          // cancelButton
          // 
          this.cancelButton.Location = new System.Drawing.Point(287, 175);
          this.cancelButton.Name = "cancelButton";
          this.cancelButton.Size = new System.Drawing.Size(75, 23);
          this.cancelButton.TabIndex = 2;
          this.cancelButton.Text = "Cancel";
          this.cancelButton.UseVisualStyleBackColor = true;
          // 
          // DataSourceSelectorUI
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(374, 205);
          this.Controls.Add(this.connectButton);
          this.Controls.Add(this.cancelButton);
          this.Controls.Add(this.tabControl);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "DataSourceSelectorUI";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Data Source Selector";
          this.TopMost = true;
          this.Load += new System.EventHandler(this.DataSourceSelectorUI_Load);
          this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
          this.tabControl.ResumeLayout(false);
          this.tabPage1.ResumeLayout(false);
          this.tabPage1.PerformLayout();
          this.xmlTab.ResumeLayout(false);
          this.xmlTab.PerformLayout();
          this.validationGroup.ResumeLayout(false);
          this.validationGroup.PerformLayout();
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage xmlTab;
      private System.Windows.Forms.Button connectButton;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.Label serverLocationLbl;
      private System.Windows.Forms.Label passLbl;
      private System.Windows.Forms.Label userLbl;
      private System.Windows.Forms.ComboBox xmlFileLocationBox;
      private System.Windows.Forms.Label fileLocationLbl;
      private System.Windows.Forms.CheckBox validateXmlCheckBox;
      private System.Windows.Forms.GroupBox validationGroup;
      private System.Windows.Forms.ComboBox schemaLocationBox;
      private System.Windows.Forms.Label schemaLbl;
      private System.Windows.Forms.ComboBox databaseNameBox;
      private System.Windows.Forms.ComboBox serverLocationBox;
      private System.Windows.Forms.Label dbNameLbl;
      private System.Windows.Forms.TextBox passwordBox;
      private System.Windows.Forms.ComboBox usernameBox;
   }
}