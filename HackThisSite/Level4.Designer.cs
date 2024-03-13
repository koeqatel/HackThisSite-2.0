namespace HackThisSite
{
    partial class Level4
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
            this.outputImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputImage
            // 
            this.outputImage.BackColor = System.Drawing.Color.Black;
            this.outputImage.Location = new System.Drawing.Point(0, 0);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(1000, 1000);
            this.outputImage.TabIndex = 0;
            this.outputImage.TabStop = false;
            // 
            // Level4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.outputImage);
            this.Name = "Level4";
            this.Text = "Level4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Level4_FormClosed);
            this.Load += new System.EventHandler(this.Level4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox outputImage;
    }
}