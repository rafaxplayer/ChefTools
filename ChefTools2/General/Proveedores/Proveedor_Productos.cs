using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChefTools.Data;
using System.Diagnostics;

namespace ChefTools.General.Proveedores
{
    public partial class Proveedor_Productos : UserControl
    {
        DBHelper database;
        int id;
        public Proveedor_Productos(DBHelper db , int id)
        {
            InitializeComponent();
            database = db;
            this.id = id;
        }


        private void displayWhitID(int id)
        {
            gridControl1.BeginUpdate();

            try
            {
                string sQuery = "SELECT tbl_Productos.id, tbl_Productos.name, tbl_Productos.product_categoria_id, tbl_Productos.product_formato_id, tbl_Productos.product_provider_id ,tbl_Productos_categoria.name AS categorianame ,tbl_Productos_formato.name AS formatoname FROM "
                    + DBHelper.TABLE_PRODUCTOS
                    + " LEFT JOIN " + DBHelper.TABLE_PRODUCTOS_CATEGORY
                    + " ON tbl_Productos.product_categoria_id = tbl_Productos_categoria.id"
                    + " LEFT JOIN " + DBHelper.TABLE_PRODUCTOS_FORMATO
                    + " ON tbl_Productos.product_formato_id = tbl_Productos_formato.id"
                    + " WHERE tbl_Productos.product_provider_id = " + id;

                DataTable table = database.loadDataWithQuery(sQuery);

                if (table != null)
                {
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = table;
                }


            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            finally
            {

                gridControl1.EndUpdate();

            }
        }
        private void ProveedorDetails_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            if (this.id > 0)
            {
                displayWhitID(this.id);
            }
        }
    }
}
