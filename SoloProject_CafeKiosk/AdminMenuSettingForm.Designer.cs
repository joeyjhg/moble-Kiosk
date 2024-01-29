namespace SoloProject_CafeKiosk
{
    partial class AdminMenuSettingForm
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lb_MenuName = new System.Windows.Forms.Label();
            tb_MenuName = new System.Windows.Forms.TextBox();
            btn_MenuName = new System.Windows.Forms.Button();
            lb_Price = new System.Windows.Forms.Label();
            tb_Price = new System.Windows.Forms.TextBox();
            btn_Price = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rb_ICED = new System.Windows.Forms.RadioButton();
            rb_HOT = new System.Windows.Forms.RadioButton();
            panel1 = new System.Windows.Forms.Panel();
            btn_exit = new System.Windows.Forms.Button();
            btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_MenuName
            // 
            lb_MenuName.AutoSize = true;
            lb_MenuName.Location = new System.Drawing.Point(136, 12);
            lb_MenuName.Name = "lb_MenuName";
            lb_MenuName.Size = new System.Drawing.Size(85, 15);
            lb_MenuName.TabIndex = 1;
            lb_MenuName.Text = "lb_MenuName";
            // 
            // tb_MenuName
            // 
            tb_MenuName.Location = new System.Drawing.Point(227, 12);
            tb_MenuName.Name = "tb_MenuName";
            tb_MenuName.Size = new System.Drawing.Size(84, 23);
            tb_MenuName.TabIndex = 2;
            // 
            // btn_MenuName
            // 
            btn_MenuName.Location = new System.Drawing.Point(337, 12);
            btn_MenuName.Name = "btn_MenuName";
            btn_MenuName.Size = new System.Drawing.Size(75, 23);
            btn_MenuName.TabIndex = 3;
            btn_MenuName.Text = "수정하기";
            btn_MenuName.UseVisualStyleBackColor = true;
            btn_MenuName.Click += btn_MenuName_Click;
            // 
            // lb_Price
            // 
            lb_Price.AutoSize = true;
            lb_Price.Location = new System.Drawing.Point(136, 63);
            lb_Price.Name = "lb_Price";
            lb_Price.Size = new System.Drawing.Size(48, 15);
            lb_Price.TabIndex = 1;
            lb_Price.Text = "lb_Price";
            // 
            // tb_Price
            // 
            tb_Price.Location = new System.Drawing.Point(227, 63);
            tb_Price.Name = "tb_Price";
            tb_Price.Size = new System.Drawing.Size(84, 23);
            tb_Price.TabIndex = 2;
            // 
            // btn_Price
            // 
            btn_Price.Location = new System.Drawing.Point(337, 63);
            btn_Price.Name = "btn_Price";
            btn_Price.Size = new System.Drawing.Size(75, 23);
            btn_Price.TabIndex = 3;
            btn_Price.Text = "수정하기";
            btn_Price.UseVisualStyleBackColor = true;
            btn_Price.Click += btn_Price_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(25, 129);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "수정하기";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_ICED);
            groupBox1.Controls.Add(rb_HOT);
            groupBox1.Location = new System.Drawing.Point(136, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(300, 51);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "기본 온도 설정";
            // 
            // rb_ICED
            // 
            rb_ICED.AutoSize = true;
            rb_ICED.Location = new System.Drawing.Point(150, 22);
            rb_ICED.Name = "rb_ICED";
            rb_ICED.Size = new System.Drawing.Size(51, 19);
            rb_ICED.TabIndex = 0;
            rb_ICED.TabStop = true;
            rb_ICED.Text = "ICED";
            rb_ICED.UseVisualStyleBackColor = true;
            rb_ICED.CheckedChanged += rb_ICED_CheckedChanged;
            // 
            // rb_HOT
            // 
            rb_HOT.AutoSize = true;
            rb_HOT.Location = new System.Drawing.Point(6, 22);
            rb_HOT.Name = "rb_HOT";
            rb_HOT.Size = new System.Drawing.Size(49, 19);
            rb_HOT.TabIndex = 0;
            rb_HOT.TabStop = true;
            rb_HOT.Text = "HOT";
            rb_HOT.UseVisualStyleBackColor = true;
            rb_HOT.CheckedChanged += rb_HOT_CheckedChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Location = new System.Drawing.Point(25, 183);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(403, 183);
            panel1.TabIndex = 5;
            // 
            // btn_exit
            // 
            btn_exit.Location = new System.Drawing.Point(176, 397);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(75, 23);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "돌아가기";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new System.Drawing.Point(286, 397);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(75, 23);
            btn_Add.TabIndex = 7;
            btn_Add.Text = "추가하기";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Visible = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // AdminMenuSettingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(440, 450);
            Controls.Add(btn_Add);
            Controls.Add(btn_exit);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(btn_Price);
            Controls.Add(btn_MenuName);
            Controls.Add(tb_Price);
            Controls.Add(lb_Price);
            Controls.Add(tb_MenuName);
            Controls.Add(lb_MenuName);
            Controls.Add(pictureBox1);
            Name = "AdminMenuSettingForm";
            Text = "AdminMenuSettingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_MenuName;
        private System.Windows.Forms.TextBox tb_MenuName;
        private System.Windows.Forms.Button btn_MenuName;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Button btn_Price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ICED;
        private System.Windows.Forms.RadioButton rb_HOT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Add;
    }
}