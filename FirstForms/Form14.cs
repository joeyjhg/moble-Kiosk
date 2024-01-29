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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
                timer1.Start();
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            textBox1.Text = "";
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;

            if (progressBar1.Value == 100)
                timer1.Stop();

            textBox1.Text = progressBar1.Value.ToString();

        }
    }
}
