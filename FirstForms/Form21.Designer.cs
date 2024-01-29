namespace FirstForms
{
    partial class Form21
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
            treeView1 = new System.Windows.Forms.TreeView();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new System.Drawing.Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new System.Drawing.Size(212, 204);
            treeView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(257, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 47);
            button1.TabIndex = 1;
            button1.Text = "클릭";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(257, 92);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(105, 47);
            button2.TabIndex = 1;
            button2.Text = "확장";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(257, 169);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(105, 47);
            button3.TabIndex = 1;
            button3.Text = "취소";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(477, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // Form21
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Enabled = false;
            Name = "Form21";
            Text = "Form21";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}