using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uçan_top_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerx=15, yery=15,can=3;

        private void CarpmaOlayi()
        {
            //label1'e çarpma
            if (ball.Top <= label1.Bottom)
            {
                yery = yery * -1;
            }

            //label2'ye çarpma
             else if (ball.Left <= label2.Right)
            {
                yerx = yerx * -1;
            }

            //label3'e çarpma
            else if (ball.Right >= label3.Left)
            {
                yerx = yerx * -1;
            }

            //kontrole çarpma
            else if (ball.Bottom >= kontrol.Top && ball.Left>=kontrol.Left && ball.Right<=kontrol.Right)
            {
                yery = yery * -1;
            }
        }
        private void YanmaOlayi()
        {
            if (ball.Top >= label3.Bottom )
            {
                if (can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandınız! Kalan hakkınız:" + can.ToString());
                    BasaDonme();
                    timer1.Start();

                    
                    
                }
                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun Bitti" );
                }
            }
            label5.Text = can.ToString();
        }
        private void BasaDonme()
        {
            ball.Location=new Point(250, 165);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X + yerx, ball.Location.Y + yery);
            CarpmaOlayi();
            YanmaOlayi();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasaDonme();
            timer1.Enabled = true;
            
        }
    }
}
