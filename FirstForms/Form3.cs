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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void Btn_short_Click(object sender, EventArgs e)
        {
            try
            {
                short snum = short.Parse(txt_Number.Text);
                lb_short.Text = snum.ToString();
                Lb_Exception.Text = "-";
            }
            catch (Exception ex)
            {
                lb_short.Text = "-";
                lb_int.Text = "-";
                lb_double.Text = "-";
                Lb_Exception.Text = ex.ToString();
            }

        }

        private void Btn_int_Click(object sender, EventArgs e)
        {
            try
            {
                int snum = int.Parse(txt_Number.Text);
                lb_int.Text = snum.ToString();
                Lb_Exception.Text = "-";
            }
            catch (Exception ex)
            {
                lb_short.Text = "-";
                lb_int.Text = "-";
                lb_double.Text = "-";
                Lb_Exception.Text = ex.ToString();
            }
        }

        private void Btn_double_Click(object sender, EventArgs e)
        {
            try
            {
                double snum = double.Parse(txt_Number.Text);
                lb_double.Text = snum.ToString();
                Lb_Exception.Text = "-";
            }
            catch (Exception ex)
            {
                lb_short.Text = "-";
                lb_int.Text = "-";
                lb_double.Text = "-";
                Lb_Exception.Text = ex.ToString();
            }
        }

        private void Btn_All_Click(object sender, EventArgs e)
        {
            short snum2 = 0;
            int inum2 = 0;
            double dnum2 = 0.0;
            Lb_Exception.Text = "-";

            if (short.TryParse(txt_Number.Text, out snum2))
            {
                lb_short.Text = snum2.ToString();
                lb_int.Text = "-";
                lb_double.Text = "-";
            } else if(int.TryParse(txt_Number.Text,out inum2))
            {
                lb_short.Text = "-";
                lb_int.Text = inum2.ToString();
                lb_double.Text = "-";
            } else if (double.TryParse(txt_Number.Text, out dnum2))
            {
                lb_short.Text = "-";
                lb_int.Text = "-";
                lb_double.Text = dnum2.ToString();
            } else
            {
                Lb_Exception.Text = "변환할 수 없습니다 . ";
                lb_short.Text = "-";
                lb_int.Text = "-";
                lb_double.Text = "-";
            }
        }
    }
}
