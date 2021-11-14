
namespace Tophet
{
    partial class THOPET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THOPET));
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.OutputDetails = new System.Windows.Forms.Label();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OutputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.BackColor = System.Drawing.Color.White;
            this.HistoryPanel.Location = new System.Drawing.Point(13, 202);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(280, 267);
            this.HistoryPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(308, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 267);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(603, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 267);
            this.panel2.TabIndex = 1;
            // 
            // OutputPanel
            // 
            this.OutputPanel.AutoScroll = true;
            this.OutputPanel.BackColor = System.Drawing.Color.Transparent;
            this.OutputPanel.Controls.Add(this.pictureBox1);
            this.OutputPanel.Controls.Add(this.OutputDetails);
            this.OutputPanel.Location = new System.Drawing.Point(215, 55);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(533, 128);
            this.OutputPanel.TabIndex = 2;
            // 
            // OutputDetails
            // 
            this.OutputDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDetails.AutoEllipsis = true;
            this.OutputDetails.Font = new System.Drawing.Font("Alef", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputDetails.ForeColor = System.Drawing.Color.Cyan;
            this.OutputDetails.Location = new System.Drawing.Point(124, 50);
            this.OutputDetails.Name = "OutputDetails";
            this.OutputDetails.Size = new System.Drawing.Size(406, 32);
            this.OutputDetails.TabIndex = 0;
            this.OutputDetails.Text = "Great job! You\'re fully protected";
            this.OutputDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.IntroLabel.Size = new System.Drawing.Size(160, 30);
            this.IntroLabel.TabIndex = 6;
            this.IntroLabel.Text = "Not Registered";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tophet.Properties.Resources.Protected;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // THOPET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tophet.Properties.Resources.darkmode;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 481);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HistoryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "THOPET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPHET";
            this.OutputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HistoryPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.Label OutputDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}