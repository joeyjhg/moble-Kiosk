namespace SoloProject_CafeKiosk
{
    partial class AdminOrder
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
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btn_exit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(22, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(331, 37);
            label2.TabIndex = 2;
            label2.Text = "Moble Cafe - 관리자 모드";
            // 
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(22, 89);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(426, 247);
            panel1.TabIndex = 3;
            // 
            // btn_exit
            // 
            btn_exit.Location = new System.Drawing.Point(202, 406);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(75, 23);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "돌아가기";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // AdminOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(493, 450);
            Controls.Add(btn_exit);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "AdminOrder";
            Text = "AdminOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
    }
}