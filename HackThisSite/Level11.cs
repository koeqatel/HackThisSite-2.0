using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackThisSite
{
    public partial class Level11 : Form
    {
        public string prevClipboardText = "";

        public Level11()
        {
            InitializeComponent();
        }

        private void Level11_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
