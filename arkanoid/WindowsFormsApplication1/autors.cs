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
    public partial class autors : Form
    {
        public autors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Возвращение в главное меню
        {
            Form form1;
            form1 = new Form1();

            this.Visible = false;   // Закрытие данного окна
            form1.ShowDialog();    // Открытие окна главного меню

            Close();             // Выход и закрытие программы
        }

  

    }
}
