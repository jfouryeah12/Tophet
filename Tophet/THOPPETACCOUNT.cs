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
    public partial class THOPPETACCOUNT : Form
    {
        public THOPPETACCOUNT()
        {
            InitializeComponent();
        }
        RunTimeData rtb = new RunTimeData();
        string wftitle = "THOPET ";
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

        private void SettingsButton_Click(object sender, EventArgs e)//Go to Setting Tab
        {
            THOPETSETTINGS ts = new THOPETSETTINGS();
            //Register Mode and Version
            this.Hide();
            ts.Text = wftitle + rtb.pre + " " + rtb.version;
            Thread.Sleep(1000);
            ts.ShowDialog();
            this.Close();
        }

        private void LobbyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Go to Lobby Tab
        {
            THOPET lobby = new THOPET();
            //Register Mode and Version
            lobby.introLabel = rtb.pre;//Set Premium Label of Intro label
            lobby.Text = wftitle + rtb.pre + " " + rtb.version;
            this.Hide();
            lobby.Text = wftitle + rtb.pre + " " + rtb.version;
            Thread.Sleep(1000);
            lobby.ShowDialog();
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
    }
}
