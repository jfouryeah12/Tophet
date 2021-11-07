
namespace Tophet
{
    partial class THOPETLOG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THOPETLOG));
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.OptionKeyActLabel = new System.Windows.Forms.LinkLabel();
            this.GuestActLabel = new System.Windows.Forms.LinkLabel();
            this.imageData1 = new Tophet.ImageData();
            ((System.ComponentModel.ISupportInitialize)(this.imageData1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Location = new System.Drawing.Point(144, 106);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(64, 20);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "LOGIN";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.Color.Silver;
            this.PasswordBox.Location = new System.Drawing.Point(53, 343);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(244, 29);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.Color.Silver;
            this.EmailBox.Location = new System.Drawing.Point(53, 299);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(244, 29);
            this.EmailBox.TabIndex = 0;
            this.EmailBox.Text = "Username";
            this.EmailBox.Enter += new System.EventHandler(this.Emailbox_TextChanged);
            this.EmailBox.Leave += new System.EventHandler(this.EmailBox_Leave);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(128, 384);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 37);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseMnemonic = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntroLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IntroLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroLabel.ForeColor = System.Drawing.Color.Snow;
            this.IntroLabel.Location = new System.Drawing.Point(12, 9);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(104, 30);
            this.IntroLabel.TabIndex = 5;
            this.IntroLabel.Text = "TOPHET";
            // 
            // OptionKeyActLabel
            // 
            this.OptionKeyActLabel.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.OptionKeyActLabel.AutoSize = true;
            this.OptionKeyActLabel.BackColor = System.Drawing.Color.Transparent;
            this.OptionKeyActLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OptionKeyActLabel.Location = new System.Drawing.Point(120, 437);
            this.OptionKeyActLabel.Name = "OptionKeyActLabel";
            this.OptionKeyActLabel.Size = new System.Drawing.Size(120, 13);
            this.OptionKeyActLabel.TabIndex = 6;
            this.OptionKeyActLabel.TabStop = true;
            this.OptionKeyActLabel.Text = "ACTIVATE USING KEY";
            this.OptionKeyActLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OptionKeyActLabel_LinkClicked);
            // 
            // GuestActLabel
            // 
            this.GuestActLabel.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.GuestActLabel.AutoSize = true;
            this.GuestActLabel.BackColor = System.Drawing.Color.Transparent;
            this.GuestActLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GuestActLabel.Location = new System.Drawing.Point(267, 531);
            this.GuestActLabel.Name = "GuestActLabel";
            this.GuestActLabel.Size = new System.Drawing.Size(79, 13);
            this.GuestActLabel.TabIndex = 7;
            this.GuestActLabel.TabStop = true;
            this.GuestActLabel.Text = "GUEST MODE";
            // 
            // imageData1
            // 
            this.imageData1.BackgroundImage = global::Tophet.Properties.Resources.UserDefault;
            this.imageData1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageData1.Location = new System.Drawing.Point(123, 165);
            this.imageData1.Name = "imageData1";
            this.imageData1.Size = new System.Drawing.Size(105, 102);
            this.imageData1.TabIndex = 2;
            this.imageData1.TabStop = false;
            // 
            // THOPETLOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 553);
            this.Controls.Add(this.GuestActLabel);
            this.Controls.Add(this.OptionKeyActLabel);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.imageData1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "THOPETLOG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPHET*LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.imageData1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ImageData imageData1;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.LinkLabel OptionKeyActLabel;
        private System.Windows.Forms.LinkLabel GuestActLabel;
    }
}

