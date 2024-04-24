namespace HackThisSite
{
    partial class Level6
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
            this.TestImage = new System.Windows.Forms.PictureBox();
            this.outputTextbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputImage
            // 
            this.outputImage.BackColor = System.Drawing.Color.Black;
            this.outputImage.Location = new System.Drawing.Point(0, 0);
            this.outputImage.Margin = new System.Windows.Forms.Padding(2);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(700, 700);
            this.outputImage.TabIndex = 1;
            this.outputImage.TabStop = false;
            // 
            // TestImage
            // 
            this.TestImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TestImage.Location = new System.Drawing.Point(704, 0);
            this.TestImage.Margin = new System.Windows.Forms.Padding(2);
            this.TestImage.Name = "TestImage";
            this.TestImage.Size = new System.Drawing.Size(723, 700);
            this.TestImage.TabIndex = 2;
            this.TestImage.TabStop = false;
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(13, 706);
            this.outputTextbox.MaxLength = 999999;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.Size = new System.Drawing.Size(687, 27);
            this.outputTextbox.TabIndex = 3;
            this.outputTextbox.Text = "";
            // 
            // Level6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1438, 745);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.TestImage);
            this.Controls.Add(this.outputImage);
            this.Name = "Level6";
            this.Text = "Level6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Level6_FormClosed);
            this.Load += new System.EventHandler(this.Level6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox outputImage;
        private System.Windows.Forms.PictureBox TestImage;
        private System.Windows.Forms.RichTextBox outputTextbox;
    }
}