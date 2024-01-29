namespace FirstForms
{
    partial class Form13
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
            hScrollBar1 = new System.Windows.Forms.HScrollBar();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new System.Drawing.Point(128, 32);
            hScrollBar1.Maximum = 200;
            hScrollBar1.Minimum = -50;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new System.Drawing.Size(166, 32);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Value = 20;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(128, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form13
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(hScrollBar1);
            Name = "Form13";
            Text = "Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
    }
}