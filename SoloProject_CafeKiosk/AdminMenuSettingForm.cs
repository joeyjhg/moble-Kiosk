using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoloProject_CafeKiosk
{
    public partial class AdminMenuSettingForm : Form
    {
        public Menu adminmenu;
        public Menu newmenu = null;

        int i = 0;
        int controlHeight = 50;
        int spacing = 10;
        public AdminMenuSettingForm()
        {
            InitializeComponent();
            btn_Add.Visible = true;
            btn_exit.Visible = false;
            newmenu = new Menu();
            addbutton();
        }

        public AdminMenuSettingForm(Menu menu)
        {
            InitializeComponent();
            adminmenu = menu;
            lb_MenuName.Text = menu.Name;
            lb_Price.Text = menu.Price.ToString();

            if (menu.HOT)
                rb_HOT.Checked = true;
            else
                rb_ICED.Checked = true;
            if (adminmenu.Addons != null)
            {
                foreach (Addon addon in adminmenu.Addons)
                {
                    System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
                    tb.Location = new System.Drawing.Point(0, i * controlHeight);
                    tb.Size = new System.Drawing.Size(120, 20);
                    tb.Text = addon.Name;
                    tb.Name = "tb" + i;
                    tb.BackColor = Color.Aqua;

                    System.Windows.Forms.TextBox tb2 = new System.Windows.Forms.TextBox();
                    tb2.Text = addon.Price.ToString();
                    tb2.Location = new System.Drawing.Point(130, i * controlHeight);
                    tb2.Size = new System.Drawing.Size(50, 20);
                    tb2.Name = "tb2" + i;
                    tb2.BackColor = Color.AliceBlue;


                    System.Windows.Forms.Button bt = new System.Windows.Forms.Button();
                    bt.Text = "수정하기";
                    bt.Width = 80;
                    bt.Height = 30;
                    bt.Name = i.ToString();
                    bt.Location = new System.Drawing.Point(200, i * controlHeight);
                    bt.Click += btn_Addon_Click;
                    panel1.Controls.Add(tb);
                    panel1.Controls.Add(tb2);
                    panel1.Controls.Add(bt);
                    i++;
                }
                addbutton();


            }
        }

        public void addbutton()
        {
            System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
            tb.Location = new System.Drawing.Point(0, i * controlHeight);
            tb.Size = new System.Drawing.Size(120, 20);
            tb.Text = "";
            tb.Name = "tb" + i;
            tb.BackColor = Color.Aqua;
            tb.Enabled = true;

            System.Windows.Forms.TextBox tb2 = new System.Windows.Forms.TextBox();
            tb2.Text = "";
            tb2.Location = new System.Drawing.Point(130, i * controlHeight);
            tb2.Size = new System.Drawing.Size(50, 20);
            tb2.Name = "tb2" + i;
            tb2.BackColor = Color.AliceBlue;
            tb2.Enabled = true;

            System.Windows.Forms.Button bt_add = new System.Windows.Forms.Button();
            bt_add.Text = "추가하기";
            bt_add.Width = 80;
            bt_add.Height = 30;
            bt_add.Name = i.ToString();
            bt_add.Location = new System.Drawing.Point(200, i * controlHeight);
            bt_add.Click += btn_Addon_Click;
            panel1.Controls.Add(tb);
            panel1.Controls.Add(tb2);
            panel1.Controls.Add(bt_add);
            i++;
        }

        private void btn_Addon_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            int index = int.Parse(btn.Name);
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)panel1.Controls["tb" + index];
            System.Windows.Forms.TextBox tb2 = (System.Windows.Forms.TextBox)panel1.Controls["tb2" + index];

            if (adminmenu != null)
            {
                try
                {
                    adminmenu.Addons[index].Name = tb.Text;
                    adminmenu.Addons[index].Price = int.Parse(tb2.Text);
                    MessageBox.Show("수정 되었습니다.");
                }
                catch (Exception ex)
                {
                    Addon addon = new Addon();
                    addon.Name = tb.Text;
                    addon.Price = int.Parse(tb2.Text);
                    adminmenu.Addons.Add(addon);
                    MessageBox.Show("수정 되었습니다.");
                    btn.Text = "수정하기";
                    addbutton();
                }
            }
            else
            {
                try
                {
                    newmenu.Addons[index].Name = tb.Text;
                    newmenu.Addons[index].Price = int.Parse(tb2.Text);
                    MessageBox.Show("수정 되었습니다.");
                }
                catch (Exception ex)
                {
                    if (newmenu.Addons == null)
                    {
                        newmenu.Addons = new List<Addon>(); // Addons 리스트가 null인 경우에 새로운 리스트 생성
                    }
                    Addon addon = new Addon();
                    addon.Name = tb.Text;
                    addon.Price = int.Parse(tb2.Text);
                    newmenu.Addons.Add(addon);
                    MessageBox.Show("수정 되었습니다.");
                    btn.Text = "수정하기";
                    addbutton();
                }
            }


        }

        private void btn_MenuName_Click(object sender, EventArgs e)
        {
            if (tb_MenuName.Text.Equals(""))
                return;
            else
            {
                if (adminmenu != null)
                {
                    adminmenu.Name = tb_MenuName.Text;
                    lb_MenuName.Text = adminmenu.Name;
                }
                else
                {
                    newmenu.Name = tb_MenuName.Text;
                    lb_MenuName.Text = newmenu.Name;
                }

            }

        }

        private void btn_Price_Click(object sender, EventArgs e)
        {
            string input = tb_Price.Text;

            if (!int.TryParse(input, out int price))
            {
                MessageBox.Show("숫자 입력");
                return;
            }
            else
            {
                if (adminmenu != null)
                {
                    adminmenu.Price = price;
                    lb_Price.Text = adminmenu.Price.ToString();
                }
                else
                {
                    newmenu.Price = price;
                    lb_Price.Text = newmenu.Price.ToString();
                }

            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void rb_HOT_CheckedChanged(object sender, EventArgs e)
        {
            if (adminmenu != null)
                adminmenu.HOT = true;
            else
                newmenu.HOT = true;
        }

        private void rb_ICED_CheckedChanged(object sender, EventArgs e)
        {
            if (adminmenu != null)
                adminmenu.HOT = false;
            else
                newmenu.HOT = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
