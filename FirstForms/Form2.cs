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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = lb_Test.Text;
            lb_Contain.Text = str.Contains("Test").ToString();

            lb_Equals.Text = str.Equals("Test").ToString();

            lb_Length.Text = str.Length.ToString();

            lb_Replace.Text = str.Replace("Test", "Good").ToString();

            string[] strArr = str.Split('_');
            lb_Split1.Text = strArr[0].ToString();
            lb_Split2.Text = strArr[1].ToString();

            lb_Substring.Text = str.Substring(3,5).ToString();

            lb_ToLower.Text = str.ToLower().ToString();
            lb_ToUpper.Text = str.ToUpper().ToString();

            lb_Trim.Text = str.Trim().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_Contain.Text = "-";
            lb_Equals.Text = "-";
            lb_Length.Text = "-";
            lb_Replace.Text = "-";
            lb_Split1.Text = "-";
            lb_Split2.Text = "-";
            lb_Substring.Text = "-";
            lb_ToLower.Text = "-";
            lb_ToUpper.Text = "-";
            lb_Trim.Text = "-";
        }
    }
}
