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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Paint(object sender, PaintEventArgs e)
        {
            imageList1.Draw(e.Graphics,0,0,0);
            imageList1.Draw(e.Graphics,120,0,1);
            imageList1.Draw(e.Graphics,240,0,2);
            imageList1.Draw(e.Graphics,360,0,3);
            imageList1.Draw(e.Graphics,480,0,4);
        }
    }
}
