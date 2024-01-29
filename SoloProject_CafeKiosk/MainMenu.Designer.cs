namespace SoloProject_CafeKiosk
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            bt_ForHere = new System.Windows.Forms.Button();
            bt_TakeOut = new System.Windows.Forms.Button();
            bt_Admin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(176, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 37);
            label1.TabIndex = 0;
            label1.Text = "Moble Cafe";
            // 
            // bt_ForHere
            // 
            bt_ForHere.Location = new System.Drawing.Point(128, 161);
            bt_ForHere.Name = "bt_ForHere";
            bt_ForHere.Size = new System.Drawing.Size(98, 88);
            bt_ForHere.TabIndex = 1;
            bt_ForHere.Text = "매장식사";
            bt_ForHere.UseVisualStyleBackColor = true;
            bt_ForHere.Click += bt_ForHere_Click;
            // 
            // bt_TakeOut
            // 
            bt_TakeOut.Location = new System.Drawing.Point(291, 161);
            bt_TakeOut.Name = "bt_TakeOut";
            bt_TakeOut.Size = new System.Drawing.Size(98, 88);
            bt_TakeOut.TabIndex = 1;
            bt_TakeOut.Text = "포장하기";
            bt_TakeOut.UseVisualStyleBackColor = true;
            bt_TakeOut.Click += bt_TakeOut_Click;
            // 
            // bt_Admin
            // 
            bt_Admin.Location = new System.Drawing.Point(492, 407);
            bt_Admin.Name = "bt_Admin";
            bt_Admin.Size = new System.Drawing.Size(34, 31);
            bt_Admin.TabIndex = 2;
            bt_Admin.UseVisualStyleBackColor = true;
            bt_Admin.Click += bt_Admin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(538, 450);
            Controls.Add(bt_Admin);
            Controls.Add(bt_TakeOut);
            Controls.Add(bt_ForHere);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ForHere;
        private System.Windows.Forms.Button bt_TakeOut;
        private System.Windows.Forms.Button bt_Admin;
    }
}
