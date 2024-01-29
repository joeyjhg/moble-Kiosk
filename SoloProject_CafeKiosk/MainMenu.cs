using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoloProject_CafeKiosk
{
    public class Menu
    {
        public string Name { get; set; }
        public int Price {  get; set; }
        public bool HOT {  get; set; }
        public int Count {  get; set; }
        public List<Addon> Addons { get; set; }        
    }

    public class Addon
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }

    

    public partial class MainMenu : Form
    {
        public List<Menu> MenuList;
        public MainMenu()
        {
            InitializeComponent();
            if (this.MenuList == null)
            {
                this.MenuList = new List<Menu>();
            }
            setting();
        }

        public MainMenu(List<Menu> menuList)
        {
            InitializeComponent();
            this.MenuList = menuList;
            if (this.MenuList == null)
            {
                this.MenuList = new List<Menu>();
            }
            //setting();
        }

        public void setting()
        {
            string name = "아메리카노";
            int price = 2000;
            string name2 = "카페라떼";
            int price2 = 3000;
            Addon addon = new Addon();
            addon.Name = "샷 추가";
            addon.Price = 500;
            Addon addon2 = new Addon();
            addon2.Name = "휘핑크림 추가";
            addon2.Price = 5000;
            Addon addon3 = new Addon();
            addon3.Name = "시럽 추가";
            addon3.Price = 3000;

            Menu menu = new Menu { Name = name, Price = price, HOT = true, Addons = new List<Addon>() };
            Menu menu1 = new Menu { Name = name2, Price = price2, HOT = true, Addons = null };
            Menu menu2 = new Menu { Name = "마끼아또", Price = 4000, HOT = true, Addons = new List<Addon>() };

            menu.Addons.Add(addon);
            menu.Addons.Add(addon2);
            menu.Addons.Add(addon3);

            menu2.Addons.Add(addon);


            MenuList.Add(menu);
            MenuList.Add(menu1);
            MenuList.Add(menu2);            
        }
        private void bt_ForHere_Click(object sender, EventArgs e)
        {
            GuestOrder guestOrder = new GuestOrder(MenuList);
            try
            {
                guestOrder.Show();  // 새로운 폼을 먼저 열기
                this.Visible = false;      // 현재 폼을 닫기
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void bt_TakeOut_Click(object sender, EventArgs e)
        {
            GuestOrder guestOrder = new GuestOrder(MenuList, "takeout");
            try
            {
                guestOrder.Show();  // 새로운 폼을 먼저 열기
                this.Visible = false;      // 현재 폼을 닫기
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void bt_Admin_Click(object sender, EventArgs e)
        {
            AdminOrder adminOrder = new AdminOrder(MenuList);
            try
            {
                adminOrder.Show();  // 새로운 폼을 먼저 열기
                this.Visible = false;      // 현재 폼을 닫기
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
