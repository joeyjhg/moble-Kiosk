namespace SoloProject_CafeKiosk
{
    partial class MenuSettingsForm
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
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            lb_Price = new System.Windows.Forms.Label();
            btn_Cancel = new System.Windows.Forms.Button();
            btn_OK = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rd_ICED = new System.Windows.Forms.RadioButton();
            rd_HOT = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(104, 104);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_MenuName
            // 
            lb_MenuName.AutoSize = true;
            lb_MenuName.Location = new System.Drawing.Point(222, 39);
            lb_MenuName.Name = "lb_MenuName";
            lb_MenuName.Size = new System.Drawing.Size(85, 15);
            lb_MenuName.TabIndex = 1;
            lb_MenuName.Text = "lb_MenuName";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(122, 120);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(92, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lb_Price
            // 
            lb_Price.AutoSize = true;
            lb_Price.Location = new System.Drawing.Point(248, 122);
            lb_Price.Name = "lb_Price";
            lb_Price.Size = new System.Drawing.Size(48, 15);
            lb_Price.TabIndex = 3;
            lb_Price.Text = "lb_Price";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new System.Drawing.Point(33, 385);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(110, 53);
            btn_Cancel.TabIndex = 5;
            btn_Cancel.Text = "취소";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_OK
            // 
            btn_OK.Location = new System.Drawing.Point(166, 385);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new System.Drawing.Size(110, 53);
            btn_OK.TabIndex = 5;
            btn_OK.Text = "메뉴 추가";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(66, 122);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 15);
            label1.TabIndex = 6;
            label1.Text = "수량";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            panel1.Location = new System.Drawing.Point(12, 189);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(325, 190);
            panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd_ICED);
            groupBox1.Controls.Add(rd_HOT);
            groupBox1.Location = new System.Drawing.Point(12, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(325, 35);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // rd_ICED
            // 
            rd_ICED.AutoSize = true;
            rd_ICED.Location = new System.Drawing.Point(189, 10);
            rd_ICED.Name = "rd_ICED";
            rd_ICED.Size = new System.Drawing.Size(51, 19);
            rd_ICED.TabIndex = 0;
            rd_ICED.TabStop = true;
            rd_ICED.Text = "ICED";
            rd_ICED.UseVisualStyleBackColor = true;
            rd_ICED.CheckedChanged += rd_ICED_CheckedChanged;
            // 
            // rd_HOT
            // 
            rd_HOT.AutoSize = true;
            rd_HOT.Location = new System.Drawing.Point(36, 10);
            rd_HOT.Name = "rd_HOT";
            rd_HOT.Size = new System.Drawing.Size(49, 19);
            rd_HOT.TabIndex = 0;
            rd_HOT.TabStop = true;
            rd_HOT.Text = "HOT";
            rd_HOT.UseVisualStyleBackColor = true;
            rd_HOT.CheckedChanged += rd_HOT_CheckedChanged;
            // 
            // MenuSettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(362, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btn_OK);
            Controls.Add(btn_Cancel);
            Controls.Add(lb_Price);
            Controls.Add(numericUpDown1);
            Controls.Add(lb_MenuName);
            Controls.Add(pictureBox1);
            Name = "MenuSettingsForm";
            Text = "MenuSettingsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_MenuName;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_ICED;
        private System.Windows.Forms.RadioButton rd_HOT;
    }
}