using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicTest3
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        //WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        
        public Form1()
        {
            InitializeComponent();

            //player.SoundLocation = "myMusicWav.wav";
            //player.URL = "Kalimba.wav";
            //player.controls.stop();

            player.SoundLocation = "Kalimba.wav";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}