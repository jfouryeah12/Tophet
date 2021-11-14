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
    public partial class THOPETSETTINGS : Form
    {
        public THOPETSETTINGS()
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

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void ListLabel_Click(object sender, EventArgs e)
        {

        }

        private void AccountButton_Click(object sender, EventArgs e)//Go to Account Tab
        {
            THOPPETACCOUNT ta = new THOPPETACCOUNT();
            //Register Mode and Version
            this.Hide();
            ta.Text = wftitle + rtb.pre + " " + rtb.version;
            Thread.Sleep(1000);
            ta.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
