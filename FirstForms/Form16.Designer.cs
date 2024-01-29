namespace FirstForms
{
    partial class Form16
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
            btDelete = new System.Windows.Forms.Button();
            domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btAdd
            // 
            btAdd.Location = new System.Drawing.Point(96, 30);
            btAdd.Name = "btAdd";
            btAdd.Size = new System.Drawing.Size(75, 23);
            btAdd.TabIndex = 0;
            btAdd.Text = "메뉴추가";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new System.Drawing.Point(96, 95);
            btDelete.Name = "btDelete";
            btDelete.Size = new System.Drawing.Size(75, 23);
            btDelete.TabIndex = 0;
            btDelete.Text = "메뉴삭제";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("자장면");
            domainUpDown1.Items.Add("짬뽕");
            domainUpDown1.Items.Add("간짜장");
            domainUpDown1.Items.Add("쟁반짜장");
            domainUpDown1.Items.Add("해물짬뽕");
            domainUpDown1.Items.Add("꿔바로우");
            domainUpDown1.Location = new System.Drawing.Point(252, 30);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new System.Drawing.Size(120, 23);
            domainUpDown1.TabIndex = 1;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(470, 30);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // Form16
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(domainUpDown1);
            Controls.Add(btDelete);
            Controls.Add(btAdd);
            Name = "Form16";
            Text = "Form16";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}