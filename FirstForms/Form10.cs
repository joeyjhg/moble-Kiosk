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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            textBox1.Text = "";
        }
        public int totalPrice = 0;
        public int waterPrice = 0;

        private void btnEvent_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lblOrder.Text = "";

            if (ckbSoon.Checked)
                strOrder += ckbSoon.Text + "\n";
            if (ckbPasta.Checked)
                strOrder += ckbPasta.Text + "\n";
            if (ckbSteak.Checked)
                strOrder += ckbSteak.Text + "\n";
            if (ckbTang.Checked)
                strOrder += ckbTang.Text + "\n";
            if (ckbNudle.Checked)
                strOrder += ckbNudle.Text + "\n";
            if (ckbRice.Checked)
                strOrder += ckbRice.Text + "\n";
            if (rbCoke.Checked)
                strOrder += rbCoke.Text + "\n";
            if (rbSprite.Checked)
                strOrder += rbSprite.Text + "\n";
            if (rbZeroCoke.Checked)
                strOrder += rbZeroCoke.Text + "\n";
            if (ckbSoon.Checked || ckbPasta.Checked || ckbSteak.Checked || ckbTang.Checked || ckbNudle.Checked || ckbRice.Checked)
            {
                lblOrder.Text = strOrder + "메뉴를 요청하였습니다.\n";
                if (waterPrice == 0)
                    lblOrder.Text += "음료수를 추가해주세요.";
            }                
            else
                lblOrder.Text = "메뉴를 선택해 주십시오.";
            if (!(radioAgree.Checked || radioDisagree.Checked || radioAgree1.Checked || radioDisagree1.Checked))
                MessageBox.Show("이벤트 응모여부와 회원가입 동의여부를 선택해주세요.");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioDisagree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked)
                MessageBox.Show("개인정보에 동의 하셨습니다.");
            else
                MessageBox.Show("개인정보에 동의하지 않으셨습니다.");
        }
        private void btnEnter1_Click(object sender, EventArgs e)
        {
            if (radioAgree1.Checked)
                MessageBox.Show("회원가입에 성공했습니다.");
            else
                MessageBox.Show("회원가입을 하지 않았습니다.");
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox11.Text + "\n\n요청사항이 접수되었습니다.");
        }

        private void lbPayInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월 할부");
                lbPayInfo.Items.Add("6개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("K은행");
                lbPayInfo.Items.Add("D은행");
                lbPayInfo.Items.Add("S은행");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("N포인트");
                lbPayInfo.Items.Add("해피포인트");
                lbPayInfo.Items.Add("주유포인트");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cbPay.Text == "" || lbPayInfo.Text == "")
            {
                MessageBox.Show("카드정보와 결제방법 확인");
            }
            else
            {
                MessageBox.Show("결제방법 : " + cbPay.Text + "\n결제정보 : " + lbPayInfo.Text);
            }
        }

        private void TotalPrice(Label label, CheckBox checkBox)
        {
            int price = int.Parse(label.Text);
            if (checkBox.Checked)
                totalPrice += price;
            else
                totalPrice -= price;
        }

        private void ckbPatai_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice(lbNudle, ckbNudle);
        }


        private void ckbSoon_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice(lbSoon, ckbSoon);
        }

        private void ckbPasta_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice(lbPasta, ckbPasta);
        }

        private void ckbSteak_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice(lbSteak, ckbSteak);
        }

        private void ckbTang_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice(lbTang, ckbTang);
        }

        private void ckbRice_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice(lbRice, ckbRice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Price = totalPrice + waterPrice;
            if (totalPrice > 0 && waterPrice > 0) 
                textBox1.Text = string.Format(Price.ToString());
            else if(totalPrice == 0)
            {
                MessageBox.Show("주문한 음식이 없습니다.");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("음료수를 골라주세요.");
                textBox1.Text = "";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            ckbNudle.Checked = false;
            ckbPasta.Checked = false;
            ckbSteak.Checked = false;
            ckbRice.Checked = false;
            ckbTang.Checked = false;
            ckbRice.Checked = false;
            rbCoke.Checked = false;
            rbSprite.Checked = false;
            rbZeroCoke.Checked = false;
            rbX.Checked = false;
            totalPrice = 0;
            lblOrder.Text = "";
        }

        private void radioAgree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbZeroCoke_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZeroCoke.Checked)
                waterPrice += int.Parse(lbZeroCoke.Text);
            else
                waterPrice -= int.Parse(lbZeroCoke.Text);
        }

        private void rbSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSprite.Checked)
                waterPrice += int.Parse(lbSprite.Text);
            else
                waterPrice -= int.Parse(lbSprite.Text);
        }

        private void rbX_CheckedChanged(object sender, EventArgs e)
        {
            if (rbX.Checked)
                waterPrice += int.Parse(lbX.Text);
            else
                waterPrice -= int.Parse(lbX.Text);
        }

        private void rbCoke_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCoke.Checked)
                waterPrice += int.Parse(lbCoke.Text);
            else
                waterPrice -= int.Parse(lbCoke.Text);
        }
    }
}
