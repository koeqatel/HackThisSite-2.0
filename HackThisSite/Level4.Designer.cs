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
            this.outputImage2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // outputImage
            // 
            this.outputImage.BackColor = System.Drawing.Color.Black;
            this.outputImage.Location = new System.Drawing.Point(0, 0);
            this.outputImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(750, 812);
            this.outputImage.TabIndex = 0;
            this.outputImage.TabStop = false;
            // 
            // outputImage2
            // 
            this.outputImage2.BackColor = System.Drawing.Color.Black;
            this.outputImage2.Location = new System.Drawing.Point(750, 0);
            this.outputImage2.Margin = new System.Windows.Forms.Padding(2);
            this.outputImage2.Name = "outputImage2";
            this.outputImage2.Size = new System.Drawing.Size(750, 812);
            this.outputImage2.TabIndex = 1;
            this.outputImage2.TabStop = false;
            // 
            // Level4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 812);
            this.Controls.Add(this.outputImage2);
            this.Controls.Add(this.outputImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Level4";
            this.Text = "Level4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Level4_FormClosed);
            this.Load += new System.EventHandler(this.Level4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox outputImage;
        private System.Windows.Forms.PictureBox outputImage2;
    }
}