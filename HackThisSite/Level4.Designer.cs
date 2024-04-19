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
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.rotateRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputImage
            // 
            this.outputImage.BackColor = System.Drawing.Color.Black;
            this.outputImage.Location = new System.Drawing.Point(0, 40);
            this.outputImage.Margin = new System.Windows.Forms.Padding(2);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(750, 812);
            this.outputImage.TabIndex = 0;
            this.outputImage.TabStop = false;
            // 
            // buttonBlue
            // 
            this.buttonBlue.Location = new System.Drawing.Point(93, 12);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(75, 23);
            this.buttonBlue.TabIndex = 3;
            this.buttonBlue.Text = "Blue";
            this.buttonBlue.UseVisualStyleBackColor = true;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.Location = new System.Drawing.Point(255, 12);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(75, 23);
            this.buttonRed.TabIndex = 4;
            this.buttonRed.Text = "Red";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.Location = new System.Drawing.Point(336, 12);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(75, 23);
            this.buttonYellow.TabIndex = 5;
            this.buttonYellow.Text = "Yellow";
            this.buttonYellow.UseVisualStyleBackColor = true;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.Location = new System.Drawing.Point(174, 12);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(75, 23);
            this.buttonGreen.TabIndex = 6;
            this.buttonGreen.Text = "Green";
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.Location = new System.Drawing.Point(417, 12);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(75, 23);
            this.buttonWhite.TabIndex = 7;
            this.buttonWhite.Text = "White";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // rotateLeft
            // 
            this.rotateLeft.Location = new System.Drawing.Point(12, 12);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(75, 23);
            this.rotateLeft.TabIndex = 1;
            this.rotateLeft.Text = "< Rotate";
            this.rotateLeft.UseVisualStyleBackColor = true;
            this.rotateLeft.Click += new System.EventHandler(this.rotateLeft_Click);
            // 
            // rotateRight
            // 
            this.rotateRight.Location = new System.Drawing.Point(498, 12);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(75, 23);
            this.rotateRight.TabIndex = 2;
            this.rotateRight.Text = "Rotate >";
            this.rotateRight.UseVisualStyleBackColor = true;
            this.rotateRight.Click += new System.EventHandler(this.rotateRight_Click);
            // 
            // Level4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 852);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.rotateRight);
            this.Controls.Add(this.rotateLeft);
            this.Controls.Add(this.outputImage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Level4";
            this.Text = "Level4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Level4_FormClosed);
            this.Load += new System.EventHandler(this.Level4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox outputImage;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button rotateLeft;
        private System.Windows.Forms.Button rotateRight;
    }
}