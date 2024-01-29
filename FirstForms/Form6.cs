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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bt_For_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string str = "";

            for (int i = 2; i < 10; i++)
                for (int j = 1; j < 10; j++)
                    str += string.Format("{0} x {1} = {2} \n", i, j, j * j);
            richTextBox1.Text = str;
        }

        private void bt_Foreach_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            string[] arr = { "김00", "이00", "박00", "최00", "병00", "정00", "채00" };
            int i = 0;

            foreach (var value in arr)
            {
                i++;
                sb.AppendLine(string.Format("{0} 학생은 {1}반 입니다.", value, i));
            }
            richTextBox1.Text = sb.ToString();
        }

        private void bt_While_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            int i = 10;

            while (i > 0)
            {
                sb.Append(string.Format("i : {0} \n", i--));
            }
            richTextBox1.Text = sb.ToString();
        }

        private void bt_DoWhile_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            int i = 20;

            do
            {
                sb.Append(string.Format("i : {0} \n", i--));
            } while (i > 0);

            richTextBox1.Text = sb.ToString();
        }
    }
}
