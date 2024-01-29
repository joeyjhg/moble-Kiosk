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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "C공부 화이팅";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "C++공부 화이팅";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "C#공부 화이팅";
        }
    }
}
