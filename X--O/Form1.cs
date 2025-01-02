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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3X3 _3X3 = new _3X3();
            this.Hide();
            _3X3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _5X5 _5X5 = new _5X5();
            this.Hide();
            _5X5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _7X7 _7X7 = new _7X7();
            this.Hide();
            _7X7.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
