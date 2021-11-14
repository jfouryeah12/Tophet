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

        private void AccountButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
