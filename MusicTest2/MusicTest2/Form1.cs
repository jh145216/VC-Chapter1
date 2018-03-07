using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MusicTest2
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer;

        public Form1()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("resouces/Kalimba.wav");
        }

        private void duelStateButton_CheckedChanged(object sender, EventArgs e)
        {

            if (duelStateButton.Checked)
            {
                duelStateButton.Text = "Stop";
                _soundPlayer.Play();
            }
            else
            {
                duelStateButton.Text = "Play";
                _soundPlayer.Stop();
            }
        }
    }
}
