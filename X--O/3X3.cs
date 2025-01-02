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
    public partial class _3X3 : Form
    {
        public _3X3()
        {
            InitializeComponent();
        }

        int b = 1, z = 0, c = 0, l = 0, v = 0, k = 0, n = 2, t = 0, m = 0;

        String[,] e = new string[3, 3];

       

        public void XO(Button a, int i, int j)
        {
            if (i == j)
            {
                for (int s = 0; s < 3; s++)
                {

                    if (e[s, s] == "X")
                    {
                        z++;
                    }
                    else if (e[s, s] == "O")
                    {
                        v++;
                    }
                    if (v == 3)
                    {
                        MessageBox.Show("O KAZANDI");
                        _3X3 _3X3 = new _3X3();
                        this.Hide();
                        _3X3.ShowDialog();
                    }else if(z == 3)
                    {
                        MessageBox.Show("X KAZANDI");
                        _3X3 _3X3 = new _3X3();
                        this.Hide();
                        _3X3.ShowDialog();
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

            if(button3.Text==button5.Text && button5.Text == button7.Text)
            {
                MessageBox.Show(a.Text + " KAZANDI");
                _3X3 _3X3 = new _3X3();
                this.Hide(); _3X3.ShowDialog();
            }

            for (int s = 0; s < 3; s++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (e[s, x] == "X")
                    {
                        c++;
                    }
                    else if (e[s, x] == "O")
                    {
                        l++;
                    }
                    if (l == 3 || c == 3)
                    {
                        MessageBox.Show(a.Text + " KAZANDI");
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.ShowDialog();
                    }
                }
                l = 0; c = 0;
            }
            for (int s = 0; s < 3; s++)
            {
                
                for (int x = 0; x < 3; x++)
                {
                    if (e[x, s] == "X")
                    {
                        c++;
                    }
                    else if (e[x, s] == "O")
                    {
                        l++;
                    }
                    if (l == 3 || c == 3)
                    {
                        MessageBox.Show(a.Text + " KAZANDI");
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.ShowDialog();
                    }
                }
                l = 0; c = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XO(button5, 1, 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XO(button8, 2, 1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide(); form1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XO(button7, 2, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XO(button6, 1, 2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XO(button9, 2, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XO(button4, 1, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XO(button3, 0, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XO(button2, 0, 1);
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            XO(button1, 0, 0);
        }

        

        private void _3X3_Load(object sender, EventArgs e)
        {

        }
    }
}
