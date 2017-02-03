using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Currency_convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double f, g;
            f = double.Parse(textBox1.Text);
            g = (f / 129.92);
            textBox2.Text = g.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Easy Currency Converter" + "\nVersion 1.0.0" + "\nDeveloped By tek", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);
            b = (a / 82.07);
            textBox2.Text = b.ToString();






        }

        private void button2_Click(object sender, EventArgs e)
        {
            double c, d;
            c = double.Parse(textBox1.Text);
            d = (c / 108.00);
            textBox2.Text = d.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double h, i;
            h = double.Parse(textBox1.Text);
            i = (h / 21.89);
            textBox2.Text = i.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double j, k;
            j = double.Parse(textBox1.Text);
            k = (j / 1.04);
            textBox2.Text = k.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double l, m;
            l = double.Parse(textBox1.Text);
            m = (l / 89.28);
            textBox2.Text = m.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}