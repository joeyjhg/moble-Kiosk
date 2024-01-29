using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FirstForms
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        public string password = "123456";
        int cnt = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (input == password)
            {
                MessageBox.Show("열렸습니다.");
                this.Close();
            }
            else
            {
                //cnt++;
                //if (cnt <= 5)
                //{
                //    MessageBox.Show("다시입력하세요");
                //    textBox1.Text = "";
                //}
                //else
                //{
                //    MessageBox.Show("입력을 초과하였습니다.");
                //    this.Close();
                //}
                for (int i = 0; i < cnt; i++)
                {
                    MessageBox.Show("틀렸습니다. 5초후에 자동으로 다시 확인합니다.");
                    Thread.Sleep(5000);
                    if (input == password)
                    {
                        MessageBox.Show("열렸습니다.");
                        this.Close();
                    }
                }
                MessageBox.Show("틀렸습니다. 종료합니다.");

            }
        }
    }
}
