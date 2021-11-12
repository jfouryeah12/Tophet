using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tophet
{
    public partial class THOPETACTKEY : Form
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
        //Basic
        string wftitle = "Thopet ";
        //Runner Log
        RunTimeData rtb = new RunTimeData(); // properties
        public THOPET t = new THOPET(); //Lobby
        
        //Start
        public THOPETACTKEY()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void OptionKeyActLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Change to Email Log Method
        {
            THOPETLOG tlog = new THOPETLOG(); // Activation Form  Method
            this.Hide();
            Thread.Sleep(1000);
            tlog.ShowDialog();
            this.Close();
        }

        private void ActivateKeyButton_Click(object sender, EventArgs e) // Check Key
        {
            if (KeyBox.Text == rtb.RegistrationKey) 
            {
                
                //Register Mode and Version
                t.Text = wftitle + rtb.pre + " " + rtb.version;
                rtb.RuleLabel = "Premium";
               

                //Change Form
                this.Hide();
                Thread.Sleep(1000);
                t.ShowDialog();
                this.Close();


            }
            else { MessageBox.Show("Incorrect Key!\nContact Support: tophet@gmail.com\n For more info.","TOPHET", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
            
        }

        private void ExitLabelFunction_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);//Terminate Program
        }

        private void GuestActLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
            this.Hide();
            Thread.Sleep(1000);
            t.Text = "THOPET Guest Mode" + " " + rtb.version;
            t.ShowDialog();
            this.Close();
        }
    }
}
