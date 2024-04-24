namespace HackThisSite
{
    partial class MainForm
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
            this.level1Button = new System.Windows.Forms.Button();
            this.level2Button = new System.Windows.Forms.Button();
            this.level3Button = new System.Windows.Forms.Button();
            this.level11Button = new System.Windows.Forms.Button();
            this.leve103Button = new System.Windows.Forms.Button();
            this.level9Button = new System.Windows.Forms.Button();
            this.level8Button = new System.Windows.Forms.Button();
            this.level7Button = new System.Windows.Forms.Button();
            this.level6Button = new System.Windows.Forms.Button();
            this.level5Button = new System.Windows.Forms.Button();
            this.level12Button = new System.Windows.Forms.Button();
            this.level4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // level1Button
            // 
            this.level1Button.Location = new System.Drawing.Point(13, 13);
            this.level1Button.Name = "level1Button";
            this.level1Button.Size = new System.Drawing.Size(135, 57);
            this.level1Button.TabIndex = 0;
            this.level1Button.Text = "Unscramble the words";
            this.level1Button.UseVisualStyleBackColor = true;
            this.level1Button.Click += new System.EventHandler(this.level1Button_Click);
            // 
            // level2Button
            // 
            this.level2Button.Location = new System.Drawing.Point(154, 13);
            this.level2Button.Name = "level2Button";
            this.level2Button.Size = new System.Drawing.Size(135, 57);
            this.level2Button.TabIndex = 1;
            this.level2Button.Text = "Analyze the picture and find the ascii code";
            this.level2Button.UseVisualStyleBackColor = true;
            this.level2Button.Click += new System.EventHandler(this.level2Button_Click);
            // 
            // level3Button
            // 
            this.level3Button.Location = new System.Drawing.Point(295, 13);
            this.level3Button.Name = "level3Button";
            this.level3Button.Size = new System.Drawing.Size(135, 57);
            this.level3Button.TabIndex = 2;
            this.level3Button.UseVisualStyleBackColor = true;
            // 
            // level11Button
            // 
            this.level11Button.Location = new System.Drawing.Point(295, 140);
            this.level11Button.Name = "level11Button";
            this.level11Button.Size = new System.Drawing.Size(135, 57);
            this.level11Button.TabIndex = 3;
            this.level11Button.Text = "Reverse Ascii Shift";
            this.level11Button.UseVisualStyleBackColor = true;
            this.level11Button.Click += new System.EventHandler(this.level11Button_Click);
            // 
            // leve103Button
            // 
            this.leve103Button.Location = new System.Drawing.Point(154, 140);
            this.leve103Button.Name = "leve103Button";
            this.leve103Button.Size = new System.Drawing.Size(135, 57);
            this.leve103Button.TabIndex = 4;
            this.leve103Button.UseVisualStyleBackColor = true;
            // 
            // level9Button
            // 
            this.level9Button.Location = new System.Drawing.Point(13, 140);
            this.level9Button.Name = "level9Button";
            this.level9Button.Size = new System.Drawing.Size(135, 57);
            this.level9Button.TabIndex = 5;
            this.level9Button.UseVisualStyleBackColor = true;
            // 
            // level8Button
            // 
            this.level8Button.Location = new System.Drawing.Point(436, 76);
            this.level8Button.Name = "level8Button";
            this.level8Button.Size = new System.Drawing.Size(135, 57);
            this.level8Button.TabIndex = 6;
            this.level8Button.Text = "Code an IRC bot (Skipped)";
            this.level8Button.UseVisualStyleBackColor = true;
            // 
            // level7Button
            // 
            this.level7Button.Location = new System.Drawing.Point(295, 76);
            this.level7Button.Name = "level7Button";
            this.level7Button.Size = new System.Drawing.Size(135, 57);
            this.level7Button.TabIndex = 7;
            this.level7Button.UseVisualStyleBackColor = true;
            // 
            // level6Button
            // 
            this.level6Button.Location = new System.Drawing.Point(154, 76);
            this.level6Button.Name = "level6Button";
            this.level6Button.Size = new System.Drawing.Size(135, 57);
            this.level6Button.TabIndex = 8;
            this.level6Button.Text = "Bypass the image captcha";
            this.level6Button.UseVisualStyleBackColor = true;
            this.level6Button.Click += new System.EventHandler(this.level6Button_Click);
            // 
            // level5Button
            // 
            this.level5Button.Location = new System.Drawing.Point(13, 76);
            this.level5Button.Name = "level5Button";
            this.level5Button.Size = new System.Drawing.Size(135, 57);
            this.level5Button.TabIndex = 9;
            this.level5Button.Text = "Fix a corrupted file (Skipped for now)";
            this.level5Button.UseVisualStyleBackColor = true;
            this.level5Button.Click += new System.EventHandler(this.level5Button_Click);
            // 
            // level12Button
            // 
            this.level12Button.Location = new System.Drawing.Point(436, 140);
            this.level12Button.Name = "level12Button";
            this.level12Button.Size = new System.Drawing.Size(135, 57);
            this.level12Button.TabIndex = 10;
            this.level12Button.UseVisualStyleBackColor = true;
            // 
            // level4Button
            // 
            this.level4Button.Location = new System.Drawing.Point(436, 13);
            this.level4Button.Name = "level4Button";
            this.level4Button.Size = new System.Drawing.Size(135, 57);
            this.level4Button.TabIndex = 11;
            this.level4Button.Text = "Parse an XML file";
            this.level4Button.UseVisualStyleBackColor = true;
            this.level4Button.Click += new System.EventHandler(this.level4Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.level4Button);
            this.Controls.Add(this.level12Button);
            this.Controls.Add(this.level5Button);
            this.Controls.Add(this.level6Button);
            this.Controls.Add(this.level7Button);
            this.Controls.Add(this.level8Button);
            this.Controls.Add(this.level9Button);
            this.Controls.Add(this.leve103Button);
            this.Controls.Add(this.level11Button);
            this.Controls.Add(this.level3Button);
            this.Controls.Add(this.level2Button);
            this.Controls.Add(this.level1Button);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button level1Button;
        private System.Windows.Forms.Button level2Button;
        private System.Windows.Forms.Button level3Button;
        private System.Windows.Forms.Button level11Button;
        private System.Windows.Forms.Button leve103Button;
        private System.Windows.Forms.Button level9Button;
        private System.Windows.Forms.Button level8Button;
        private System.Windows.Forms.Button level7Button;
        private System.Windows.Forms.Button level6Button;
        private System.Windows.Forms.Button level5Button;
        private System.Windows.Forms.Button level12Button;
        private System.Windows.Forms.Button level4Button;
    }
}