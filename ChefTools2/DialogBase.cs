
using ChefTools;
using ChefTools.Data;
using ChefTools.General.Pedidos;
using ChefTools.General.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChefTools
{
    public partial class DialogBase : Form
    {
        public DialogBase(DBHelper db, int id, int dialog)
        {
            InitializeComponent();
            switch (dialog)
            {
                case GlobalUttilities.DIALOGO_NEW_MENU:
                    DialogNewMenu dlg = new DialogNewMenu(db, id);
                    this.Width = dlg.Width;
                    this.Height = dlg.Height + 20;
                    this.Controls.Add(dlg);
                    this.Text = "Edición Menus";
                    break;
                case GlobalUttilities.DIALOGO_NEW_RECIPE:
                    DialogNewRecipe dlg2 = new DialogNewRecipe(db, id, openFileImage);
                    this.Width = dlg2.Width;
                    this.Height = dlg2.Height + 20;
                    this.Controls.Add(dlg2);
                    this.Text = "Edición Recetas";
                    break;

                case GlobalUttilities.DIALOGO_NEW_INVENTARIO:
                    DialogoNewInventario dlg3 = new DialogoNewInventario(db, id);
                    this.Width = dlg3.Width;
                    this.Height = dlg3.Height + 20;
                    this.Controls.Add(dlg3);
                    this.Text = "Edicion Inventarios";
                    break;
                case GlobalUttilities.DIALOGO_NEW_PROVEEDOR:
                    DialogoNewProveedor dlg4 = new DialogoNewProveedor(db, id);
                    this.Width = dlg4.Width;
                    this.Height = dlg4.Height + 20;
                    this.Controls.Add(dlg4);
                    this.Text = "Edición Proveedores";
                    break;
                case GlobalUttilities.DIALOGO_NEW_PEDIDO:
                    DialogNewPedido dlg5 = new DialogNewPedido(db, id);
                    this.Width = dlg5.Width;
                    this.Height = dlg5.Height + 20;
                    this.Controls.Add(dlg5);
                    this.Text = "Edición Pedidos";
                    break;
                case GlobalUttilities.DIALOGO_PROVEEDOR_DETALLE:
                    ProveedorDetails dlg6 = new ProveedorDetails(db, id);
                    this.Width = dlg6.Width;
                    this.Height = dlg6.Height + 20;
                    this.Controls.Add(dlg6);
                    this.Text = "Detalle Proveedor";
                    break;
                case GlobalUttilities.DIALOGO_PROVEEDOR_PRODUCTOS:
                    Proveedor_Productos dlg7 = new Proveedor_Productos(db, id);
                    this.Width = dlg7.Width;
                    this.Height = dlg7.Height + 20;
                    this.Controls.Add(dlg7);
                    this.Text = "Productos de este Proveedor";
                    break;
                case GlobalUttilities.DIALOGO_ABOUT:
                    About dlg8 = new About();
                    this.Width = dlg8.Width;
                    this.Height = dlg8.Height + 20;
                    this.Controls.Add(dlg8);
                    this.Text = "Acerca De...";
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
                default:
                    break;

            }
        }

        private void DialogBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
