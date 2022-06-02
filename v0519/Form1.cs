using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0519
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Top = Top - 10;
            button1.Top = button1.Top - 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");

            MessageBox.Show(100. ToString());
            MessageBox.Show("" + 100);
            MessageBox.Show($"{100}");

            MessageBox.Show((1 + 1).ToString());
            MessageBox.Show("" + 1+1);
            MessageBox.Show($"{1+1}");

            MessageBox.Show("1" + "1");
            MessageBox.Show(" 1 + 1 ");
            MessageBox.Show("{1 + 1}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Left = Left - 10;
            button2.Left = button2.Left - 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Top = Top + 10;
            button4.Top = button4.Top + 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Left = Left - 10;
            button3.Left = button3.Left + 10;
        }
    }
}
