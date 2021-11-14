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
            
        }
        
        public string introLabel //Intro Label 
        {
            get { return this.IntroLabel.Text; }
            set { this.IntroLabel.Text = value; }
        }
    }
}
