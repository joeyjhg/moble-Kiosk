using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForms
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public string All_Op(string op, double num1, double num2)
        {
            double result = 0.0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0.0)
                        return "0";
                    result = num1 / num2;
                    break;

            }
            return result.ToString();
        }


        private void bt_ShowResult_Click(object sender, EventArgs e)
        {
            string cal = txt_result.Text;
            string[] arr = cal.Split('+', '-', '*', '/');
            cal = cal.Replace(arr[0], "");
            cal = cal.Replace(arr[1], "");
            string op = cal;
            txt_result.Text = All_Op(op, double.Parse(arr[0]), double.Parse(arr[1]));
        }



        private void bt_1_Click(object sender, EventArgs e)
        {
            txt_result.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            txt_result.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            txt_result.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            txt_result.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            txt_result.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            txt_result.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            txt_result.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            txt_result.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            txt_result.Text += "9";
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            txt_result.Text += "0";
        }

        private void bt_Plus_Click(object sender, EventArgs e)
        {
            txt_result.Text += "+";
        }

        private void bt_Minus_Click(object sender, EventArgs e)
        {
            txt_result.Text += "-";
        }

        private void bt_Mul_Click(object sender, EventArgs e)
        {
            txt_result.Text += "*";
        }

        private void bt_Div_Click(object sender, EventArgs e)
        {
            txt_result.Text += "/";
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
        }

        private void bt_BackSpace_Click(object sender, EventArgs e)
        {
            int length = txt_result.Text.Length;
            if (length != 0)
                txt_result.Text = txt_result.Text.Remove(length - 1);
            //txt_result.Text = txt_result.Text.Substring(0, length-1);
        }
    }
}
