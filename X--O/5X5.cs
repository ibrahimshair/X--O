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
    public partial class _5X5 : Form
    {
        public _5X5()
        {
            InitializeComponent();
        }

        int b = 1, z = 0, c = 0, l = 0, t = 0, m = 0,v=0;

        String[,] e = new string[5, 5];

        public void XO(Button a, int i, int j)
        {

            if (i == j)
            {
                for (int s = 0; s < 5; s++)
                {

                    if (e[s, s] == "X")
                    {
                        z++;
                    }
                    else if (e[s, s] == "O")
                    {
                        v++;
                    }
                    if (v == 4)
                    {
                        MessageBox.Show("O KAZANDI");
                        _5X5 _5X5 = new _5X5();
                        this.Hide();
                        _5X5.ShowDialog();
                    }
                    else if (z == 4)
                    {
                        MessageBox.Show("X KAZANDI");
                        _5X5 _5X5= new _5X5();
                        this.Hide();
                        _5X5.ShowDialog();
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


            if((button5.Text==button9.Text && button9.Text==button13.Text &&  button13.Text==button17.Text) || (button9.Text == button13.Text && button13.Text == button17.Text && button17.Text == button21.Text))
            {
                MessageBox.Show(a.Text + " KAZANDI");
                _5X5 a5X5 = new _5X5();
                this.Hide();
                a5X5.ShowDialog();
            }

            for (int s = 0; s < 5; s++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (e[s, x] == "X")
                    {
                        c++;
                    }
                    else if (e[s, x] == "O")
                    {
                        l++;
                    }
                    if (l == 4 || c == 4)
                    {
                        MessageBox.Show(a.Text + " KAZANDI");
                        _5X5 _5X5 = new _5X5();
                        this.Hide();
                        _5X5.ShowDialog();
                    }
                }
                l = 0; c = 0;
            }
            for (int s = 0; s < 5; s++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (e[x, s] == "X")
                    {
                        c++;
                    }
                    else if (e[x, s] == "O")
                    {
                        l++;
                    }
                    if (l == 4 || c == 4)
                    {
                        MessageBox.Show(a.Text + " KAZANDI");
                        _5X5 _5X5 = new _5X5();
                        this.Hide();
                        _5X5.ShowDialog();
                    }
                }
                l = 0; c = 0;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            XO(button1, 0, 0);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            XO(button24, 4, 3);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            XO(button23, 4, 2);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            XO(button22, 4, 1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            XO(button21, 4, 0);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            XO(button20, 3, 4);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            XO(button19, 3, 3);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            XO(button18, 3, 2);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            XO(button17, 3, 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            XO(button16, 3, 0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            XO(button15, 2, 4);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            XO(button14, 2, 3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            XO(button13, 2, 2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            XO(button12, 2, 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            XO(button11, 2, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            XO(button10, 1, 4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XO(button9, 1, 3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XO(button8, 1, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XO(button7, 1, 1);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XO(button6, 1, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XO(button5, 0, 4);
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

        private void button25_Click(object sender, EventArgs e)
        {
            XO(button25, 4, 4);
        }
    }
}
