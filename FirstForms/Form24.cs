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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void Form24_Paint(object sender, PaintEventArgs e)
        {
            //imageList1.Draw(e.Graphics, 0, 0, 0);
            //imageList1.Draw(e.Graphics, 120, 0, 1);
            //imageList1.Draw(e.Graphics, 240, 0, 2);
            //imageList1.Draw(e.Graphics, 360, 0, 3);
            //imageList1.Draw(e.Graphics, 480, 0, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "킹냥이";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "킹킹냥이";

        }
    }
}
