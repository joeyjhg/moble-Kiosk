namespace FirstForms
{
    partial class Form9
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
            label11 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label55 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(131, 50);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(106, 15);
            label11.TabIndex = 0;
            label11.Text = "(버튼 놓음) 좌표 : ";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new System.Drawing.Point(131, 98);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(130, 15);
            label31.TabIndex = 0;
            label31.Text = "(버튼 더블클릭) 좌표 : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(281, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(12, 15);
            label1.TabIndex = 0;
            label1.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(281, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(12, 15);
            label2.TabIndex = 0;
            label2.Text = "-";
            label2.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(281, 151);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(12, 15);
            label3.TabIndex = 0;
            label3.Text = "-";
            label3.Click += label4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(281, 191);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(12, 15);
            label4.TabIndex = 0;
            label4.Text = "-";
            label4.Click += label4_Click;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new System.Drawing.Point(131, 151);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(106, 15);
            label55.TabIndex = 0;
            label55.Text = "(버튼 누름) 좌표 : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(131, 191);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(106, 15);
            label7.TabIndex = 0;
            label7.Text = "(버튼 클릭) 좌표 : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(281, 242);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(12, 15);
            label5.TabIndex = 0;
            label5.Text = "-";
            label5.Click += label4_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label55);
            Controls.Add(label31);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label11);
            Name = "Form9";
            Text = "Form9";
            MouseClick += Form9_MouseClick;
            MouseDoubleClick += Form9_MouseDoubleClick;
            MouseDown += Form9_MouseDown;
            MouseMove += Form9_MouseMove;
            MouseUp += Form9_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}