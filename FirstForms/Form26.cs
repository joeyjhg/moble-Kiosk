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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }
        int cnt = 0;

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("텍스트를 추가해주세요");
                return;
            }

            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                treeView1.Nodes.Add(textBox1.Text);
                textBox1.Text = "";
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
            else
                MessageBox.Show("삭제할 노드 선택");
        }

        private void btExpandAll_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btCollapseAll_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cnt!=0)
            {
                return;
            }
            TreeNode tv = new TreeNode("C언어");

            TreeNode treeview1 = new TreeNode("조건문");
            treeview1.Nodes.Add("if~else");
            treeview1.Nodes.Add("switch~case");
            treeview1.Nodes.Add("() ? :");

            TreeNode treeView2 = new TreeNode("반복문");
            treeView2.Nodes.Add("for문");
            treeView2.Nodes.Add("while문");
            treeView2.Nodes.Add("do~while문");

            TreeNode treeView3 = new TreeNode("함수");
            treeView3.Nodes.Add("라이브러리 함수");
            treeView3.Nodes.Add("사용자 지정 함수");

            TreeNode treeView4 = new TreeNode("구조체");
            treeView4.Nodes.Add("static 변수");
            treeView4.Nodes.Add("초기화");

            tv.Nodes.Add(treeview1);
            tv.Nodes.Add(treeView2);
            tv.Nodes.Add(treeView3);
            tv.Nodes.Add(treeView4);
            treeView1.Nodes.Add(tv);
            cnt++;

        }
    }
}
