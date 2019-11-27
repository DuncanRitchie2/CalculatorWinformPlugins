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
        public enum Operation { Plus, Minus, Multiply, Divide, Power, NthRoot };
        Operation operation;
        double formerNum;

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

        private void CorrectDisplay()
        {
            try
            {
                Convert.ToDouble(display.Text);
            } catch
            {
                string oldDisplayText = display.Text;
                //// The below code is experimental.
                string pattern = @"(([1-9]\d*)|0)(\.\d+)?";
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
                formerNum = Convert.ToDouble(display.Text);
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

        private void power_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.Power);
        }

        private void nthRoot_Click(object sender, EventArgs e)
        {
            GenericOperatorClick(Operation.NthRoot);
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
                case Operation.Power:
                    result = Math.Pow(formerNum, latterNum);
                    break;
                case Operation.NthRoot:
                    if (latterNum == 0)
                    {
                        errorMessage.Text = "Cannot have a zeroth root.";
                    }
                    else
                    {
                        result = Math.Pow(formerNum, 1 / latterNum);
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
