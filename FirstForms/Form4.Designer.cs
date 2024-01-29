namespace FirstForms
{
    partial class Form4
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
            Txt_result = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            Txt_num1 = new System.Windows.Forms.TextBox();
            Txt_num2 = new System.Windows.Forms.TextBox();
            bt_plus = new System.Windows.Forms.Button();
            bt_minus = new System.Windows.Forms.Button();
            bt_mul = new System.Windows.Forms.Button();
            bt_div = new System.Windows.Forms.Button();
            bt_reset = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(131, 137);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "결과";
            label1.Click += label1_Click;
            // 
            // Txt_result
            // 
            Txt_result.Enabled = false;
            Txt_result.Location = new System.Drawing.Point(198, 139);
            Txt_result.Name = "Txt_result";
            Txt_result.Size = new System.Drawing.Size(402, 23);
            Txt_result.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(131, 210);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 25);
            label2.TabIndex = 2;
            label2.Text = "값1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(401, 210);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 25);
            label3.TabIndex = 3;
            label3.Text = "값2";
            // 
            // Txt_num1
            // 
            Txt_num1.Location = new System.Drawing.Point(198, 210);
            Txt_num1.Name = "Txt_num1";
            Txt_num1.Size = new System.Drawing.Size(121, 23);
            Txt_num1.TabIndex = 4;
            // 
            // Txt_num2
            // 
            Txt_num2.Location = new System.Drawing.Point(479, 210);
            Txt_num2.Name = "Txt_num2";
            Txt_num2.Size = new System.Drawing.Size(121, 23);
            Txt_num2.TabIndex = 5;
            // 
            // bt_plus
            // 
            bt_plus.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_plus.Location = new System.Drawing.Point(157, 292);
            bt_plus.Name = "bt_plus";
            bt_plus.Size = new System.Drawing.Size(80, 56);
            bt_plus.TabIndex = 6;
            bt_plus.Text = "+";
            bt_plus.UseVisualStyleBackColor = true;
            bt_plus.Click += bt_plus_Click;
            // 
            // bt_minus
            // 
            bt_minus.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_minus.Location = new System.Drawing.Point(295, 292);
            bt_minus.Name = "bt_minus";
            bt_minus.Size = new System.Drawing.Size(80, 56);
            bt_minus.TabIndex = 7;
            bt_minus.Text = "-";
            bt_minus.UseVisualStyleBackColor = true;
            bt_minus.Click += bt_minus_Click;
            // 
            // bt_mul
            // 
            bt_mul.Font = new System.Drawing.Font("맑은 고딕", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_mul.Location = new System.Drawing.Point(424, 292);
            bt_mul.Name = "bt_mul";
            bt_mul.Size = new System.Drawing.Size(80, 56);
            bt_mul.TabIndex = 8;
            bt_mul.Text = "*";
            bt_mul.UseVisualStyleBackColor = true;
            bt_mul.Click += bt_mul_Click;
            // 
            // bt_div
            // 
            bt_div.Font = new System.Drawing.Font("맑은 고딕", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_div.Location = new System.Drawing.Point(544, 292);
            bt_div.Name = "bt_div";
            bt_div.Size = new System.Drawing.Size(80, 56);
            bt_div.TabIndex = 9;
            bt_div.Text = "/";
            bt_div.UseVisualStyleBackColor = true;
            bt_div.Click += bt_div_Click;
            // 
            // bt_reset
            // 
            bt_reset.Location = new System.Drawing.Point(326, 379);
            bt_reset.Name = "bt_reset";
            bt_reset.Size = new System.Drawing.Size(171, 52);
            bt_reset.TabIndex = 10;
            bt_reset.Text = "초기화";
            bt_reset.UseVisualStyleBackColor = true;
            bt_reset.Click += bt_reset_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(157, 379);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(80, 52);
            button1.TabIndex = 11;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(bt_reset);
            Controls.Add(bt_div);
            Controls.Add(bt_mul);
            Controls.Add(bt_minus);
            Controls.Add(bt_plus);
            Controls.Add(Txt_num2);
            Controls.Add(Txt_num1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Txt_result);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_num1;
        private System.Windows.Forms.TextBox Txt_num2;
        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.Button bt_minus;
        private System.Windows.Forms.Button bt_mul;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button button1;
    }
}