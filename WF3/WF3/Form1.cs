using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF3
{
    public partial class Form1 : Form
    {
        public int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "НАЖМИ МЕНЯ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (score == 0)
            {
                button1.Text = "Вы нажа-а-а-а-ли меня!!!!";
                score++;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
