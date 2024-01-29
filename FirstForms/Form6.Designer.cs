namespace FirstForms
{
    partial class Form6
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
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            bt_For = new System.Windows.Forms.Button();
            bt_Foreach = new System.Windows.Forms.Button();
            bt_While = new System.Windows.Forms.Button();
            bt_DoWhile = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(435, 426);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // bt_For
            // 
            bt_For.Location = new System.Drawing.Point(475, 12);
            bt_For.Name = "bt_For";
            bt_For.Size = new System.Drawing.Size(163, 86);
            bt_For.TabIndex = 1;
            bt_For.Text = "For문";
            bt_For.UseVisualStyleBackColor = true;
            bt_For.Click += bt_For_Click;
            // 
            // bt_Foreach
            // 
            bt_Foreach.Location = new System.Drawing.Point(475, 126);
            bt_Foreach.Name = "bt_Foreach";
            bt_Foreach.Size = new System.Drawing.Size(163, 86);
            bt_Foreach.TabIndex = 1;
            bt_Foreach.Text = "Foreach문";
            bt_Foreach.UseVisualStyleBackColor = true;
            bt_Foreach.Click += bt_Foreach_Click;
            // 
            // bt_While
            // 
            bt_While.Location = new System.Drawing.Point(475, 249);
            bt_While.Name = "bt_While";
            bt_While.Size = new System.Drawing.Size(163, 86);
            bt_While.TabIndex = 1;
            bt_While.Text = "While문";
            bt_While.UseVisualStyleBackColor = true;
            bt_While.Click += bt_While_Click;
            // 
            // bt_DoWhile
            // 
            bt_DoWhile.Location = new System.Drawing.Point(475, 352);
            bt_DoWhile.Name = "bt_DoWhile";
            bt_DoWhile.Size = new System.Drawing.Size(163, 86);
            bt_DoWhile.TabIndex = 1;
            bt_DoWhile.Text = "do While문";
            bt_DoWhile.UseVisualStyleBackColor = true;
            bt_DoWhile.Click += bt_DoWhile_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(bt_DoWhile);
            Controls.Add(bt_While);
            Controls.Add(bt_Foreach);
            Controls.Add(bt_For);
            Controls.Add(richTextBox1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bt_For;
        private System.Windows.Forms.Button bt_Foreach;
        private System.Windows.Forms.Button bt_While;
        private System.Windows.Forms.Button bt_DoWhile;
    }
}