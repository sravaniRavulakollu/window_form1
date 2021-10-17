using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label1.Text = "Now you can understand Event Driven Programming in c#";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Indigo;
            label1.Text = " Naresh ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome to GUI Demo";
            label1.ForeColor = Color.Red;
        }
    }
}
