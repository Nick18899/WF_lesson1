using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF4
{
    public partial class Window1 : Form
    {
        System.Random rand = new Random();
        private double score = 0;
        private int numb=0;
        public Window1()
        {
            InitializeComponent();
        }
        private void Window1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = rand.Next(1, 11);
            int y = int.Parse(textBox1.Text);
            if (numb >= 10)
            {
                DialogResult result3 = MessageBox.Show(
                   "Коэффицент везучести: " + Math.Round(score / numb, 2),
                   "Messege",
                    MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly
                   );
                score = 0;
                numb = 0;
            }
            else
            {
                if (a == int.Parse(textBox1.Text))
                {
                    DialogResult result1 = MessageBox.Show(
                        "Вы угадали!",
                        "Messege",
                         MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                        );
                    numb++;
                    score++;

                }
                else
                {
                    DialogResult result2 = MessageBox.Show(
                        "Вы не угадали!",
                        "Messege",
                         MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                        );
                    numb++;

                }
            }
        }
    }
}
