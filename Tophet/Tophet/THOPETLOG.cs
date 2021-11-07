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
    public partial class THOPETLOG : Form
    {
        RunTimeData rtb = new RunTimeData();
        public THOPETLOG()
        {
            InitializeComponent();

        }

        private void Emailbox_TextChanged(object sender, EventArgs e)
        {
            if (EmailBox.Text == "Username" ) 
            {
                EmailBox.Text ="";
                EmailBox.ForeColor = Color.Black;
            }

        }
        private void EmailBox_Leave(object sender, EventArgs e)
        {
            if (EmailBox.Text == "")
            {
                EmailBox.Text = "Username";
                EmailBox.ForeColor = Color.Silver;
            }

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
                PasswordBox.PasswordChar = '*';
                PasswordBox.ForeColor = Color.Black;
            }

        }
        

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Password";
                PasswordBox.PasswordChar = default;
                PasswordBox.ForeColor = Color.Silver;
            }

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text == rtb.login && PasswordBox.Text == rtb.password) 
            {
                MessageBox.Show("ACCESS GRANTED","TOPHET",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Email or Password are incorrect please try again.","TOPHET", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
            
        }

        private void OptionKeyActLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            THOPETACTKEY tkey = new THOPETACTKEY();
            this.Hide();
            tkey.ShowDialog();
            this.Close();
        }
    }
}
