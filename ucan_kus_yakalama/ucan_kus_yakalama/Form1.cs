using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucan_kus_yakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int a, b, puan=0, topTıklama=0, isabetliTıklama=0 ,süre=20;

        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = rand.Next(0, 300);
            b = rand.Next(0, 300);
            pictureBox1.Location = new Point(a, b);
            label2.Text = (topTıklama + isabetliTıklama).ToString();


        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            puan += 5;
            isabetliTıklama += 1;
            label6.Text = puan.ToString();
            label3.Text = isabetliTıklama.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            süre--;
            label8.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Oyun Bitti! PUANINIZ:" + puan);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            label3.Text = "0";
            label6.Text = "0";
            pictureBox1.Location = new Point(44, 130);
            süre = 20;
            puan = 0;
            topTıklama = 0;
            isabetliTıklama = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            topTıklama++;
            
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 300;
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
                timer1.Enabled = true;
                timer2.Enabled = true;
                   
        }
    }
}
