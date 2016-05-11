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
    public partial class XtraReportPedido : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportPedido(DBHelper db,int id)
        {
            InitializeComponent();
            try
            {
                DataTable table = db.loadDataWithQuery("SELECT tbl_Pedidos_listas.Pedido_id, tbl_Pedidos_listas.producto_id,tbl_Pedidos_listas.product_categoria_id, tbl_Pedidos_listas.Producto_cantidad, tbl_Pedidos_listas.product_formato_id, tbl_Productos.name AS productoname, tbl_Productos_formato.name AS formatoname,tbl_Pedidos.date AS date, tbl_Pedidos.name AS Pedidoname,tbl_Productos_categoria.name AS categorianame FROM "
                    + DBHelper.TABLE_PEDIDOS_LISTAS
                    + " INNER JOIN " + DBHelper.TABLE_PEDIDOS
                    + " ON tbl_Pedidos.id = tbl_Pedidos_listas.Pedido_id"
                    + " INNER JOIN " + DBHelper.TABLE_PRODUCTOS_CATEGORY
                    + " ON tbl_Pedidos_listas.product_categoria_id = tbl_Productos_categoria.id"
                    + " INNER JOIN " + DBHelper.TABLE_PRODUCTOS
                    + " ON tbl_Pedidos_listas.producto_id = tbl_Productos.id"
                    + " INNER JOIN " + DBHelper.TABLE_PRODUCTOS_FORMATO
                    + " ON tbl_Productos_formato.id = tbl_Pedidos_listas.product_formato_id"
                    + " WHERE tbl_Pedidos_listas.Pedido_id = " + id);
                if (table != null)
                {
                    this.DataSource = table;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
            
        }

    }
}
