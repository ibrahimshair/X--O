using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X__O
{
    public partial class _7X7 : Form
    {
        public _7X7()
        {
            InitializeComponent();
        }

        int b = 1, z = 0, c = 0, l = 0,v=0;

        String[,] e = new string[7, 7];

        public void XO(Button a, int i, int j)
        {

            if (i == j)
            {
                for (int s = 0; s < 7; s++)
                {

                    if (e[s, s] == "X")
                    {
                        z++;
                    }
                    else if (e[s, s] == "O")
                    {
                        v++;
                    }
                    if (v == 5)
                    {
                        MessageBox.Show("O KAZANDI");
                        _7X7 _7X7 = new _7X7();
                        this.Hide();
                        _7X7.ShowDialog();
                    }
                    else if (z == 5)
                    {
                        MessageBox.Show("X KAZANDI");
                        _7X7 _7X7 = new _7X7();
                        this.Hide();
                        _7X7.ShowDialog();
                    }
                }
            }

            if (e[i, j] == "X" || e[i, j] == "O")
            {
                MessageBox.Show("BURAYA YAZAMAZSINIZ");
            }
            else if (b % 2 == 0)
            {
                b++;
                a.Text = "X";
                e[i, j] = "X";
            }
            else
            {
                b++;
                a.Text = "O";
                e[i, j] = "O";
            }

            if ((button7.Text==button13.Text && button13.Text==button19.Text && button19.Text==button25.Text && button25.Text==button31.Text) || (button13.Text == button19.Text && button19.Text == button25.Text && button25.Text == button31.Text && button31.Text == button37.Text) || (button19.Text == button25.Text && button25.Text == button31.Text && button31.Text == button37.Text && button37.Text == button43.Text))
            {
                MessageBox.Show(a.Text + " KAZANDI");
                _7X7 _7X7 = new _7X7();
                this.Hide();
                _7X7.ShowDialog();
            }
            for (int s = 0; s < 7; s++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (e[s, x] == "X")
                    {
                        c++;
                    }
                    else if (e[s, x] == "O")
                    {
                        l++;
                    }
                    if (l == 5 || c == 5)
                    {
                        MessageBox.Show(a.Text + " KAZANDI");
                        _7X7 _7X7 = new _7X7();
                        this.Hide();
                        _7X7.ShowDialog();
                    }
                }
                l = 0; c = 0;
            }
            for (int s = 0; s < 7; s++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (e[x, s] == "X")
                    {
                        c++;
                    }
                    else if (e[x, s] == "O")
                    {
                        l++;
                    }
                    if (l == 5 || c == 5)
                    {
                        MessageBox.Show(a.Text + " KAZANDI");
                        _7X7 _7X7 = new _7X7();
                        this.Hide();
                        _7X7.ShowDialog();
                    }
                }
                l = 0; c = 0;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            XO(button25, 3, 3);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            XO(button48, 6, 5);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            XO(button47, 6, 4);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            XO(button46, 6, 3);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            XO(button45, 6, 2);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            XO(button44, 6, 1);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            XO(button43, 6, 0);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            XO(button42, 5, 6);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            XO(button41, 5, 5);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            XO(button40, 5, 4);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            XO(button39, 5, 3);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            XO(button38, 5, 2);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            XO(button37, 5, 1);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            XO(button36, 5, 0);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            XO(button35, 4, 6);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            XO(button34, 4, 5);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            XO(button33, 4, 4);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            XO(button32, 4, 3);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            XO(button31, 4, 2);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            XO(button30, 4, 1);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            XO(button29, 4, 0);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            XO(button28, 3, 6);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            XO(button27, 3, 5);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            XO(button26, 3, 4);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            XO(button49, 6, 6);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            XO(button24, 3, 2);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            XO(button23, 3, 1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            XO(button22, 3, 0);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            XO(button21, 2, 6);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            XO(button20, 2, 5);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            XO(button19, 2, 4);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            XO(button18, 2, 3);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            XO(button17, 2, 2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            XO(button16, 2, 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            XO(button15, 2, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            XO(button14, 1, 6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            XO(button13, 1, 5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            XO(button12, 1, 4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            XO(button11, 1, 3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            XO(button10, 1, 2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XO(button9, 1, 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XO(button8, 1, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XO(button7, 0, 6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XO(button6, 0, 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XO(button5, 0, 4);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XO(button4, 0, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XO(button3, 0, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XO(button2, 0, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XO(button1, 0, 0);
        }
    }
}
