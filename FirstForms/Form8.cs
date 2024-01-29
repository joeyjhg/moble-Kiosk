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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.A | Keys.Shift | Keys.Control))
            {
                MessageBox.Show("A + Shift + Ctrl");
            }
        }

        private void Form8_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("KeyPress 문자키");
        }
    }
}
