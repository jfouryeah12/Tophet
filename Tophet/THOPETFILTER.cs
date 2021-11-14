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
    public partial class THOPETFILTER : Form
    {
        public THOPETFILTER()
        {
            InitializeComponent();
        }
        RunTimeData rtb = new RunTimeData();
        string wftitle = "THOPET ";
        private void SettingsButton_Click(object sender, EventArgs e)//Go to Settings Tab
        {
            THOPETSETTINGS ts = new THOPETSETTINGS();
            //Register Mode and Version
            this.Hide();
            ts.Text = wftitle + rtb.pre + " " + rtb.version;
            Thread.Sleep(1000);
            ts.ShowDialog();
            this.Close();
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

        private void LobbyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            THOPET lobby = new THOPET();
            //Register Mode and Version
            this.Hide();
            lobby.Text = wftitle + rtb.pre + " " + rtb.version;
            Thread.Sleep(1000);
            lobby.ShowDialog();
            this.Close();

        }
    }
}
