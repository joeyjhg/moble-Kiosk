namespace SoloProject_CafeKiosk
{
    partial class GuestOrder
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
            components = new System.ComponentModel.Container();
            lb_result = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btn_payment = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lb_result
            // 
            lb_result.AutoSize = true;
            lb_result.Location = new System.Drawing.Point(375, 373);
            lb_result.Name = "lb_result";
            lb_result.Size = new System.Drawing.Size(39, 15);
            lb_result.TabIndex = 0;
            lb_result.Text = "label1";
            lb_result.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(158, 37);
            label2.TabIndex = 1;
            label2.Text = "Moble Cafe";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new System.Drawing.Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(426, 247);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Location = new System.Drawing.Point(12, 341);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(335, 100);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 323);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "주문 내역";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(375, 341);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "총액";
            // 
            // btn_payment
            // 
            btn_payment.Location = new System.Drawing.Point(363, 415);
            btn_payment.Name = "btn_payment";
            btn_payment.Size = new System.Drawing.Size(75, 23);
            btn_payment.TabIndex = 3;
            btn_payment.Text = "결제하기";
            btn_payment.UseVisualStyleBackColor = true;
            btn_payment.Click += btn_payment_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(402, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(36, 23);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GuestOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 450);
            Controls.Add(button1);
            Controls.Add(btn_payment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(lb_result);
            Name = "GuestOrder";
            Text = "GuestOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button button1;
    }
}