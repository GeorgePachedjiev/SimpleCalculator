using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калкулатор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            textBox4.Visible = true;
            button2.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;

            string Name = textBox1.Text;
            string Familia = textBox2.Text;
           label8.Text = Name + " " +  Familia;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            int X = (a + b);
            label7.Text = X.ToString();
        }
    }
}
