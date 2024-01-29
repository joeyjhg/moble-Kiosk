namespace FirstForms
{
    partial class Form23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            imageList1 = new System.Windows.Forms.ImageList(components);
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "cat-323262_640.jpg");
            imageList1.Images.SetKeyName(1, "cat-1151519_640.jpg");
            imageList1.Images.SetKeyName(2, "cat-2083492_640.jpg");
            imageList1.Images.SetKeyName(3, "european-shorthair-8136129_640.jpg");
            imageList1.Images.SetKeyName(4, "tiger-2535888_640.jpg");
            // 
            // Form23
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Name = "Form23";
            Text = "Form23";
            Paint += Form23_Paint;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
    }
}