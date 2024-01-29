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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbOrg.Text == "")
                MessageBox.Show("입력하지 않은 곳을 채워주세요.");
            else
            {
                listView1.Items.Add(new ListViewItem(new string[] {tbName.Text,tbPhone.Text,tbOrg.Text}));
                tbName.Clear();
                tbPhone.Clear();
                tbOrg.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listView1.FocusedItem.Index;
                listView1.Items.RemoveAt(index);
            } catch(Exception ex)
            {
                MessageBox.Show("리스트 항목을 다시 살펴보세요.");
            }
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbOrg.Text == "")
            {
                MessageBox.Show("입력하지 않은 곳을 채워주세요.");
                return;
            }
            try
            {
                listView1.SelectedItems[0].SubItems[0].Text = tbName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = tbPhone.Text;
                listView1.SelectedItems[0].SubItems[2].Text = tbOrg.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("리스트 항목을 다시 살펴보세요.");
            }
            finally
            {
                tbName.Clear();
                tbPhone.Clear();
                tbOrg.Clear();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbOrg.Text == "")
            {
                MessageBox.Show("입력하지 않은 곳을 채워주세요.");
                return;
            }               

            try
            {
                int index = listView1.FocusedItem.Index;
                listView1.Items.Insert(index+1, new ListViewItem(new string[] { tbName.Text, tbPhone.Text, tbOrg.Text }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("리스트 항목을 다시 살펴보세요.");
            }
            finally
            {
                tbName.Clear();
                tbPhone.Clear();
                tbOrg.Clear();
            }
        }
    }
}
