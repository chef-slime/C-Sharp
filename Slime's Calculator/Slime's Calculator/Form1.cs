using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slime_s_Calculator
{
    public partial class slimeCalculator : Form
    {
    public slimeCalculator()
    {
        InitializeComponent();
    }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn0.Text;
            }
            else
            {
                lblDisplay.Text += btn0.Text;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn1.Text;
            }
            else
            {
                lblDisplay.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn2.Text;
            }
            else
            {
                lblDisplay.Text += btn2.Text;
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn3.Text;
            }
            else
            {
                lblDisplay.Text += btn3.Text;
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn4.Text;
            }
            else
            {
                lblDisplay.Text += btn4.Text;
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn5.Text;
            }
            else
            {
                lblDisplay.Text += btn5.Text;
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn6.Text;
            }
            else
            {
                lblDisplay.Text += btn6.Text;
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn7.Text;
            }
            else
            {
                lblDisplay.Text += btn7.Text;
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn8.Text;
            }
            else
            {
                lblDisplay.Text += btn8.Text;
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0", StringComparison.OrdinalIgnoreCase))
            {
                lblDisplay.Text = btn9.Text;
            }
            else
            {
                lblDisplay.Text += btn9.Text;
            }
         }
       }
    }