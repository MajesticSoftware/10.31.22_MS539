using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._31._22_MS539
{
    public partial class Form1 : Form
    { int num1;
        Image dog, cat, snake;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I think C# is awesome!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show("integer is ok");
            }
            else
            {
                MessageBox.Show("invalid int");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("I love my cat!");
            cat = Image.FromFile("catjeff.jpeg");
            pictureBox1.Image = cat;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("I don't like snakes but here you go!");
            snake = Image.FromFile("snake.jpg");
            pictureBox1.Image = snake;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("I like dogs as well!");
            dog = Image.FromFile("dogjeff.jpeg");
            pictureBox1.Image = dog;
        }
    }
}
