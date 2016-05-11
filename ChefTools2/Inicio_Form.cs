using ChefTools;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChefTools
{
    public partial class Inicio_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Inicio_Form()
        {
            InitializeComponent();
            Recetas frm = new Recetas();
            frm.MdiParent = this;
            frm.Show();
            GlobalUttilities.checkBackupsFolder();
            
        }
        

        private void showForm(XtraForm frm, String name)
        {

            if (Application.OpenForms[name] == null)
            {
                
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms[name].Focus();
            }
        }


        private void skinRibbonGalleryBarItem2_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            Properties.Settings.Default.SkinName = e.Item.Tag.ToString();
            Properties.Settings.Default.Save();
        }

        private void recipes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showForm(new Recetas(), "Recetas");
        }


        private void menus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showForm(new Menus(), "Menus");
        }

        private void inventariosButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showForm(new Inventarios(),"Inventarios");
        }

        private void proveedoresButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showForm(new Proveedores(), "Proveedores");
        }

        private void pedidosButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showForm(new Pedidos(), "Pedidos");
        }

        private void productosButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showForm(new Productos(), "Productos");

        }

        private void ajustesButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showForm(new Ajustes(), "Ajustes");
        }

        private void backupButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showForm(new Backups(), "Copias de Seguridad");
        }

        private void about_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogBase dl = new DialogBase(null, 0, GlobalUttilities.DIALOGO_ABOUT);
            dl.ShowDialog(this);

        }
    }
}
