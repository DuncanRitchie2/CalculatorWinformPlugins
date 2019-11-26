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
    }
}
