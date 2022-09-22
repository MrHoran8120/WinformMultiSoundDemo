using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        MediaPlayer p1 = new MediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1.Open(new System.Uri(@"C:\Users\PC\Downloads\smile1.wav"));

        // note that this piece of code is required because there is no loop
        // setting for MediaPlayer. This code says  when the piece has finished
        // restart from the beginning.
            p1.MediaEnded += (sender1, EventArgs) =>
            {
                p1.Position = TimeSpan.Zero; p1.Play();
            };
            p1.Play  ();
        }

        private void Media_Ended(object sender, EventArgs e)
        {
            p1.Position = TimeSpan.Zero; 
            p1.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MediaPlayer p2 = new MediaPlayer();
            p2.Open(new System.Uri(@"C:\Users\PC\Downloads\incorrectSound.wav"));
            
            p2.Play();
        }
    }
}
