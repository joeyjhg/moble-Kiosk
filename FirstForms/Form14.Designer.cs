namespace FirstForms
{
    partial class Form14
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
            progressBar1 = new System.Windows.Forms.ProgressBar();
            btnStart = new System.Windows.Forms.Button();
            btnInitial = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(105, 115);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(262, 23);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(292, 154);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnInitial
            // 
            btnInitial.Location = new System.Drawing.Point(292, 199);
            btnInitial.Name = "btnInitial";
            btnInitial.Size = new System.Drawing.Size(75, 23);
            btnInitial.TabIndex = 1;
            btnInitial.Text = "초기화";
            btnInitial.UseVisualStyleBackColor = true;
            btnInitial.Click += btnInitial_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(105, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(142, 23);
            textBox1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form14
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnInitial);
            Controls.Add(btnStart);
            Controls.Add(progressBar1);
            Name = "Form14";
            Text = "Form14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}