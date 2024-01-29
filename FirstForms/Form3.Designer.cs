namespace FirstForms
{
    partial class Form3
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
            label2 = new System.Windows.Forms.Label();
            lb_short = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lb_int = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lb_double = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            Lb_Exception = new System.Windows.Forms.Label();
            txt_Number = new System.Windows.Forms.TextBox();
            Btn_short = new System.Windows.Forms.Button();
            Btn_int = new System.Windows.Forms.Button();
            Btn_double = new System.Windows.Forms.Button();
            Btn_All = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(190, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(373, 45);
            label1.TabIndex = 0;
            label1.Text = "WinForm_DataType Test";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(64, 133);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 21);
            label2.TabIndex = 1;
            label2.Text = "short";
            label2.Click += label2_Click;
            // 
            // lb_short
            // 
            lb_short.AutoSize = true;
            lb_short.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_short.Location = new System.Drawing.Point(169, 130);
            lb_short.Name = "lb_short";
            lb_short.Size = new System.Drawing.Size(20, 25);
            lb_short.TabIndex = 2;
            lb_short.Text = "-";
            lb_short.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(64, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 21);
            label4.TabIndex = 1;
            label4.Text = "int";
            // 
            // lb_int
            // 
            lb_int.AutoSize = true;
            lb_int.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_int.Location = new System.Drawing.Point(169, 176);
            lb_int.Name = "lb_int";
            lb_int.Size = new System.Drawing.Size(20, 25);
            lb_int.TabIndex = 2;
            lb_int.Text = "-";
            lb_int.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(64, 225);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 21);
            label6.TabIndex = 1;
            label6.Text = "double";
            // 
            // lb_double
            // 
            lb_double.AutoSize = true;
            lb_double.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_double.Location = new System.Drawing.Point(169, 222);
            lb_double.Name = "lb_double";
            lb_double.Size = new System.Drawing.Size(20, 25);
            lb_double.TabIndex = 2;
            lb_double.Text = "-";
            lb_double.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(64, 273);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(81, 21);
            label8.TabIndex = 1;
            label8.Text = "Exception";
            // 
            // Lb_Exception
            // 
            Lb_Exception.AutoSize = true;
            Lb_Exception.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lb_Exception.Location = new System.Drawing.Point(169, 270);
            Lb_Exception.Name = "Lb_Exception";
            Lb_Exception.Size = new System.Drawing.Size(20, 25);
            Lb_Exception.TabIndex = 2;
            Lb_Exception.Text = "-";
            Lb_Exception.Click += label3_Click;
            // 
            // txt_Number
            // 
            txt_Number.Location = new System.Drawing.Point(85, 382);
            txt_Number.Name = "txt_Number";
            txt_Number.Size = new System.Drawing.Size(538, 23);
            txt_Number.TabIndex = 3;
            // 
            // Btn_short
            // 
            Btn_short.Location = new System.Drawing.Point(629, 132);
            Btn_short.Name = "Btn_short";
            Btn_short.Size = new System.Drawing.Size(84, 23);
            Btn_short.TabIndex = 4;
            Btn_short.Text = "short 변환";
            Btn_short.UseVisualStyleBackColor = true;
            Btn_short.Click += Btn_short_Click;
            // 
            // Btn_int
            // 
            Btn_int.Location = new System.Drawing.Point(629, 177);
            Btn_int.Name = "Btn_int";
            Btn_int.Size = new System.Drawing.Size(84, 24);
            Btn_int.TabIndex = 5;
            Btn_int.Text = "int 변환";
            Btn_int.UseVisualStyleBackColor = true;
            Btn_int.Click += Btn_int_Click;
            // 
            // Btn_double
            // 
            Btn_double.Location = new System.Drawing.Point(629, 226);
            Btn_double.Name = "Btn_double";
            Btn_double.Size = new System.Drawing.Size(84, 36);
            Btn_double.TabIndex = 6;
            Btn_double.Text = "double 변환";
            Btn_double.UseVisualStyleBackColor = true;
            Btn_double.Click += Btn_double_Click;
            // 
            // Btn_All
            // 
            Btn_All.Location = new System.Drawing.Point(629, 382);
            Btn_All.Name = "Btn_All";
            Btn_All.Size = new System.Drawing.Size(83, 23);
            Btn_All.TabIndex = 7;
            Btn_All.Text = "전체변환";
            Btn_All.UseVisualStyleBackColor = true;
            Btn_All.Click += Btn_All_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Btn_All);
            Controls.Add(Btn_double);
            Controls.Add(Btn_int);
            Controls.Add(Btn_short);
            Controls.Add(txt_Number);
            Controls.Add(Lb_Exception);
            Controls.Add(lb_double);
            Controls.Add(lb_int);
            Controls.Add(lb_short);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_short;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_int;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_double;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lb_Exception;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Button Btn_short;
        private System.Windows.Forms.Button Btn_int;
        private System.Windows.Forms.Button Btn_double;
        private System.Windows.Forms.Button Btn_All;
    }
}