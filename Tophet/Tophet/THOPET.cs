using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tophet
{
    public partial class THOPET : Form
    {
        RunTimeData rtb = new RunTimeData();
        public THOPET()
        {
            InitializeComponent();
            IntroLabel.Text = rtb.RuleLabel;
        }
    }
}
