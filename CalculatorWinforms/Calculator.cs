using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinformPlugins
{
    public partial class Calculator : Form
    {
        //// Any changes to the Operation enum also need to be implemented in equals_Click().
        public enum Operation { Undefined, Plus, Minus, Multiply, Divide, Power, NthRoot };
        Operation operation = Operation.Undefined;
        double formerNum;
        char minusSign = '-';

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://www.duncanritchie.co.uk/";
            footerLink.Links.Add(link);
        }

        private void footerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            footerLink.LinkVisited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }

        private void GenericNumberClick(int x)
        {
            String xString = "" + x;
            if (display.Text == "0" || display.Text == null)
            {
                display.Text = xString;
            }
            else if (display.Text == "" + minusSign + "0")
            {
                display.Text = minusSign + xString;
            }
            else
            {
                display.Text += xString;
            }
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
            formerNum = 0;
            operation = Operation.Undefined;
            display.Text = "0";
        }

        private void point_Click(object sender, EventArgs e)
        {
            string point = ".";
            //// Delete any existing decimal point in the display.
            display.Text = display.Text.Replace(point, "");
            //// Add the point to the end of the display.
            display.Text = display.Text == "0" || display.Text == null ? "0" + point : display.Text + point;
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0 && display.Text[0] == minusSign)
            {
                display.Text = display.Text.Substring(1, display.Text.Length-1);
            }
            else
            {
                display.Text = minusSign + display.Text;
            }
            if (display.Text != "" + minusSign) { CorrectDisplay(); }
        }

        private void CorrectDisplay()
        {
            try
            {
                Convert.ToDouble(display.Text);
            } catch
            {
                string oldDisplayText = display.Text;
                //// The below code is experimental.
                string pattern = minusSign+@"?(([1-9]\d*)|0)(\.\d+)?";
                if (Regex.Match(display.Text, pattern).Value == "")
                {
                    display.Text = "0" + display.Text;
                }
                display.Text = Regex.Match(display.Text, pattern).Value;
                errorMessage.Text = String.Format("Your input {0} was parsed as {1}", oldDisplayText, display.Text);
            }
        }

        private void GenericOperatorClick(Operation newOperation)
        {
            try
            {
                if (operation == Operation.Undefined)
                {
                    formerNum = Convert.ToDouble(display.Text);
                }
                else
                {
                    formerNum = GenericCalculateThatMayThrow(formerNum, Convert.ToDouble(display.Text), operation);
                }
                display.Text = "";
                errorMessage.Text = "";
                operation = newOperation;
            }
            catch
            {
                CorrectDisplay();
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.Plus);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" || display.Text == "")
            {
                plusMinus_Click(sender, e);
            }
            else
            {
                GenericOperatorClick(Operation.Minus);
            }
            
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.Multiply);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.Divide);
        }

        private void power_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.Power);
        }

        private void nthRoot_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.NthRoot);
        }

        private double GenericCalculateThatMayThrow(double formerNum, double latterNum, Operation op)
        {
            switch (op)
            {
                case Operation.Undefined:
                    break;
                case Operation.Plus:
                    return formerNum + latterNum;
                case Operation.Minus:
                    return formerNum - latterNum;
                case Operation.Multiply:
                    return formerNum * latterNum;
                case Operation.Divide:
                    if (latterNum == 0)
                    {
                        errorMessage.Text = "Cannot divide by zero.";
                    }
                    else
                    {
                        return formerNum / latterNum;
                    }
                    break;
                case Operation.Power:
                    return Math.Pow(formerNum, latterNum);
                case Operation.NthRoot:
                    if (latterNum == 0)
                    {
                        errorMessage.Text = "Cannot have a zeroth root.";
                    }
                    else if (formerNum > 0)
                    {
                        return Math.Pow(formerNum, 1 / latterNum);
                    }
                    else
                    {
                        return -1 * Math.Pow(-1 * formerNum, 1 / latterNum);
                    }
                    break;
                default:
                    errorMessage.Text = "The operation selected is not allowed.";
                    break;
            }
            throw new Exception();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double latterNum = formerNum;
            double result;
            if (display.Text != "")
            {
                try
                {
                    CorrectDisplay();
                    latterNum = Convert.ToDouble(display.Text);
                }
                catch
                {
                    errorMessage.Text = "Something went really wrong";
                }
            }

            try
            {
                result = GenericCalculateThatMayThrow(formerNum, latterNum, operation);
            }
            catch
            {
                result = latterNum;
            }
            //// Setting 'formerNum = latterNum' means 1+==== yields Fibonacci numbers.
            //// (because 1+(0)=1; (1+1)=2; (2+1)=3; (3+2)=5; (5+3)=8; ...)
            //// Setting 'formerNum = result' means 1+===== yields powers of 2.
            //// (because 1+(0)=1; (1+1)=2; (2+2)=4; (4+4)=8; (8+8)=16; ...)
            formerNum = result;
            display.Text = result.ToString();
        }
    }
}
