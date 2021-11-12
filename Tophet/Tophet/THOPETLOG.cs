using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tophet
{
    public partial class THOPETLOG : Form
    {
        //Border
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );


        //Runner Log
        RunTimeData rtb = new RunTimeData(); // properties
        
         THOPET t = new THOPET(); //Lobby
        //Basic
        string wftitle = "Thopet ";
        //Start
        public THOPETLOG()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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
                this.Hide();
                Text = wftitle + rtb.pre + " " + rtb.version;
               // t.IntroLabel.Te
                Thread.Sleep(1000);
                t.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("Email or Password are incorrect please try again.","TOPHET", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
            
        }

        private void OptionKeyActLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            THOPETACTKEY tkey = new THOPETACTKEY(); // Activation Form Key Method
        
            this.Hide();
            Thread.Sleep(1000);
            tkey.ShowDialog();
            this.Close();
        }

        private void ExitLabelFunction_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1); //Terminate Program
        }

        private void GuestActLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            Thread.Sleep(1000);
            t.Text = "THOPET Guest Mode"+" "+rtb.version;
            t.ShowDialog();
            this.Close();
        }
    }
}
