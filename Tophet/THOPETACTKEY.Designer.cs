
namespace Tophet
{
    partial class THOPETACTKEY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THOPETACTKEY));
            this.IntroKeyLabel = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.ActivateKeyButton = new System.Windows.Forms.Button();
            this.OptionKeyActLabel = new System.Windows.Forms.LinkLabel();
            this.GuestActLabel = new System.Windows.Forms.LinkLabel();
            this.ExitLabelFunction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntroKeyLabel
            // 
            this.IntroKeyLabel.AutoSize = true;
            this.IntroKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntroKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IntroKeyLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroKeyLabel.ForeColor = System.Drawing.Color.Snow;
            this.IntroKeyLabel.Location = new System.Drawing.Point(12, 9);
            this.IntroKeyLabel.Name = "IntroKeyLabel";
            this.IntroKeyLabel.Size = new System.Drawing.Size(104, 30);
            this.IntroKeyLabel.TabIndex = 6;
            this.IntroKeyLabel.Text = "TOPHET";
            // 
            // KeyBox
            // 
            this.KeyBox.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyBox.ForeColor = System.Drawing.Color.Silver;
            this.KeyBox.Location = new System.Drawing.Point(57, 262);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(244, 29);
            this.KeyBox.TabIndex = 7;
            this.KeyBox.Text = "XXX-XXX-XXX-XXX-XXX";
            this.KeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyBox.Enter += new System.EventHandler(this.KeyBox_TextChanged);
            this.KeyBox.Leave += new System.EventHandler(this.KeyBox_Leave);
            // 
            // ActivateKeyButton
            // 
            this.ActivateKeyButton.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateKeyButton.Location = new System.Drawing.Point(120, 297);
            this.ActivateKeyButton.Name = "ActivateKeyButton";
            this.ActivateKeyButton.Size = new System.Drawing.Size(118, 37);
            this.ActivateKeyButton.TabIndex = 8;
            this.ActivateKeyButton.Text = "Activate Key";
            this.ActivateKeyButton.UseMnemonic = false;
            this.ActivateKeyButton.UseVisualStyleBackColor = true;
            this.ActivateKeyButton.Click += new System.EventHandler(this.ActivateKeyButton_Click);
            // 
            // OptionKeyActLabel
            // 
            this.OptionKeyActLabel.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.OptionKeyActLabel.AutoSize = true;
            this.OptionKeyActLabel.BackColor = System.Drawing.Color.Transparent;
            this.OptionKeyActLabel.LinkColor = System.Drawing.Color.Transparent;
            this.OptionKeyActLabel.Location = new System.Drawing.Point(69, 350);
            this.OptionKeyActLabel.Name = "OptionKeyActLabel";
            this.OptionKeyActLabel.Size = new System.Drawing.Size(221, 13);
            this.OptionKeyActLabel.TabIndex = 9;
            this.OptionKeyActLabel.TabStop = true;
            this.OptionKeyActLabel.Text = "I CHANGED MY MIND I USE MY ACCOUNT";
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
            this.GuestActLabel.TabIndex = 10;
            this.GuestActLabel.TabStop = true;
            this.GuestActLabel.Text = "GUEST MODE";
            this.GuestActLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GuestActLabel_LinkClicked);
            // 
            // ExitLabelFunction
            // 
            this.ExitLabelFunction.AutoSize = true;
            this.ExitLabelFunction.BackColor = System.Drawing.Color.Transparent;
            this.ExitLabelFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabelFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabelFunction.ForeColor = System.Drawing.Color.Red;
            this.ExitLabelFunction.Location = new System.Drawing.Point(325, -6);
            this.ExitLabelFunction.Name = "ExitLabelFunction";
            this.ExitLabelFunction.Size = new System.Drawing.Size(36, 33);
            this.ExitLabelFunction.TabIndex = 11;
            this.ExitLabelFunction.Text = "ⓧ";
            this.ExitLabelFunction.Click += new System.EventHandler(this.ExitLabelFunction_Click);
            // 
            // THOPETACTKEY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tophet.Properties.Resources.screen_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 553);
            this.Controls.Add(this.ExitLabelFunction);
            this.Controls.Add(this.GuestActLabel);
            this.Controls.Add(this.OptionKeyActLabel);
            this.Controls.Add(this.ActivateKeyButton);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.IntroKeyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "THOPETACTKEY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THOPET*ACTIVATIONKEY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntroKeyLabel;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Button ActivateKeyButton;
        private System.Windows.Forms.LinkLabel OptionKeyActLabel;
        private System.Windows.Forms.LinkLabel GuestActLabel;
        private System.Windows.Forms.Label ExitLabelFunction;
    }
}