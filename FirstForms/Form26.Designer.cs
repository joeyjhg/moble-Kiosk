namespace FirstForms
{
    partial class Form26
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
            btAdd = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            textBox1 = new System.Windows.Forms.TextBox();
            treeView1 = new System.Windows.Forms.TreeView();
            btCollapseAll = new System.Windows.Forms.Button();
            btExpandAll = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btDelete = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            treeView2 = new System.Windows.Forms.TreeView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btAdd
            // 
            btAdd.Location = new System.Drawing.Point(230, 89);
            btAdd.Name = "btAdd";
            btAdd.Size = new System.Drawing.Size(150, 36);
            btAdd.TabIndex = 0;
            btAdd.Text = "추가";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(391, 373);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(treeView1);
            tabPage1.Controls.Add(btCollapseAll);
            tabPage1.Controls.Add(btAdd);
            tabPage1.Controls.Add(btExpandAll);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(btDelete);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(383, 345);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "C언어";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(230, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(146, 23);
            textBox1.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Location = new System.Drawing.Point(6, 15);
            treeView1.Name = "treeView1";
            treeView1.Size = new System.Drawing.Size(219, 324);
            treeView1.TabIndex = 0;
            // 
            // btCollapseAll
            // 
            btCollapseAll.Location = new System.Drawing.Point(230, 303);
            btCollapseAll.Name = "btCollapseAll";
            btCollapseAll.Size = new System.Drawing.Size(150, 36);
            btCollapseAll.TabIndex = 0;
            btCollapseAll.Text = "취소";
            btCollapseAll.UseVisualStyleBackColor = true;
            btCollapseAll.Click += btCollapseAll_Click;
            // 
            // btExpandAll
            // 
            btExpandAll.Location = new System.Drawing.Point(230, 250);
            btExpandAll.Name = "btExpandAll";
            btExpandAll.Size = new System.Drawing.Size(150, 36);
            btExpandAll.TabIndex = 0;
            btExpandAll.Text = "확장";
            btExpandAll.UseVisualStyleBackColor = true;
            btExpandAll.Click += btExpandAll_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(230, 142);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 36);
            button2.TabIndex = 0;
            button2.Text = "보기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new System.Drawing.Point(230, 197);
            btDelete.Name = "btDelete";
            btDelete.Size = new System.Drawing.Size(150, 36);
            btDelete.TabIndex = 0;
            btDelete.Text = "삭제";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(treeView2);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(383, 345);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            treeView2.Location = new System.Drawing.Point(0, 0);
            treeView2.Name = "treeView2";
            treeView2.Size = new System.Drawing.Size(270, 342);
            treeView2.TabIndex = 0;
            // 
            // Form26
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form26";
            Text = "Form26";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExpandAll;
        private System.Windows.Forms.Button btCollapseAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView2;
    }
}