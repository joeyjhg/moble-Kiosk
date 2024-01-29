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
    public partial class Payment : Form
    {
        int price;
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(List<Menu> updateMenu, int finalPrice)
        {
            InitializeComponent();
            label1.Text += finalPrice.ToString();
            price = finalPrice;
            radioButton1.Checked = true;

            for (int i = 0; i < updateMenu.Count; i++)
            {
                int price = updateMenu[i].Price;
                int count = updateMenu[i].Count;
                bool ICE = updateMenu[i].HOT;
                Label lb = new Label();
                lb.Text = updateMenu[i].Name + "   수량 : " + count + "개   가격 : " + price;
                lb.Location = new System.Drawing.Point(0, i * 30);
                lb.Size = new System.Drawing.Size(300, 20);
                lb.BackColor = Color.AliceBlue;
                panel1.Controls.Add(lb);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("신용카드로 " + price + "원 결제하셨습니다.\n메뉴로 돌아갑니다.");
            }
            else
                MessageBox.Show("포인트카드로 " + price + "원 결제하셨습니다.\n메뉴로 돌아갑니다.");
            DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
