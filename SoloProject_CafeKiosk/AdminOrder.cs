using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoloProject_CafeKiosk
{
    public partial class AdminOrder : Form
    {
        public List<Menu> Menu;
        int i = 0;
        public AdminOrder()
        {
            InitializeComponent();
        }
        public AdminOrder(List<Menu> menu)
        {
            InitializeComponent();
            this.Menu = menu;
            for (; i <= menu.Count; i++)
            {
                if (i == menu.Count)
                {
                    Button btn2 = new Button();
                    btn2.Location = new System.Drawing.Point(150 * (i % 3), 150 * (i / 3));
                    btn2.Size = new System.Drawing.Size(100, 100);
                    btn2.Text = "메뉴 추가하기";
                    btn2.Click += Button_Click;
                    panel1.Controls.Add(btn2);
                    i++;
                    return;
                }
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(150 * (i % 3), 150 * (i / 3));
                btn.Size = new System.Drawing.Size(100, 100);
                btn.Text = menu[i].Name;
                btn.Name = i.ToString();
                btn.Click += Button_Click;
                panel1.Controls.Add(btn);

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string menuName = clickedButton.Text;
            if (menuName.Equals("메뉴 추가하기"))
            {
                AdminMenuSettingForm settingsForm = new AdminMenuSettingForm();
                DialogResult result = settingsForm.ShowDialog();

                if (result == DialogResult.OK)
                {

                }
                else if (result == DialogResult.Cancel)
                {
                    clickedButton.Location = new System.Drawing.Point(150 * (i % 3), 150 * (i / 3));
                    Menu.Add(settingsForm.newmenu);
                    Button btn2 = new Button();
                    btn2.Location = new System.Drawing.Point(150 * ((i-1) % 3), 150 * ((i-1) / 3));
                    btn2.Size = new System.Drawing.Size(100, 100);
                    btn2.Text = settingsForm.newmenu.Name;
                    btn2.Click += Button_Click;
                    panel1.Controls.Add(btn2);
                    i++;
                }
            }
            else
            {
                Menu selectedMenu = Menu.FirstOrDefault(m => m.Name == menuName);

                AdminMenuSettingForm settingsForm = new AdminMenuSettingForm(selectedMenu);
                DialogResult result = settingsForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    selectedMenu = settingsForm.adminmenu;
                    clickedButton.Text = selectedMenu.Name;
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("cancel");
                }
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close(); // guestOrder 폼 닫기

            MainMenu mainForm = new MainMenu(Menu); // 메인 폼 인스턴스화
            mainForm.Show(); // 메인 폼 표시
        }
    }
}
