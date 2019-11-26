using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinformPlugins
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GenericNumberClick(int x)
        {
            String xString = "" + x;
            display.Text = display.Text == "0" || display.Text == null ? xString : display.Text + xString;
        }

        private void n1_Click(object sender, EventArgs e)
        {
            GenericNumberClick(1);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            GenericNumberClick(2);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            GenericNumberClick(3);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            GenericNumberClick(4);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            GenericNumberClick(5);
        }

        private void n6_Click(object sender, EventArgs e)
        {
            GenericNumberClick(6);
        }

        private void n7_Click(object sender, EventArgs e)
        {
            GenericNumberClick(7);
        }

        private void n8_Click(object sender, EventArgs e)
        {
            GenericNumberClick(8);
        }

        private void n9_Click(object sender, EventArgs e)
        {
            GenericNumberClick(9);
        }

        private void n0_Click(object sender, EventArgs e)
        {
            GenericNumberClick(0);
        }
    }
}
