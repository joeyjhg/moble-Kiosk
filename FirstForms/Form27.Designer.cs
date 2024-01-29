namespace FirstForms
{
    partial class Form27
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripSave = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            프로그램ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemCa = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemPi = new System.Windows.Forms.ToolStripMenuItem();
            lbResult = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripCopy = new System.Windows.Forms.ToolStripMenuItem();
            toolStripPaste = new System.Windows.Forms.ToolStripMenuItem();
            toolStripCut = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuFile, 프로그램ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ToolStripNew, ToolStripOpen, ToolStripSave, toolStripSeparator1, ToolStripExit });
            toolStripMenuFile.Name = "toolStripMenuFile";
            toolStripMenuFile.Size = new System.Drawing.Size(43, 20);
            toolStripMenuFile.Text = "파일";
            // 
            // ToolStripNew
            // 
            ToolStripNew.Name = "ToolStripNew";
            ToolStripNew.Size = new System.Drawing.Size(141, 22);
            ToolStripNew.Text = "새로 만들기";
            ToolStripNew.Click += toolStripMenuItem2_Click;
            // 
            // ToolStripOpen
            // 
            ToolStripOpen.Name = "ToolStripOpen";
            ToolStripOpen.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            ToolStripOpen.Size = new System.Drawing.Size(141, 22);
            ToolStripOpen.Text = "열기";
            ToolStripOpen.Click += ToolStripOpen_Click;
            // 
            // ToolStripSave
            // 
            ToolStripSave.Name = "ToolStripSave";
            ToolStripSave.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            ToolStripSave.Size = new System.Drawing.Size(141, 22);
            ToolStripSave.Text = "저장";
            ToolStripSave.Click += ToolStripSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // ToolStripExit
            // 
            ToolStripExit.Name = "ToolStripExit";
            ToolStripExit.Size = new System.Drawing.Size(141, 22);
            ToolStripExit.Text = "종료";
            ToolStripExit.Click += ToolStripExit_Click;
            // 
            // 프로그램ToolStripMenuItem
            // 
            프로그램ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemCa, toolStripMenuItemPi });
            프로그램ToolStripMenuItem.Name = "프로그램ToolStripMenuItem";
            프로그램ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            프로그램ToolStripMenuItem.Text = "프로그램";
            // 
            // toolStripMenuItemCa
            // 
            toolStripMenuItemCa.Name = "toolStripMenuItemCa";
            toolStripMenuItemCa.Size = new System.Drawing.Size(110, 22);
            toolStripMenuItemCa.Text = "계산기";
            toolStripMenuItemCa.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItemPi
            // 
            toolStripMenuItemPi.Name = "toolStripMenuItemPi";
            toolStripMenuItemPi.Size = new System.Drawing.Size(110, 22);
            toolStripMenuItemPi.Text = "그림판";
            toolStripMenuItemPi.Click += toolStripMenuItemPi_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new System.Drawing.Point(24, 151);
            lbResult.Name = "lbResult";
            lbResult.Size = new System.Drawing.Size(107, 15);
            lbResult.TabIndex = 1;
            lbResult.Text = "결과를 출력합니다";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripCopy, toolStripPaste, toolStripCut });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            contextMenuStrip1.Click += contextMenuStrip1_Click;
            // 
            // toolStripCopy
            // 
            toolStripCopy.Name = "toolStripCopy";
            toolStripCopy.Size = new System.Drawing.Size(122, 22);
            toolStripCopy.Text = "복사";
            toolStripCopy.Click += toolStripCopy_Click;
            // 
            // toolStripPaste
            // 
            toolStripPaste.Name = "toolStripPaste";
            toolStripPaste.Size = new System.Drawing.Size(122, 22);
            toolStripPaste.Text = "붙여넣기";
            toolStripPaste.Click += toolStripPaste_Click;
            // 
            // toolStripCut
            // 
            toolStripCut.Name = "toolStripCut";
            toolStripCut.Size = new System.Drawing.Size(122, 22);
            toolStripCut.Text = "잘라내기";
            toolStripCut.Click += toolStripCut_Click;
            // 
            // Form27
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(lbResult);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form27";
            Text = "Form27";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ToolStripMenuItem 프로그램ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCa;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripPaste;
        private System.Windows.Forms.ToolStripMenuItem toolStripCut;
    }
}