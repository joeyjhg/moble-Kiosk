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

    public partial class MenuSettingsForm : Form
    {
        public Menu selectedMenu;
        public int baseprice;
        public int addprice;
        public int finalprice;
        //public string addon = "";
        Dictionary<string, decimal> previousValues = new Dictionary<string, decimal>();

        public MenuSettingsForm()
        {
            InitializeComponent();

        }

        public MenuSettingsForm(Menu selectmenu)
        {
            InitializeComponent();
            this.selectedMenu = selectmenu;
            baseprice = selectedMenu.Price;
            lb_MenuName.Text = selectedMenu.Name;
            lb_Price.Text = selectedMenu.Price.ToString();
            finalprice = selectedMenu.Price;
            if (selectedMenu.HOT)
                rd_HOT.Checked = true;
            else
                rd_ICED.Checked = true;

            int i = 0;
            int controlHeight = 50;
            int spacing = 10;

            if (selectedMenu.Addons != null)
            {
                foreach (Addon addon in selectedMenu.Addons)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Location = new System.Drawing.Point(0, i * controlHeight);
                    checkBox.Size = new System.Drawing.Size(120, 20);
                    checkBox.Text = addon.Name;
                    checkBox.Name = addon.Price.ToString();
                    checkBox.BackColor = Color.Aqua;
                    checkBox.Click += chButton_Click;
                    Label lb = new Label();
                    lb.Text = addon.Price.ToString();
                    lb.Location = new System.Drawing.Point(130, i * controlHeight);
                    lb.Size = new System.Drawing.Size(50, 20);
                    lb.BackColor = Color.AliceBlue;
                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Location = new System.Drawing.Point(200, i * controlHeight);
                    numericUpDown.Size = new System.Drawing.Size(45, 25);
                    //numericUpDown.Text = addon.Price.ToString();
                    numericUpDown.Minimum = 0;
                    numericUpDown.Maximum = 10;
                    numericUpDown.Value = 0;
                    numericUpDown.Increment = 1;
                    numericUpDown.Name = addon.Name + "@" + addon.Price.ToString();
                    numericUpDown.Click += nuButton_Click;
                    panel1.Controls.Add(checkBox);
                    panel1.Controls.Add(lb);
                    panel1.Controls.Add(numericUpDown);
                    i++;
                }
            }

        }

        private void dUD_volume_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        private void chButton_Click(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;
        }

        private void nuButton_Click(object sender, EventArgs e)
        {
            NumericUpDown clickedNu = (NumericUpDown)sender;
            decimal thisValue = clickedNu.Value;
            string clickedNuName = clickedNu.Name;
            decimal previousValue = GetPreviousValue(clickedNuName);
            SetPreviousValue(clickedNuName, thisValue);
            string[] arr = clickedNu.Name.Split('@');
            if (thisValue > previousValue)
            {
                int thisprice = int.Parse(arr[1]);
                addprice += thisprice;
                lb_Price.Text = ((baseprice + addprice) * numericUpDown1.Value).ToString();
                finalprice = int.Parse(lb_Price.Text);
                
            }
            else if (thisValue < previousValue)
            {
                int thisprice = int.Parse(arr[1]);
                addprice -= thisprice;
                lb_Price.Text = ((baseprice + addprice) * numericUpDown1.Value).ToString();
                finalprice = int.Parse(lb_Price.Text);
            }
        }
        private decimal GetPreviousValue(string controlName)
        {
            if (previousValues.ContainsKey(controlName))
            {
                return previousValues[controlName];
            }
            else
            {
                // 이전 값이 없는 경우, 기본값 반환
                return 0;
            }
        }

        private void SetPreviousValue(string controlName, decimal value)
        {
            if (previousValues.ContainsKey(controlName))
            {
                previousValues[controlName] = value;
            }
            else
            {
                previousValues.Add(controlName, value);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lb_Price.Text = ((baseprice + addprice) * numericUpDown1.Value).ToString();
            finalprice = int.Parse(lb_Price.Text);
            selectedMenu.Count = (int)numericUpDown1.Value;
        }

        private void rd_ICED_CheckedChanged(object sender, EventArgs e)
        {
            selectedMenu.HOT = false;
        }

        private void rd_HOT_CheckedChanged(object sender, EventArgs e)
        {
            selectedMenu.HOT = true;
        }
    }
}
