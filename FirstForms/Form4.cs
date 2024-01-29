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
    public partial class Form4 : Form
    {
        private double All_Op(char op)
        {
            double num1 = double.Parse(Txt_num1.Text);
            double num2 = double.Parse(Txt_num2.Text);
            double result = 0;
            switch (op)
            {
                case '+':
                    result = num1+num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0.0)
                        return 0;
                    result = num1 / num2;
                    break;

            }
            return result;

        }
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            Txt_result.Text = Convert.ToString(All_Op('+'));
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            Txt_result.Text = Convert.ToString(All_Op('-'));
        }

        private void bt_mul_Click(object sender, EventArgs e)
        {
            Txt_result.Text = Convert.ToString(All_Op('*'));
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            Txt_result.Text = Convert.ToString(All_Op('/'));

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            Txt_num1.Text = "";
            Txt_num2.Text = "";
            Txt_result.Text = "";
        }
    }
}
