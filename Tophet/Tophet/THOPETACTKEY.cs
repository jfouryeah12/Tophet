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
    public partial class THOPETACTKEY : Form
    {
        RunTimeData rtd = new RunTimeData();
        public THOPETACTKEY()
        {
            InitializeComponent();
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyBox.Text == "XXX-XXX-XXX-XXX-XXX")
            {
                KeyBox.Text = "";
                KeyBox.ForeColor = Color.Black;
            }
        }

        private void KeyBox_Leave(object sender, EventArgs e)
        {
            if (KeyBox.Text == "")
            {
                KeyBox.Text = "XXX-XXX-XXX-XXX-XXX";
                KeyBox.ForeColor = Color.Silver;
            }

        }

        private void OptionKeyActLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            THOPETLOG tkey = new THOPETLOG();
            this.Hide();
            tkey.ShowDialog();
            this.Close();
        }

        private void ActivateKeyButton_Click(object sender, EventArgs e)
        {
            if (KeyBox.Text == rtd.RegistrationKey) 
            {
                MessageBox.Show("ACCESS GRANTED","TOPHET",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Incorrect Key!\nContact Support: tophet@gmail.com\n For more info.","TOPHET", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
            
        }
    }
}
