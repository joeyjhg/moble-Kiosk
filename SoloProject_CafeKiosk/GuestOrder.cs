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
    public partial class GuestOrder : Form
    {
        public List<Menu> Menu;
        public int cnt = 0;
        public int finalprice = 0;
        public List<Menu> UpdateMenu = new List<Menu>();
        public GuestOrder()
        {
            InitializeComponent();
        }
        public GuestOrder(List<Menu> menu)
        {
            InitializeComponent();
            this.Menu = menu;
            lb_result.Text = "";
            for (int i = 0; i < menu.Count; i++)
            {
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(150 * (i % 3), 150 * (i / 3));
                btn.Size = new System.Drawing.Size(100, 100);
                btn.Text = menu[i].Name;
                btn.Click += Button_Click;
                panel1.Controls.Add(btn);
            }
        }

        public GuestOrder(List<Menu> menu, string takeout)
        {
            InitializeComponent();
            label2.Text += " -포장";
            this.Menu = menu;
            lb_result.Text = "";
            for (int i = 0; i < menu.Count; i++)
            {
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(150 * (i % 3), 150 * (i / 3));
                btn.Size = new System.Drawing.Size(100, 100);
                btn.Text = menu[i].Name;
                btn.Click += Button_Click;
                panel1.Controls.Add(btn);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string menuName = clickedButton.Text;
            Menu selectedMenu = Menu.FirstOrDefault(m => m.Name == menuName);

            MenuSettingsForm settingsForm = new MenuSettingsForm(selectedMenu);
            DialogResult result = settingsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Menu updatedMenu = settingsForm.selectedMenu;
                UpdateMenu.Add(updatedMenu);
                int price = settingsForm.finalprice;
                finalprice += price;
                int piece = updatedMenu.Count;
                bool ICE = updatedMenu.HOT;
                lb_result.Text = finalprice.ToString();
                Label lb = new Label();
                lb.Text = updatedMenu.Name + "   수량 : " + piece + "개   가격 : " + price;
                lb.Location = new System.Drawing.Point(0, cnt * 30);
                lb.Size = new System.Drawing.Size(300, 20);
                lb.BackColor = Color.AliceBlue;
                panel2.Controls.Add(lb);
                cnt++;
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("cancel");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            if (finalprice == 0)
            {
                MessageBox.Show("상품을 담아주세요.");
                return;
            }
            Payment settingsForm = new Payment(UpdateMenu, finalprice);
            DialogResult result = settingsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Close(); // guestOrder 폼 닫기

                MainMenu mainForm = new MainMenu(Menu); // 메인 폼 인스턴스화
                mainForm.Show(); // 메인 폼 표시
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // guestOrder 폼 닫기

            MainMenu mainForm = new MainMenu(Menu); // 메인 폼 인스턴스화
            mainForm.Show(); // 메인 폼 표시
        }
    }
}
