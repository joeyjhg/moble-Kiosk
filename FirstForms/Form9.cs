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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form9_MouseUp(object sender, MouseEventArgs e) //마우스를 놓았을때 작동(화면밖에서도 작동)
        {
            label1.Text = e.Location.ToString();
        }

        private void Form9_MouseDoubleClick(object sender, MouseEventArgs e) //더블클릭시 작동
        {
            label2.Text = e.Location.ToString();
        }

        private void Form9_MouseDown(object sender, MouseEventArgs e) //마우스를 누른 순간 작동
        {
            label3.Text = e.Location.ToString();
        }       
       
        private void Form9_MouseClick(object sender, MouseEventArgs e) //마우스를 놓았을때 작동(화면안에서 작동)
        {
            label4.Text = e.Location.ToString();
        }            

        private void Form9_MouseMove(object sender, MouseEventArgs e) //Move
        {
            label5.Text = e.Location.ToString();
        }

        
    }
}
