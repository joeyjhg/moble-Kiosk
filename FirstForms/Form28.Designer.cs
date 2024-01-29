namespace FirstForms
{
    partial class Form28
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
            button1 = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ContextMenuStrip = contextMenuStrip1;
            button1.Location = new System.Drawing.Point(241, 144);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(244, 123);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { colorToolStripMenuItem, fontToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { asdToolStripMenuItem, asdToolStripMenuItem1 });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // asdToolStripMenuItem
            // 
            asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            asdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            asdToolStripMenuItem.Text = "Font";
            asdToolStripMenuItem.Click += asdToolStripMenuItem_Click;
            // 
            // asdToolStripMenuItem1
            // 
            asdToolStripMenuItem1.Name = "asdToolStripMenuItem1";
            asdToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            asdToolStripMenuItem1.Text = "Back";
            asdToolStripMenuItem1.Click += asdToolStripMenuItem1_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // Form28
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Name = "Form28";
            Text = "Form28";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
    }
}