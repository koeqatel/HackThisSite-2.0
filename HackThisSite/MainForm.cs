﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackThisSite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void level1Button_Click(object sender, EventArgs e)
        {
            Level1 level1 = new Level1();
            level1.Show();

            this.Hide();
        }

        private void level2Button_Click(object sender, EventArgs e)
        {
            Level2 level2 = new Level2();
            level2.Show();

            this.Hide();
        }

        private void level11Button_Click(object sender, EventArgs e)
        {
            Level11 level11 = new Level11();
            level11.Show();

            this.Hide();
        }

        private void level4Button_Click(object sender, EventArgs e)
        {
            Level4 level4 = new Level4();
            level4.Show();

            this.Hide();
        }

        private void level5Button_Click(object sender, EventArgs e)
        {
            Level5 level5 = new Level5();
            level5.Show();

            this.Hide();
        }

        private void level6Button_Click(object sender, EventArgs e)
        {
            Level6 level6 = new Level6();
            level6.Show();

            this.Hide();
        }
    }
}
