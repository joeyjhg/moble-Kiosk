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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        List<DomainUpDown> domainUpDownList = new List<DomainUpDown>();
        List<NumericUpDown> NumericUpDownList = new List<NumericUpDown>();

        int y = 30;
        int cnt = 0;

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cnt < domainUpDown1.Items.Count - 1)
            {
                DomainUpDown domainUpDown = new DomainUpDown();
                NumericUpDown numericUpDown = new NumericUpDown();
                domainUpDown.Text = "";
                for (int i = 0; i < domainUpDown1.Items.Count; i++)
                {
                    domainUpDown.Items.Add(domainUpDown1.Items[i]);
                }

                domainUpDown.Location = new System.Drawing.Point(252, 36 + y);
                numericUpDown.Location = new System.Drawing.Point(470, 36 + y);

                y += 30;

                domainUpDownList.Add(domainUpDown);
                NumericUpDownList.Add(numericUpDown);
                cnt++;

                for (int i = 0; i < domainUpDownList.Count; i++) //리스트에 있는 것들을 리스트갯수만큼 출력함.
                {                                                //이때 삭제 버튼에서 리스트 삭제연산을 하지 않으면 한번에 여러개 출력
                    Controls.Add(domainUpDownList[i]);
                    Controls.Add(NumericUpDownList[i]);
                }
            }
            else
                MessageBox.Show("최대 갯수 초과");
            
        }

        private void btDelete_Click(object sender, EventArgs e) //여기서 리스트 삭제연산을 추가해야함
        {
            if (cnt > 0)
            {
                Controls.Remove(domainUpDownList[cnt - 1]);
                Controls.Remove(NumericUpDownList[cnt - 1]);                
                y -= 30;
                domainUpDownList.RemoveAt(cnt - 1); //RemoveAt(index) index에 있는 값 삭제. 리스트에서 제일 최근에 넣은 값 삭제
                NumericUpDownList.RemoveAt(cnt - 1);
                cnt--;
            }
            else
                MessageBox.Show("최소 갯수 미달");

        }
    }
}
