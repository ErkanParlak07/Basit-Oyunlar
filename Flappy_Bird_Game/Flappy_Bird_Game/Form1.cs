using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox_Bird.Top += gravity;
            pictureBox_Bottom.Left -= pipeSpeed;
            picturebox_top.Left -= pipeSpeed;
            label2.Text = "SCORE: " + score;

            if (pictureBox_Bottom.Left < -150)
            {
                pictureBox_Bottom.Left = 800;
                score++;
            }
            if (picturebox_top.Left < -180)
            {
                picturebox_top.Left = 950;
                score++;
            }
            if (pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Bottom.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(picturebox_top.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Ground.Bounds) || pictureBox_Bird.Top < -25)
            {
                EndGame();
            }

        }
        public void EndGame()
        {
            timer1.Stop();
            label2.Text = "Game Over!";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -20;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void pictureBox_Bottom_Click(object sender, EventArgs e)
        {

        }
    }
}
