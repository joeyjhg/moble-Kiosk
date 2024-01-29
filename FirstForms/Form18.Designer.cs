namespace FirstForms
{
    partial class Form18
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new System.Windows.Forms.ListView();
            chName = new System.Windows.Forms.ColumnHeader();
            chPhone = new System.Windows.Forms.ColumnHeader();
            chOrg = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tbName = new System.Windows.Forms.TextBox();
            tbPhone = new System.Windows.Forms.TextBox();
            tbOrg = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnChange = new System.Windows.Forms.Button();
            btnInsert = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chName, chPhone, chOrg });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(40, 142);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(450, 247);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            chName.Text = "이름";
            chName.Width = 150;
            // 
            // chPhone
            // 
            chPhone.Text = "휴대폰";
            chPhone.Width = 200;
            // 
            // chOrg
            // 
            chOrg.Text = "소속";
            chOrg.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "이름 :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "휴대폰 :";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "소속 :";
            label3.Click += label1_Click;
            // 
            // tbName
            // 
            tbName.Location = new System.Drawing.Point(114, 26);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(267, 23);
            tbName.TabIndex = 2;
            // 
            // tbPhone
            // 
            tbPhone.Location = new System.Drawing.Point(114, 57);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new System.Drawing.Size(267, 23);
            tbPhone.TabIndex = 2;
            // 
            // tbOrg
            // 
            tbOrg.Location = new System.Drawing.Point(114, 93);
            tbOrg.Name = "tbOrg";
            tbOrg.Size = new System.Drawing.Size(267, 23);
            tbOrg.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(403, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "입력";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(403, 41);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new System.Drawing.Point(403, 70);
            btnChange.Name = "btnChange";
            btnChange.Size = new System.Drawing.Size(75, 23);
            btnChange.TabIndex = 3;
            btnChange.Text = "수정";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(403, 99);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(75, 23);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "삽입";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // Form18
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnInsert);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tbOrg);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form18";
            Text = "Form18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbOrg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chOrg;
    }
}