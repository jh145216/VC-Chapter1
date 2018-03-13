using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerstest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int duration = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ////We st the timer1 interval to 5000 that is in milliseconds, i.e. 5 seconds
            ////timer to any time less than 5 seconds we may have a hard time to stop the program normally.
            ////MessageBox.Show("Time is up!!!");
            //duration++;//incerment the timer by 1 second.

            //we will now explore timer1 as a counddowntimer...
            duration--;
            txtTime.Text = duration.ToString();

            //If we did not have the following if-statement, what will happen?
            if (duration == 0 )
             {
               timer1.Stop();
               MessageBox.Show("Time's up!!");
             }


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}