using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using ChefTools.Data;

namespace ChefTools
{
    public partial class DialogoNewInventario : DevExpress.XtraEditors.XtraUserControl
    {
        private DBHelper db;

        private int id;

        public DialogoNewInventario(DBHelper dbase, int id)
        {
            InitializeComponent();
            this.db = dbase;
            this.id = id;

            LoadProductos();
            initializeInvenatario(this.id > 0);

            if (this.id > 0)
            {
                DataTable tbInventario = db.loadDataWithQuery("SELECT * FROM " + DBHelper.TABLE_INVENTARIOS + " WHERE tbl_Inventarios.id =" + this.id);
                if (tbInventario != null)
                {

                    DataRow row = tbInventario.Rows[0];
                    textInventarioName.Text = row["name"].ToString();
                    gridView2.GroupPanelText = row["name"].ToString();
                    textInventarioComment.Text = row["comentario"].ToString();

                    buttonCreate.Text = "Actualizar\r\nInventario";

                }
                updateGridListInventarios(this.id);
            }

        }


        private void initializeInvenatario(bool bol)
        {
            gridControlInventario.Enabled = bol;
            butNewData.Enabled = bol;
            newProduct.Enabled = bol;
            lookUpEditFormato.Enabled = bol;
            spinEditCantidad.Enabled = bol;
            searchLookUpEditProducto.Enabled = bol;
            butDeleteLine.Enabled = bol;

        }

        private void DialogoNewInventario_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void LoadProductos()
        {
            DataTable productosData = db.loadDataWithQuery("SELECT tbl_Productos.id, tbl_Productos.name, tbl_Productos.product_categoria_id, tbl_Productos.product_formato_id, tbl_Productos.product_provider_id, tbl_Proveedores.name AS proveedorname, tbl_Productos_categoria.name AS categorianame FROM "
                    + DBHelper.TABLE_PRODUCTOS
                    + " LEFT JOIN " + DBHelper.TABLE_PROVEEDORES
                    + " ON tbl_Productos.product_provider_id = tbl_Proveedores.id"
                    + " LEFT JOIN " + DBHelper.TABLE_PRODUCTOS_CATEGORY
                    + " ON tbl_Productos.product_categoria_id = tbl_Productos_categoria.id");

            DataTable formatos = db.loadDataWhithTable(DBHelper.TABLE_PRODUCTOS_FORMATO);

            SearchLookUpEditProductos.DataSource = productosData;
            searchLookUpEditProducto.Properties.DataSource = productosData;
            lookUpEditFormato.Properties.DataSource = formatos;
            FormatoslookUpEdit.DataSource = formatos;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textInventarioName.Text.ToString()))
            {
                XtraMessageBox.Show("Debes Introducir un nombre a tu inventario");
            }
            else
            {
                if (this.id == 0)
                {
                    if (db.checkIfDataExists(DBHelper.TABLE_INVENTARIOS, DBHelper.NAME, textInventarioName.Text.ToString()))
                    {
                        XtraMessageBox.Show("Este nombre ya esta en uso , utiliza otro");

                        return;
                    }
                }
                int ret = db.saveOrUpdateInventario(this.id, textInventarioName.Text.ToString(), textInventarioComment.Text.ToString());
                initializeInvenatario(ret > 0);

                if (ret > 0)
                {
                    XtraMessageBox.Show(this.id > 0 ? "Inventario Actualizado!" : "Ok Inventario creado , edita tus entradas");
                    (sender as SimpleButton).Text = "OK";
                    (sender as SimpleButton).Enabled = false;
                    int retId = Convert.ToInt32(db.excuteQuery("SELECT Last_Insert_Rowid() FROM tbl_Inventarios"));
                    this.id = retId == 0 ? this.id : retId;
                    gridView2.GroupPanelText = textInventarioName.Text.ToString();
                }
            }
        }

        private void butNewLine_Click(object sender, EventArgs e)
        {
            if (this.id > 0)
            {
                DataRowView row = searchLookUpEditProducto.Properties.GetRowByKeyValue(searchLookUpEditProducto.EditValue) as DataRowView;
                //DataRowView row = lookUpEditProducto.Properties.GetDataSourceRowByKeyValue(lookUpEditProducto.EditValue) as DataRowView;
                DataRowView row2 = lookUpEditFormato.Properties.GetDataSourceRowByKeyValue(lookUpEditFormato.EditValue) as DataRowView;
                int cantidad = Convert.ToInt32(spinEditCantidad.Text);

                if (row != null || row2 != null)
                {
                    int formatoid = Convert.ToInt32(row2[0]);
                    int productoid = Convert.ToInt32(row[0]);
                    int categoriaid = Convert.ToInt32(row[3]);

                    setNewData(this.id, productoid, cantidad, categoriaid, formatoid);
                }
                else
                {
                    XtraMessageBox.Show("No has seleccionado un producto");
                }

            }

        }

        private void setNewData(int inventarioid, int producto, int cantidad, int categoriaid, int formato)
        {


            if (db.saveInventarioLista(this.id, inventarioid, producto, cantidad, categoriaid, formato) > 0)
            {
                updateGridListInventarios(this.id);
            }
            else
            {
                XtraMessageBox.Show("Error al insertar datos");
            }

        }

        private void updateGridListInventarios(int id)
        {
            gridControlInventario.BeginUpdate();

            try
            {

                gridControlInventario.DataSource = null;
                DataTable tb_invList = db.loadDataWithQuery("SELECT * FROM " + DBHelper.TABLE_INVENTARIOS_LISTAS + " WHERE tbl_Inventarios_listas.inventario_id =" + id);
                gridControlInventario.DataSource = tb_invList;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            finally
            {
                gridControlInventario.EndUpdate();

            }

        }


        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[0]).ToString());
                int inventarioid = Convert.ToInt32(gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[1]).ToString());
                int producto = Convert.ToInt32(gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[2]).ToString());
                int cantidad = Convert.ToInt32(gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[3]).ToString());
                int categoria = Convert.ToInt32(gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[4]).ToString());
                int formato = Convert.ToInt32(gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[5]).ToString());

                if (db.updateInventarioListaInvID(id, inventarioid, producto, cantidad, categoria, formato) > 0)
                {
                    updateGridListInventarios(this.id);
                }
                else
                {
                    XtraMessageBox.Show("Error al insertar datos");
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                XtraMessageBox.Show("Error ,Datos NO Actualizados :" + ex.Message);
                return;
            }
            finally
            {
                XtraMessageBox.Show("Ok ,Datos Actualizados");
            }

        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView2.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {

                    gridView2.DeleteRow(gridView2.FocusedRowHandle);

                }

            }


        }

        private void butDeleteLine_Click(object sender, EventArgs e)
        {

            if (gridView2.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {

                gridView2.DeleteRow(gridView2.FocusedRowHandle);

            }
        }

        private void gridView2_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (XtraMessageBox.Show("Seguro Quieres eliminar la fila selecionada?", "Eliminar ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                int id = Convert.ToInt32(gridView2.GetRowCellDisplayText(e.RowHandle, gridView2.Columns[0]));
                if (db.DeleteData(id, DBHelper.TABLE_INVENTARIOS_LISTAS) > 0)
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
                LoadProductos();
            }
        }

    }
}
