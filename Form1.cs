using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        int speed = 5;
        int movex;
        int movey;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movey = -speed;
            movex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movey = speed;
            movex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movex = -speed;
            movey = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movex = speed;
            movey = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += movex;
            pictureBox1.Top += movey;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                movey = -speed;
            }
            if (e.KeyCode == Keys.Down)
            {
                movey = +speed;
            }
            if (e.KeyCode == Keys.Left)
            {
                movex = -speed;
            }
            if (e.KeyCode == Keys.Right)
            {
                movex = +speed;
            }
            if (e.KeyCode == Keys.Space)
            {
                pictureBox2.Left = pictureBox1.Left;
                pictureBox2.Top = pictureBox1.Top;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                movey = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                movey = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                movex = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                movex = 0;
            }
        }
    }
}
