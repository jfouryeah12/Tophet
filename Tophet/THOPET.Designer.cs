
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalitemLabel = new System.Windows.Forms.Label();
            this.ItemsScanLabel = new System.Windows.Forms.Label();
            this.DetectionLabel = new System.Windows.Forms.Label();
            this.HistoryGif = new System.Windows.Forms.PictureBox();
            this.ScanPanel = new System.Windows.Forms.Panel();
            this.ScannerIMAGE = new Tophet.ImageData();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.ProtectionIMAGE = new System.Windows.Forms.PictureBox();
            this.OutputDetails = new System.Windows.Forms.Label();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.ScannerLabel = new System.Windows.Forms.Label();
            this.HistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGif)).BeginInit();
            this.ScanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerIMAGE)).BeginInit();
            this.OutputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProtectionIMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.BackColor = System.Drawing.Color.White;
            this.HistoryPanel.Controls.Add(this.label5);
            this.HistoryPanel.Controls.Add(this.label4);
            this.HistoryPanel.Controls.Add(this.TotalitemLabel);
            this.HistoryPanel.Controls.Add(this.ItemsScanLabel);
            this.HistoryPanel.Controls.Add(this.DetectionLabel);
            this.HistoryPanel.Controls.Add(this.HistoryGif);
            this.HistoryPanel.Location = new System.Drawing.Point(13, 202);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(280, 249);
            this.HistoryPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(240, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(240, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalitemLabel
            // 
            this.TotalitemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalitemLabel.AutoEllipsis = true;
            this.TotalitemLabel.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalitemLabel.ForeColor = System.Drawing.Color.Silver;
            this.TotalitemLabel.Location = new System.Drawing.Point(7, 181);
            this.TotalitemLabel.Name = "TotalitemLabel";
            this.TotalitemLabel.Size = new System.Drawing.Size(212, 24);
            this.TotalitemLabel.TabIndex = 4;
            this.TotalitemLabel.Text = "Total items in quarantine";
            this.TotalitemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsScanLabel
            // 
            this.ItemsScanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsScanLabel.AutoEllipsis = true;
            this.ItemsScanLabel.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsScanLabel.ForeColor = System.Drawing.Color.Silver;
            this.ItemsScanLabel.Location = new System.Drawing.Point(3, 143);
            this.ItemsScanLabel.Name = "ItemsScanLabel";
            this.ItemsScanLabel.Size = new System.Drawing.Size(222, 24);
            this.ItemsScanLabel.TabIndex = 3;
            this.ItemsScanLabel.Text = "Items quarantined last scan";
            this.ItemsScanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetectionLabel
            // 
            this.DetectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DetectionLabel.AutoEllipsis = true;
            this.DetectionLabel.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectionLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DetectionLabel.Location = new System.Drawing.Point(59, 89);
            this.DetectionLabel.Name = "DetectionLabel";
            this.DetectionLabel.Size = new System.Drawing.Size(160, 24);
            this.DetectionLabel.TabIndex = 2;
            this.DetectionLabel.Text = "Detection History";
            this.DetectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryGif
            // 
            this.HistoryGif.BackColor = System.Drawing.Color.Transparent;
            this.HistoryGif.Image = global::Tophet.Properties.Resources.History;
            this.HistoryGif.Location = new System.Drawing.Point(78, 3);
            this.HistoryGif.Name = "HistoryGif";
            this.HistoryGif.Size = new System.Drawing.Size(113, 92);
            this.HistoryGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HistoryGif.TabIndex = 0;
            this.HistoryGif.TabStop = false;
            // 
            // ScanPanel
            // 
            this.ScanPanel.BackColor = System.Drawing.Color.White;
            this.ScanPanel.Controls.Add(this.ScannerLabel);
            this.ScanPanel.Controls.Add(this.ScannerIMAGE);
            this.ScanPanel.Location = new System.Drawing.Point(308, 202);
            this.ScanPanel.Name = "ScanPanel";
            this.ScanPanel.Size = new System.Drawing.Size(280, 249);
            this.ScanPanel.TabIndex = 1;
            // 
            // ScannerIMAGE
            // 
            this.ScannerIMAGE.BackColor = System.Drawing.Color.Transparent;
            this.ScannerIMAGE.Image = global::Tophet.Properties.Resources.scan;
            this.ScannerIMAGE.Location = new System.Drawing.Point(97, 16);
            this.ScannerIMAGE.Name = "ScannerIMAGE";
            this.ScannerIMAGE.Size = new System.Drawing.Size(89, 61);
            this.ScannerIMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScannerIMAGE.TabIndex = 0;
            this.ScannerIMAGE.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(603, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 249);
            this.panel2.TabIndex = 1;
            // 
            // OutputPanel
            // 
            this.OutputPanel.AutoScroll = true;
            this.OutputPanel.BackColor = System.Drawing.Color.Transparent;
            this.OutputPanel.Controls.Add(this.ProtectionIMAGE);
            this.OutputPanel.Controls.Add(this.OutputDetails);
            this.OutputPanel.Location = new System.Drawing.Point(215, 55);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(533, 128);
            this.OutputPanel.TabIndex = 2;
            // 
            // ProtectionIMAGE
            // 
            this.ProtectionIMAGE.Image = global::Tophet.Properties.Resources.Protected;
            this.ProtectionIMAGE.ImageLocation = "";
            this.ProtectionIMAGE.Location = new System.Drawing.Point(3, 3);
            this.ProtectionIMAGE.Name = "ProtectionIMAGE";
            this.ProtectionIMAGE.Size = new System.Drawing.Size(121, 122);
            this.ProtectionIMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProtectionIMAGE.TabIndex = 1;
            this.ProtectionIMAGE.TabStop = false;
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
            // ScannerLabel
            // 
            this.ScannerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ScannerLabel.AutoEllipsis = true;
            this.ScannerLabel.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScannerLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ScannerLabel.Location = new System.Drawing.Point(63, 89);
            this.ScannerLabel.Name = "ScannerLabel";
            this.ScannerLabel.Size = new System.Drawing.Size(160, 24);
            this.ScannerLabel.TabIndex = 7;
            this.ScannerLabel.Text = "Scanner";
            this.ScannerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.ScanPanel);
            this.Controls.Add(this.HistoryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "THOPET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPHET";
            this.HistoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGif)).EndInit();
            this.ScanPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerIMAGE)).EndInit();
            this.OutputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProtectionIMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HistoryPanel;
        private System.Windows.Forms.Panel ScanPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.Label OutputDetails;
        private System.Windows.Forms.PictureBox ProtectionIMAGE;
        private System.Windows.Forms.PictureBox HistoryGif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalitemLabel;
        private System.Windows.Forms.Label ItemsScanLabel;
        private System.Windows.Forms.Label DetectionLabel;
        private ImageData ScannerIMAGE;
        private System.Windows.Forms.Label ScannerLabel;
    }
}