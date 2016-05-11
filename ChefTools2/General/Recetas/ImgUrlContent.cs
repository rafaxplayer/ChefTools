using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ChefTools
{
    public partial class ImgUrlContent : UserControl
    {
        public ImgUrlContent()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/");
        }
    }
}
