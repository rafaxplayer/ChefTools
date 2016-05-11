using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace ChefTools
{
    public partial class About : XtraUserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                String email = ((LabelControl)sender).Text.ToString();
                if (GlobalUttilities.emailValidate(email))
                {

                    Process.Start(string.Format("mailto:{0}", email));
                }


            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error :" + ex.Message);
            }

        }
    }
}
