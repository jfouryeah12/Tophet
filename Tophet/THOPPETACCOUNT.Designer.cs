
namespace Tophet
{
    partial class THOPPETACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THOPPETACCOUNT));
            this.ListLabel = new System.Windows.Forms.Label();
            this.AccountButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AccountDetailLabel = new System.Windows.Forms.Label();
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.ManageAccountLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TipsLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new Tophet.RoundedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.EditionName = new System.Windows.Forms.Label();
            this.LobbyLink = new System.Windows.Forms.LinkLabel();
            this.AccountPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLabel.ForeColor = System.Drawing.Color.Snow;
            this.ListLabel.Location = new System.Drawing.Point(12, 15);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(97, 30);
            this.ListLabel.TabIndex = 16;
            this.ListLabel.Text = "Account";
            // 
            // AccountButton
            // 
            this.AccountButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountButton.Enabled = false;
            this.AccountButton.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountButton.ForeColor = System.Drawing.Color.White;
            this.AccountButton.Location = new System.Drawing.Point(604, 60);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(289, 68);
            this.AccountButton.TabIndex = 15;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = false;
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.FilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FilterButton.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.ForeColor = System.Drawing.Color.White;
            this.FilterButton.Location = new System.Drawing.Point(292, 60);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(306, 68);
            this.FilterButton.TabIndex = 14;
            this.FilterButton.Text = "Filter Protection";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsButton.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(2, 60);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(284, 68);
            this.SettingsButton.TabIndex = 13;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AccountDetailLabel
            // 
            this.AccountDetailLabel.AutoSize = true;
            this.AccountDetailLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccountDetailLabel.Font = new System.Drawing.Font("Alef", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountDetailLabel.ForeColor = System.Drawing.Color.Black;
            this.AccountDetailLabel.Location = new System.Drawing.Point(16, 16);
            this.AccountDetailLabel.Name = "AccountDetailLabel";
            this.AccountDetailLabel.Size = new System.Drawing.Size(175, 28);
            this.AccountDetailLabel.TabIndex = 8;
            this.AccountDetailLabel.Text = "Account Details";
            // 
            // DeviceNameLabel
            // 
            this.DeviceNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceNameLabel.AutoEllipsis = true;
            this.DeviceNameLabel.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.DeviceNameLabel.Location = new System.Drawing.Point(17, 76);
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            this.DeviceNameLabel.Size = new System.Drawing.Size(144, 24);
            this.DeviceNameLabel.TabIndex = 10;
            this.DeviceNameLabel.Text = "Device name";
            this.DeviceNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.ManageAccountLabel);
            this.AccountPanel.Controls.Add(this.panel2);
            this.AccountPanel.Controls.Add(this.label7);
            this.AccountPanel.Controls.Add(this.label6);
            this.AccountPanel.Controls.Add(this.label5);
            this.AccountPanel.Controls.Add(this.label4);
            this.AccountPanel.Controls.Add(this.StatusLabel);
            this.AccountPanel.Controls.Add(this.KeyLabel);
            this.AccountPanel.Controls.Add(this.EditionName);
            this.AccountPanel.Controls.Add(this.DeviceNameLabel);
            this.AccountPanel.Controls.Add(this.AccountDetailLabel);
            this.AccountPanel.Location = new System.Drawing.Point(12, 134);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(871, 332);
            this.AccountPanel.TabIndex = 17;
            // 
            // ManageAccountLabel
            // 
            this.ManageAccountLabel.AutoSize = true;
            this.ManageAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManageAccountLabel.Font = new System.Drawing.Font("Alef", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAccountLabel.ForeColor = System.Drawing.Color.Black;
            this.ManageAccountLabel.Location = new System.Drawing.Point(40, 228);
            this.ManageAccountLabel.Name = "ManageAccountLabel";
            this.ManageAccountLabel.Size = new System.Drawing.Size(184, 28);
            this.ManageAccountLabel.TabIndex = 19;
            this.ManageAccountLabel.Text = "Manage Account";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TipsLabel);
            this.panel2.Controls.Add(this.LogoutButton);
            this.panel2.Location = new System.Drawing.Point(21, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 59);
            this.panel2.TabIndex = 18;
            // 
            // TipsLabel
            // 
            this.TipsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TipsLabel.AutoEllipsis = true;
            this.TipsLabel.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipsLabel.ForeColor = System.Drawing.Color.Black;
            this.TipsLabel.Location = new System.Drawing.Point(18, 17);
            this.TipsLabel.Name = "TipsLabel";
            this.TipsLabel.Size = new System.Drawing.Size(325, 24);
            this.TipsLabel.TabIndex = 20;
            this.TipsLabel.Text = "Help protect your password from hackers";
            this.TipsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.LogoutButton.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(580, 6);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(245, 46);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoEllipsis = true;
            this.label7.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(467, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Never expires";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoEllipsis = true;
            this.label6.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(317, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "100-200-300-400-500";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(167, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Premium";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Admin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoEllipsis = true;
            this.StatusLabel.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Silver;
            this.StatusLabel.Location = new System.Drawing.Point(467, 76);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(144, 24);
            this.StatusLabel.TabIndex = 13;
            this.StatusLabel.Text = "Status";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KeyLabel
            // 
            this.KeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyLabel.AutoEllipsis = true;
            this.KeyLabel.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyLabel.ForeColor = System.Drawing.Color.Silver;
            this.KeyLabel.Location = new System.Drawing.Point(317, 76);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(144, 24);
            this.KeyLabel.TabIndex = 12;
            this.KeyLabel.Text = "License Key";
            this.KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditionName
            // 
            this.EditionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditionName.AutoEllipsis = true;
            this.EditionName.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditionName.ForeColor = System.Drawing.Color.Silver;
            this.EditionName.Location = new System.Drawing.Point(167, 76);
            this.EditionName.Name = "EditionName";
            this.EditionName.Size = new System.Drawing.Size(144, 24);
            this.EditionName.TabIndex = 11;
            this.EditionName.Text = "Edition";
            this.EditionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LobbyLink
            // 
            this.LobbyLink.AutoSize = true;
            this.LobbyLink.BackColor = System.Drawing.Color.Transparent;
            this.LobbyLink.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LobbyLink.LinkColor = System.Drawing.Color.White;
            this.LobbyLink.Location = new System.Drawing.Point(819, 9);
            this.LobbyLink.Name = "LobbyLink";
            this.LobbyLink.Size = new System.Drawing.Size(64, 22);
            this.LobbyLink.TabIndex = 18;
            this.LobbyLink.TabStop = true;
            this.LobbyLink.Text = "LOBBY";
            this.LobbyLink.VisitedLinkColor = System.Drawing.Color.Lime;
            this.LobbyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LobbyLink_LinkClicked);
            // 
            // THOPPETACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tophet.Properties.Resources.darkmode;
            this.ClientSize = new System.Drawing.Size(895, 481);
            this.Controls.Add(this.LobbyLink);
            this.Controls.Add(this.AccountPanel);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.SettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "THOPPETACCOUNT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THOPPETACCOUNT";
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label AccountDetailLabel;
        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.Label ManageAccountLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TipsLabel;
        private RoundedButton LogoutButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label EditionName;
        private System.Windows.Forms.LinkLabel LobbyLink;
    }
}