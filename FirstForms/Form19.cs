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
    public partial class Form19 : Form
    {
        private int sortColumn = 0;
        private String[] listview_Column = { "이름", "휴대폰", "소속" };

        public Form19()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            start_listView();
            add_items();
        }

        private void start_listView()
        {
            int listview_width = listView1.ClientSize.Width;
            int col_width = listview_width / 3;

            listView1.Columns.Add(listview_Column[0], col_width, HorizontalAlignment.Center);
            listView1.Columns.Add(listview_Column[1], col_width, HorizontalAlignment.Center);
            listView1.Columns.Add(listview_Column[2], col_width, HorizontalAlignment.Center);
        }

        private void add_items()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "홍길동", "010-1234-2345", "공주대1" }));
            listView1.Items.Add(new ListViewItem(new string[] { "배트맨", "010-2234-2345", "공주대2" }));
            listView1.Items.Add(new ListViewItem(new string[] { "수퍼맨", "010-3234-2345", "공주대3" }));
            listView1.Items.Add(new ListViewItem(new string[] { "신사임당", "010-4234-2345", "공주대4" }));
        }
    }
}
