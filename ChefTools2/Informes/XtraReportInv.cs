using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using ChefTools.Data;
using System.Diagnostics;

namespace ChefTools.Informes
{
    public partial class XtraReportInv : DevExpress.XtraReports.UI.XtraReport
    {
        
        public XtraReportInv(DBHelper db,int id)
        {
            InitializeComponent();
            try
            {
                DataTable table = db.loadDataWithQuery("SELECT tbl_Inventarios_listas.inventario_id, tbl_Inventarios_listas.producto_id,tbl_Inventarios_listas.product_categoria_id, tbl_Inventarios_listas.Producto_cantidad, tbl_Inventarios_listas.product_formato_id, tbl_Productos.name AS productoname, tbl_Productos_formato.name AS formatoname,tbl_Inventarios.date AS date, tbl_Inventarios.name AS inventarioname,tbl_Productos_categoria.name AS categorianame FROM "
                    + DBHelper.TABLE_INVENTARIOS_LISTAS
                    + " INNER JOIN " + DBHelper.TABLE_INVENTARIOS
                    + " ON tbl_Inventarios.id = tbl_Inventarios_listas.inventario_id"
                    + " INNER JOIN " + DBHelper.TABLE_PRODUCTOS_CATEGORY
                    + " ON tbl_Inventarios_listas.product_categoria_id = tbl_Productos_categoria.id"
                    + " INNER JOIN " + DBHelper.TABLE_PRODUCTOS
                    + " ON tbl_Inventarios_listas.producto_id = tbl_Productos.id"
                    + " INNER JOIN " + DBHelper.TABLE_PRODUCTOS_FORMATO
                    + " ON tbl_Productos_formato.id = tbl_Inventarios_listas.product_formato_id"
                    + " WHERE tbl_Inventarios_listas.inventario_id = " + id);
                if (table != null)
                {
                    this.DataSource = table;
                }
            }
            catch (Exception ex) {

                Debug.WriteLine(ex.Message);
            }

            
                
           
        }

    }
}
