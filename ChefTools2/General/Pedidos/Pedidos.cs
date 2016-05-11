using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ChefTools.Informes;
using DevExpress.XtraReports.UI;
using ChefTools.Data;
using System.Data;
using System.Diagnostics;

namespace ChefTools
{
    public partial class Pedidos : DevExpress.XtraEditors.XtraForm
    {
        DBHelper db;
        int id;
        DataTable currentPedido;
        public Pedidos()
        {

            InitializeComponent();
            id = 0;
            db = new DBHelper();
            loadPedidos();
        }

        private void loadPedidos()
        {
            gridControl1.BeginUpdate();

            try
            {
                DataTable pedidos = db.loadDataWhithTable(DBHelper.TABLE_PEDIDOS);
                if (pedidos != null)
                {
                    gridControl1.DataSource = null;

                    gridControl1.DataSource = pedidos;
                    groupPedidos.Text = pedidos.Rows.Count > 0 ? "Lista de Pedidos" : "Lista de Pedidos (No hay Pedidos)";
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


        private void buttonNewPedido_Click(object sender, EventArgs e)
        {
            DialogBase dlg = new DialogBase(db, 0, GlobalUttilities.DIALOGO_NEW_PEDIDO);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                loadPedidos();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            String str = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns[0]);
            String name = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns[1]);
            this.id = Convert.ToInt32(str);

            displayWithID(this.id, name);
        }

        private void displayWithID(int id, String name)
        {

            gridControlPedido.BeginUpdate();

            try
            {
                DataTable dt = db.loadDataWithQuery("SELECT tbl_Pedidos_listas.pedido_id, tbl_Pedidos_listas.producto_id, tbl_Pedidos_listas.Producto_cantidad, tbl_Pedidos_listas.product_formato_id, tbl_Productos.name AS productoname, tbl_Productos_formato.name AS formatoname FROM "
                    + DBHelper.TABLE_PEDIDOS_LISTAS
                    + " LEFT JOIN " + DBHelper.TABLE_PRODUCTOS
                    + " ON tbl_Pedidos_listas.producto_id = tbl_Productos.id"
                    + " LEFT JOIN " + DBHelper.TABLE_PRODUCTOS_FORMATO
                    + " ON tbl_Productos_formato.id = tbl_Pedidos_listas.product_formato_id"
                    + " WHERE tbl_Pedidos_listas.pedido_id = " + id);
                gridControlPedido.DataSource = null;
                gridControlPedido.DataSource = dt;
                gridView4.GroupPanelText = name;
                currentPedido = dt;
                DataTable dtb = db.loadDataWithQuery("SELECT tbl_Pedidos.id ,tbl_Pedidos.proveedor_id ,tbl_Proveedores.name as proveedorname "
                    + "FROM tbl_Pedidos "
                    + "LEFT JOIN tbl_Proveedores "
                    + "ON tbl_Pedidos.proveedor_id = tbl_Proveedores.id "
                    + "WHERE tbl_Pedidos.id=" + id);

                if (dtb != null)
                {
                    labelProveedor.Text = dtb.Rows[0]["proveedorname"].ToString();
                    labelProveedor.Tag = dtb.Rows[0]["proveedor_id"].ToString();

                }



            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            finally
            {

                gridControlPedido.EndUpdate();

            }


        }

        private void groupBoxDetalle_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            String Caption = e.Button.Properties.Caption;
            switch (Caption)
            {
                case "Edit":
                    if (this.id > 0)
                    {
                        DialogBase dlg = new DialogBase(db, this.id, GlobalUttilities.DIALOGO_NEW_PEDIDO);

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            loadPedidos();
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("No has seleccionado nigun Pedido");
                    }
                    break;
                case "Delete":
                    if (gridView1.GetSelectedRows().Length > 0)
                    {

                        if (MessageBox.Show("Seguro quieres eliminar este Pedido?", "Eliminar ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {

                            int index = Convert.ToInt32(gridView1.GetRowCellDisplayText(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
                            if (db.DeleteData(index, DBHelper.TABLE_PEDIDOS) > 0)
                            {

                                gridView1.DeleteRow(gridView1.GetSelectedRows()[0]);
                            }
                            else
                            {
                                XtraMessageBox.Show("Error al eliminar datos");
                            }


                        }

                    }
                    break;
                case "Print":
                    if (this.id > 0 && currentPedido.Rows.Count > 0)
                    {
                        XtraReportPedido report = new XtraReportPedido(this.db, this.id);
                        ReportPrintTool tool = new ReportPrintTool(report);
                        tool.ShowRibbonPreview();

                    }
                    else
                    {
                        XtraMessageBox.Show("No has seleccionado nigun inventario para Imprimir");
                    }
                    break;
                default:
                    break;

            }
        }

        private void Pedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (db != null)
            {
                db.close();
            }
        }

        private void labelProveedor_Click(object sender, EventArgs e)
        {
            int id_Proveedor=Convert.ToInt32((sender as LabelControl).Tag);
            if ( id_Proveedor> 0) {
                DialogBase dlg = new DialogBase(db, id_Proveedor, GlobalUttilities.DIALOGO_PROVEEDOR_DETALLE);

                dlg.ShowDialog();
            }
        }


    }
}