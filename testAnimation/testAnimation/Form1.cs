using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAnimation
{
    public partial class Form1 : Form
    {
        int gravity = 15;
        bool shot = false;
        bool goup = false;
        int score = 0;
        int speed = 10  ;
        Random rand = new Random();
        int playerSpeed = 10;
        int index;
        int spbl;

        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            pcVatcan1.Left -= speed;
            UFO.Left -= speed;
            txtScore.Text = "Score: " + score;
            if(pcNhanvat.Top <=280)
            {
                pcNhanvat.Top += gravity;
            }
            if (goup == true && pcNhanvat.Top >50)
            {
                pcNhanvat.Top += gravity;
                //pcNhanvat.Left += 15;
                //goup = false;
            }    
            if (pcVatcan1.Left < 50) 
            { 
                chaneVatcan();
                pcVatcan1.Left = rand.Next(800, 1200) - pcVatcan1.Width;
                //pcVatcan1.Top = rand.Next(200, 250) - pcVatcan1.Height;
            }
            if (UFO.Left < -150)
            {
                UFO.Left = rand.Next(800, 1200) - UFO.Width;
                UFO.Top = rand.Next(100, 350) - UFO.Height;
                chaneUFO();
            }
            if (    pcNhanvat.Bounds.IntersectsWith(UFO.Bounds) ||
                    pcNhanvat.Bounds.IntersectsWith(pcVatcan1.Bounds)){
                Timer.Stop();
                txtScore.Text = "your score " + score;
                MessageBox.Show("Your lose " + score + " UFO");
            }
            if ((score % 10 == 0)&&(score > 5))
            {
                speed ++;
                spbl = speed;
            }  
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "bullet")
                {
                    X.Left += (spbl+100);
                    if (X.Left > 900)
                    {
                        this.Controls.Remove(X);
                        X.Dispose();

                    }
                    if (X.Bounds.IntersectsWith(UFO.Bounds))
                    {
                        score ++;
                        this.Controls.Remove(X);
                        X.Dispose();
                        UFO.Left = rand.Next(800, 1200) - pcVatcan1.Width;
                        UFO.Top = rand.Next(100, 350)-UFO.Height; 
                        chaneUFO();
                    }
                }
            }
        }
        private void chaneUFO()
        {
            index += 1;
            if (index > 3)
            {
                index = 1;
            }
            switch (index)
            {
                case 1:
                    UFO.Image = Properties.Resources.UFO;
                    break;
                case 2:
                    UFO.Image = Properties.Resources.UFO1;
                    break;
                case 3:
                    UFO.Image = Properties.Resources.UFO2;
                    break;
            }
        }
        private void chaneVatcan()
        {
            index += 1;
            if (index > 3)
            {
                index = 1;
            }
            switch (index)
            {
                case 1:
                    pcVatcan1.Image = Properties.Resources.da1;
                    break;
                case 2:
                    pcVatcan1.Image = Properties.Resources.da2;
                    break;
                case 3:
                    pcVatcan1.Image = Properties.Resources.da3;
                    break;
            }
        }
        private void Form1_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
            {
                gravity = -15;
                goup = true;
            }
            if (e.KeyCode == Keys.Enter  && shot == false)
            {
                makeBullet();
                shot = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
                goup = false;
                
            }
            if(shot == true )
            {
                shot = false;
            }    
        }
        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = System.Drawing.Color.DarkOrange;
            bullet.Height = 5;
            bullet.Width = 10;
            bullet.Left = pcNhanvat.Left + pcNhanvat.Width;
            bullet.Top = pcNhanvat.Top + pcNhanvat.Height;
            bullet.Tag = "bullet";
            this.Controls.Add(bullet);
        }
        private void UFO_Click(object sender, EventArgs e)
        {

        }
        private void pcVatcan1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
