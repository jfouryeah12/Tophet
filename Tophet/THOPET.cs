using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tophet
{
    public partial class THOPET : Form
    {
        //Runner Form and Data
        RunTimeData rtb = new RunTimeData();
        THOPETSETTINGS ts = new THOPETSETTINGS();
        //Basics
        string wftitle = "THOPET ";
        public THOPET()
        {
            InitializeComponent();
            
        }
        
        public string introLabel //Intro Label 
        {
            get { return this.IntroLabel.Text; }
            set { this.IntroLabel.Text = value; }
        }
        public Button settingButton //Setting Button FunctionSecure
        {
            get { return this.SettingsButton; }
            set { this.SettingsButton = (RoundedButton)value; }
        }
        public Button filterButton 
        {
            get { return this.FilterButton; }
            set { this.FilterButton = (RoundedButton)value; }
        }

        private void SettingsButton_Click(object sender, EventArgs e)//Go to Settings Tab
        {
            //Register Mode and Version
            this.Hide();
            ts.Text = wftitle + rtb.pre + " " + rtb.version;
            Thread.Sleep(1000);
            ts.ShowDialog();
            this.Close();

        }

        private void LogoutButton_Click(object sender, EventArgs e)//Go to Login Tab
        {
            THOPETLOG tl = new THOPETLOG();
            //Register Mode and Version
            this.Hide();
            Thread.Sleep(1000);
            tl.ShowDialog();
            this.Close();
        }

        private void FilterButton_Click(object sender, EventArgs e)//Go to Filter Tab
        {
            THOPETFILTER tf = new THOPETFILTER();
            //Register Mode and Version
            this.Hide();
            tf.Text = wftitle + rtb.pre + " " + rtb.version;
            Thread.Sleep(1000);
            tf.ShowDialog();
            this.Close();
        }
    }
}
