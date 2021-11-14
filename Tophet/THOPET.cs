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

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            //Register Mode and Version
            this.Hide();
            ts.Text = wftitle + rtb.pre + " " + rtb.version;
            Thread.Sleep(1000);
            ts.ShowDialog();
            this.Close();

        }
    }
}
