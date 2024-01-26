using System;
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
    }
}
