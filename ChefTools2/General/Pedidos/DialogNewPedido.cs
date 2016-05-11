using ChefTools.Data;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChefTools
{
    public partial class DialogNewPedido : DevExpress.XtraEditors.XtraUserControl
    {
        private DBHelper db;

        private int id;

        public DialogNewPedido(DBHelper dbase, int id)
        {
            InitializeComponent();
            this.db = dbase;
            this.id = id;
            loadProductos();
            loadProveedores();
            loadFormatos();
            initializeInvenatario(this.id > 0);

            if (this.id > 0)
            {
                DataTable tbInventario = db.loadDataWithQuery("SELECT * FROM " + DBHelper.TABLE_PEDIDOS + " WHERE tbl_Pedidos.id =" + this.id);
                if (tbInventario != null)
                {
                    DataRow row = tbInventario.Rows[0];
                    textPedidoName.Text = row["name"].ToString();
                    lookUpEditProveedores.EditValue = row["proveedor_id"];
                    gridViewPedidoLista.GroupPanelText = row["name"].ToString();

                    textPedidoComment.Text = row["comentario"].ToString();

                    buttonCreate.Text = "Actualizar\r\nPedido";

                }
                updateGridListPedido(this.id);
            }


        }


        private void initializeInvenatario(bool bol)
        {
            gridControlPedido.Enabled = bol;
            butNewData.Enabled = bol;
            newProduct.Enabled = bol;
            searchLookUpEditProducto.Enabled = bol;
            lookUpEditFormato.Enabled = bol;
            spinEditCantidad.Enabled = bol;
            butDeleteLine.Enabled = bol;

        }

        private void DialogoNewPedido_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void loadProductos()
        {
            DataTable productosData = db.loadDataWithQuery("SELECT tbl_Productos.id, tbl_Productos.name, tbl_Productos.product_categoria_id, tbl_Productos.product_formato_id, tbl_Productos.product_provider_id, tbl_Proveedores.name AS proveedorname, tbl_Productos_categoria.name AS categorianame FROM "
                    + DBHelper.TABLE_PRODUCTOS
                    + " LEFT JOIN " + DBHelper.TABLE_PROVEEDORES
                    + " ON tbl_Productos.product_provider_id = tbl_Proveedores.id"
                    + " LEFT JOIN " + DBHelper.TABLE_PRODUCTOS_CATEGORY
                    + " ON tbl_Productos.product_categoria_id = tbl_Productos_categoria.id");

            searchLookUpEditProducto.Properties.DataSource = productosData;
            searchGridLookUpEditProductos.DataSource = productosData;

        }
        private void loadProveedores()
        {
            DataTable proveedores = db.loadDataWhithTable(DBHelper.TABLE_PROVEEDORES);
            lookUpEditProveedores.Properties.DataSource = proveedores;
        }
        private void loadFormatos()
        {
            DataTable formatos = db.loadDataWhithTable(DBHelper.TABLE_PRODUCTOS_FORMATO);
            lookUpEditFormato.Properties.DataSource = formatos;
            LookUpEditFormatos.DataSource = formatos;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textPedidoName.Text.ToString()))
            {
                XtraMessageBox.Show("Debes Introducir un nombre a tu Pedido");
            }
            else
            {
                if (this.id == 0)
                {
                    if (db.checkIfDataExists(DBHelper.TABLE_PEDIDOS, DBHelper.NAME, textPedidoName.Text.ToString()))
                    {
                        XtraMessageBox.Show("Este nombre ya esta en uso , utiliza otro");

                        return;
                    }
                }

                int proveedor = Convert.ToInt32(lookUpEditProveedores.EditValue);
                int ret = db.saveOrUpdatePedido(this.id, textPedidoName.Text.ToString(), proveedor, textPedidoComment.Text.ToString());
                initializeInvenatario(ret > 0);

                if (ret > 0)
                {
                    XtraMessageBox.Show(this.id > 0 ? "Pedido Actualizado!" : "Ok Pedido creado , edita tus entradas");
                    (sender as SimpleButton).Text = "OK";
                    (sender as SimpleButton).Enabled = false;
                    int retId = Convert.ToInt32(db.excuteQuery("SELECT Last_Insert_Rowid() FROM tbl_Pedidos"));
                    this.id = retId == 0 ? this.id : retId;
                    gridViewPedidoLista.GroupPanelText = textPedidoName.Text.ToString();
                }
            }
        }

        private void butNewLine_Click(object sender, EventArgs e)
        {
            if (this.id > 0)
            {
                DataRowView row = searchLookUpEditProducto.GetSelectedDataRow() as DataRowView;
                DataRowView row2 = lookUpEditFormato.Properties.GetDataSourceRowByKeyValue(lookUpEditFormato.EditValue) as DataRowView;
                int cantidad = Convert.ToInt32(spinEditCantidad.Text);

                if (row != null || row2 != null)
                {
                    int formatoid = Convert.ToInt32(row2[0]);
                    int productoid = Convert.ToInt32(row[0]);
                    int categoriaid = Convert.ToInt32(row[2]);

                    setNewData(this.id, productoid, cantidad, categoriaid, formatoid);
                }
                else
                {
                    XtraMessageBox.Show("No has seleccionado un producto");
                }

            }

        }

        private void setNewData(int pedidoid, int producto, int cantidad, int categoriaid, int formato)
        {


            if (db.savePedidoLista(this.id, pedidoid, producto, cantidad, categoriaid, formato) > 0)
            {
                updateGridListPedido(this.id);
            }
            else
            {
                XtraMessageBox.Show("Error al insertar datos");
            }


        }

        private void updateGridListPedido(int id)
        {
            gridControlPedido.BeginUpdate();

            try
            {

                gridControlPedido.DataSource = null;
                DataTable listPed = db.loadDataWithQuery("SELECT * FROM " + DBHelper.TABLE_PEDIDOS_LISTAS + " WHERE " + DBHelper.PEDIDO_ID + " = " + id);
                gridControlPedido.DataSource = listPed;

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


        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(gridViewPedidoLista.GetRowCellValue(e.RowHandle, gridViewPedidoLista.Columns[0]).ToString());
                int pedidoId = Convert.ToInt32(gridViewPedidoLista.GetRowCellValue(e.RowHandle, gridViewPedidoLista.Columns[1]).ToString());
                int productoId = Convert.ToInt32(gridViewPedidoLista.GetRowCellValue(e.RowHandle, gridViewPedidoLista.Columns[2]).ToString());
                int cantidad = Convert.ToInt32(gridViewPedidoLista.GetRowCellValue(e.RowHandle, gridViewPedidoLista.Columns[3]).ToString());
                int categoriaId = Convert.ToInt32(gridViewPedidoLista.GetRowCellValue(e.RowHandle, gridViewPedidoLista.Columns[4]).ToString());
                int formatoId = Convert.ToInt32(gridViewPedidoLista.GetRowCellValue(e.RowHandle, gridViewPedidoLista.Columns[5]).ToString());
                if (db.updatePedidoListaInvID(id, pedidoId, productoId, cantidad, categoriaId, formatoId) > 0)
                {
                    updateGridListPedido(this.id);
                }
                else
                {
                    XtraMessageBox.Show("Error al insertar datos");
                }

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error ,Datos NO Actualizados : " + ex.Message);
                return;
            }
            finally
            {
                XtraMessageBox.Show("Ok ,Datos Actualizados");
            }
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void butDeleteLine_Click(object sender, EventArgs e)
        {

            if (gridViewPedidoLista.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {

                gridViewPedidoLista.DeleteRow(gridViewPedidoLista.FocusedRowHandle);

            }
        }

        private void gridView2_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (XtraMessageBox.Show("Seguro Quieres eliminar la fila selecionada?", "Eliminar ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                int id = Convert.ToInt32(gridViewPedidoLista.GetRowCellDisplayText(e.RowHandle, gridViewPedidoLista.Columns[0]));
                if (db.DeleteData(id, DBHelper.TABLE_PEDIDOS_LISTAS) > 0)
                {
                    XtraMessageBox.Show("Ok ,Datos eliminados");

                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                loadProductos();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogBase dlg = new DialogBase(db, 0, GlobalUttilities.DIALOGO_NEW_PROVEEDOR);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                loadProveedores();
            }
        }
    }
}
