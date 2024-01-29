namespace FirstForms
{
    partial class Form5
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
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lb_result = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lb_result2 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(60, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "1. 숫자 비교";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(187, 75);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "클릭";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(187, 249);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "클릭";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(60, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 21);
            label2.TabIndex = 3;
            label2.Text = "첫 번째 숫자";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(187, 126);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(468, 126);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(120, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(348, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 21);
            label3.TabIndex = 6;
            label3.Text = "두 번째 숫자";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(120, 192);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 21);
            label4.TabIndex = 7;
            label4.Text = "결과";
            // 
            // lb_result
            // 
            lb_result.AutoSize = true;
            lb_result.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_result.Location = new System.Drawing.Point(187, 192);
            lb_result.Name = "lb_result";
            lb_result.Size = new System.Drawing.Size(17, 21);
            lb_result.TabIndex = 8;
            lb_result.Text = "-";
            lb_result.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(60, 248);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 21);
            label5.TabIndex = 9;
            label5.Text = "2. 요일 선택";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(120, 322);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 21);
            label6.TabIndex = 7;
            label6.Text = "결과";
            // 
            // lb_result2
            // 
            lb_result2.AutoSize = true;
            lb_result2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_result2.Location = new System.Drawing.Point(187, 322);
            lb_result2.Name = "lb_result2";
            lb_result2.Size = new System.Drawing.Size(17, 21);
            lb_result2.TabIndex = 8;
            lb_result2.Text = "-";
            lb_result2.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "일", "월", "화", "수", "목", "금", "토" });
            comboBox1.Location = new System.Drawing.Point(60, 282);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(102, 23);
            comboBox1.TabIndex = 10;
            // 
            // Form5
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(lb_result2);
            Controls.Add(lb_result);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_result2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}