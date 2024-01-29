namespace FirstForms
{
    partial class Form20
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("IT도서");
            treeView1 = new System.Windows.Forms.TreeView();
            tbNode = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnExpandAll = new System.Windows.Forms.Button();
            btnCollapseAll = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new System.Drawing.Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Root";
            treeNode1.Text = "IT도서";
            treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode1 });
            treeView1.Size = new System.Drawing.Size(224, 188);
            treeView1.TabIndex = 0;
            // 
            // tbNode
            // 
            tbNode.Location = new System.Drawing.Point(230, 0);
            tbNode.Name = "tbNode";
            tbNode.Size = new System.Drawing.Size(146, 23);
            tbNode.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(230, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(146, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(230, 69);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(146, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExpandAll
            // 
            btnExpandAll.Location = new System.Drawing.Point(230, 110);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new System.Drawing.Size(146, 23);
            btnExpandAll.TabIndex = 2;
            btnExpandAll.Text = "확장";
            btnExpandAll.UseVisualStyleBackColor = true;
            btnExpandAll.Click += btnExpandAll_Click;
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.Location = new System.Drawing.Point(230, 155);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new System.Drawing.Size(146, 23);
            btnCollapseAll.TabIndex = 2;
            btnCollapseAll.Text = "축소";
            btnCollapseAll.UseVisualStyleBackColor = true;
            btnCollapseAll.Click += btnCollapseAll_Click;
            // 
            // Form20
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnCollapseAll);
            Controls.Add(btnExpandAll);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tbNode);
            Controls.Add(treeView1);
            Name = "Form20";
            Text = "Form20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tbNode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnCollapseAll;
    }
}