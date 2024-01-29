using System;
using System.Diagnostics;
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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lbResult.Text = "새 파일을 만듭니다.";
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            lbResult.Text = "파일을 엽니다.";
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            lbResult.Text = "파일을 저장합니다.";
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void toolStripMenuItemPi_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            lbResult.Text = "복사 되었습니다.";
        }

        private void toolStripPaste_Click(object sender, EventArgs e)
        {
            lbResult.Text = "붙여넣기 되었습니다.";
        }

        private void toolStripCut_Click(object sender, EventArgs e)
        {
            lbResult.Text = "잘라내기 되었습니다.";
        }
    }
}
