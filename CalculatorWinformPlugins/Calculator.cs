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
        [Flags]
        public enum Operation { Plus, Minus, Multiply, Divide };
        Operation operation;
        double formerNum;

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
            errorMessage.Text = "";
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

        private void clear_Click(object sender, EventArgs e)
        {
            //formerNum = 0;
            display.Text = "0";
        }

        private void point_Click(object sender, EventArgs e)
        {
            string xString = ".";
            //// Delete any existing decimal point in the display.
            display.Text = display.Text.Replace(xString, "");
            //// Add the point to the end of the display.
            display.Text = display.Text == "0" || display.Text == null ? "0" + xString : display.Text + xString;
        }

        private void GenericOperatorClick(Operation newOperation)
        {
            formerNum = Convert.ToDouble(display.Text);
            display.Text = "";
            errorMessage.Text = "";
            operation = newOperation;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.Plus);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.Minus);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.Multiply);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.Divide);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double latterNum;
            double result;
            try
            {
                latterNum = Convert.ToDouble(display.Text);
            }
            catch
            {
                latterNum = formerNum;
            }
            // result is overruled by switch block.
            result = latterNum;

            switch (operation)
            {
                case Operation.Plus:
                    result = formerNum + latterNum;
                    break;
                case Operation.Minus:
                    result = formerNum - latterNum;
                    break;
                case Operation.Multiply:
                    result = formerNum * latterNum;
                    break;
                case Operation.Divide:
                    if (latterNum == 0)
                    {
                        errorMessage.Text = "Cannot divide by zero.";
                    }
                    else
                    {
                        result = formerNum / latterNum;
                    }
                    break;
                default:
                    errorMessage.Text = "The operation selected is not allowed.";
                    break;
            }

            display.Text = result.ToString();
        }
    }
}
