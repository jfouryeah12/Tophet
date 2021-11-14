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
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            THOPETSETTINGS ts = new THOPETSETTINGS();
            //Register Mode and Version
            this.Hide();
            ts.Text = wftitle + rtb.pre + " " + rtb.version;
            Thread.Sleep(1000);
            ts.ShowDialog();
            this.Close();
        }
    }
}
