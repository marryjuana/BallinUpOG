//The highest in the room
//2021-04-02 (18 days before 420, the biggest holiday of all time no cap)
//A program to check if you're balling up or not
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balling_up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //button 1 is the master baller upper
        private void button1_Click(object sender, EventArgs e)
        {
            //If my homie is balling up
            if(radYes.Checked == true)
            {
                lblUpBall.Text = "Bro that's sexy of you keep going bro, that's hot, watch a movie, eat, mow your moms ffs just do whatever (except for driving, DUIs are expensive!!!!)";
            }
            //If my homie is not balling up
            else
            {
                lblUpBall.Text = "Istaghfarillah bro smoke some please bro for me bro🥺, i'm the pro baller upper bro pls for me my brodie 🥺";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
