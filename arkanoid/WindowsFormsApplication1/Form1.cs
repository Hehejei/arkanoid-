using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button2_Click(object sender, EventArgs e) // Открытие окна Авторы
        {
            Form autors;
            autors = new autors();

            this.Visible = false;  // Закрытие данного окна
            autors.ShowDialog();  // Открытие окна авторы

            Close();            // Закрытие и выход из программы
        }

        private void button1_Click_1(object sender, EventArgs e)  // Открытие Игры
        {
           
            Form game;
            game = new game();

            this.Visible = false;  // Закрытие данного окна
            game.ShowDialog();    // Открытие окна Игра

            Close();            // Закрытие и выход программы

        }

        private void button3_Click(object sender, EventArgs e)   // Открытие окна Помощь
        {
            Form help;
            help = new help();

            this.Visible = false;  // Закрытие данного окна
            help.ShowDialog();    // Открытие окна Помощь

            Close();            // Закрытие и выход программы
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form alcanoid;
            alcanoid = new alcanoid();
            this.Visible = false;
            alcanoid.ShowDialog();
            Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Hard;
            Hard = new Hard();
            this.Visible = false;
            Hard.ShowDialog();
            Close();
        }


    }
}
