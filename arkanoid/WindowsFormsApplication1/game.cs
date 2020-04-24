using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class game : Form
    {

        int v = 10;
        int v1 = 10;
        int score =0;
        public game()
        {
            InitializeComponent();
        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            pictureBox1.Top += v;
            pictureBox1.Left += v1;
            //проверка на столкновение двух объектов
            //Height-высота
            //Width-ширина
            if (pictureBox1.Top < button1.Top + button1.Height)
                if (pictureBox1.Top + pictureBox1.Height > button1.Top)
                    if (pictureBox1.Left + pictureBox1.Width > button1.Left)
                        if (pictureBox1.Left < button1.Left + button1.Width)
                        {
                            v = -v;
                        }
            if (pictureBox1.Top < pictureBox3.Top + pictureBox3.Height)
                if (pictureBox1.Top + pictureBox1.Height > pictureBox3.Top)
                    if (pictureBox1.Left + pictureBox1.Width > pictureBox3.Left)
                        if (pictureBox1.Left < pictureBox3.Left + pictureBox3.Width)
                        {

                            v =-v;
                        }
            if (pictureBox1.Top < Dno.Top + Dno.Height)
                if (pictureBox1.Top + pictureBox1.Height > Dno.Top)
                    if (pictureBox1.Left + pictureBox1.Width > Dno.Left)
                        if (pictureBox1.Left < Dno.Left + Dno.Width)
                        {
                            timer1.Stop();
                            this.Visible = false;
                            Form lose;
                            lose = new lose();
                            lose.ShowDialog();
                            
                            Close();
                        }
            if (pictureBox1.Left > 936)
            {
               
                v1 =-v1;
            }
            if (pictureBox1.Left < 0)
            {
               
                v1=-v1;
            }
        }

        private void button1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { button1.Left -= 10; }
            if (e.KeyCode == Keys.D) { button1.Left += 10; }
        }

        void func(PictureBox g, PictureBox neg) {  
            if (g.Top < neg.Top + neg.Height)
                if (g.Top + g.Height > neg.Top)
                    if (g.Left + g.Width > neg.Left)
                        if (g.Left < neg.Left + neg.Width)
                        {
                            Controls.Remove(neg);
                            neg.Left = -100;
                            if (v <= 0 && v1 <= 0) { v=-v; v1 =-v1; }
                            if (v >= 0 && v1 >= 0) { v=v; v1 =v1; }
                            if (v >= 0 && v1 <= 0) { v = v; v1 = -v1; }
                            if (v <= 0 && v1 >= 0) { v = -v; v1 = v1; }
                            score++;
                            if (score == 23)
                            {
                                timer1.Stop();
                                this.Visible = false;
                                Form win;
                                win = new win();
                                
                                win.ShowDialog();
                                Close();
                            }
                        }
        }

        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {

            func(pictureBox1 , pictureBox25);
            func(pictureBox1, pictureBox23);
            func(pictureBox1, pictureBox22);
            func(pictureBox1, pictureBox20);
            func(pictureBox1, pictureBox9);
            func(pictureBox1, pictureBox24);
            func(pictureBox1, pictureBox10);
            func(pictureBox1, pictureBox18);
            func(pictureBox1, pictureBox7);
            func(pictureBox1, pictureBox2);
            func(pictureBox1, pictureBox12);
            func(pictureBox1, pictureBox14);
            func(pictureBox1, pictureBox4);
            func(pictureBox1, pictureBox11);
            func(pictureBox1, pictureBox19);
            func(pictureBox1, pictureBox8);
            func(pictureBox1, pictureBox5);
            func(pictureBox1, pictureBox6);
            func(pictureBox1, pictureBox15);
            func(pictureBox1, pictureBox17);
            func(pictureBox1, pictureBox16);
            func(pictureBox1, pictureBox13);
            func(pictureBox1, pictureBox21);
        }
    }
}

