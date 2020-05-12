using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Указанное число миль равно: " + Double.Parse(textBox1.Text) * 1.6093 + "км";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += Form1_FormClosing;
        }
    }
}
