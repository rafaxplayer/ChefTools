using ChefTools.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChefTools
{
    public partial class Productos : XtraForm
    {
        DBHelper db;
        public Productos()
        {

            InitializeComponent();
            db = new DBHelper();
            Productos_Load();
            LookUpEditCategoria.DataSource = db.loadDataWhithTable(DBHelper.TABLE_PRODUCTOS_CATEGORY);
            LookUpEditProveedor.DataSource = db.loadDataWhithTable(DBHelper.TABLE_PROVEEDORES);
            LookUpEditFormato.DataSource = db.loadDataWhithTable(DBHelper.TABLE_PRODUCTOS_FORMATO);

        }

        private void Productos_Load()
        {
            gridControl1.BeginUpdate();

            try
            {
                DataTable table = db.loadDataWhithTable(DBHelper.TABLE_PRODUCTOS);
                if (table != null) {
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = table;
                    groupRecetas.Text = table.Rows.Count > 0 ? "Lista de Productos" : "Lista de Productos (No hay Productos)";
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


        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(((GridView)sender).GetRowCellValue(e.RowHandle, ((GridView)sender).Columns[0]).ToString());
                String name = ((GridView)sender).GetRowCellValue(e.RowHandle, ((GridView)sender).Columns[1]).ToString();
                int formatoid = Convert.ToInt32(((GridView)sender).GetRowCellValue(e.RowHandle, ((GridView)sender).Columns[2]).ToString());
                int categoriaid = Convert.ToInt32(((GridView)sender).GetRowCellValue(e.RowHandle, ((GridView)sender).Columns[3]).ToString());
                int proveedorid = Convert.ToInt32(((GridView)sender).GetRowCellValue(e.RowHandle, ((GridView)sender).Columns[4]).ToString());
                
                if (!String.IsNullOrEmpty(name))
                {
                    if (db.saveOrUpdateProducto(id, name, formatoid, categoriaid, proveedorid) > 0)
                    {

                        XtraMessageBox.Show("Ok , Datos Actualizados");
                        Productos_Load();

                    }
                    else
                    {

                        XtraMessageBox.Show("Error al insertar datos");
                    }
                }


            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            ((GridView)sender).SetRowCellValue(e.RowHandle, ((GridView)sender).Columns[0], 0);
            ((GridView)sender).SetRowCellValue(e.RowHandle, ((GridView)sender).Columns[2], 0);
            ((GridView)sender).SetRowCellValue(e.RowHandle, ((GridView)sender).Columns[3], 0);
            ((GridView)sender).SetRowCellValue(e.RowHandle, ((GridView)sender).Columns[4], 0);
        }


        private void gridView_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Seguro quieres eliminar este Producto?", "Eliminar Producto?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = Convert.ToInt32(((GridView)sender).GetRowCellValue(e.RowHandle, ((GridView)sender).Columns[0]).ToString());

                    if (db.DeleteData(id, DBHelper.TABLE_PRODUCTOS) > 0)
                    {

                        XtraMessageBox.Show("Producto eliminado con exito");
                    }
                    else
                    {

                        XtraMessageBox.Show("Ocurrio un error al eliminar los datos");
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error : " + ex.Message);
            }
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            String Caption = e.Button.Properties.Caption;
            switch (Caption)
            {
                case "Print":
                    gridView1.ShowRibbonPrintPreview();
                    break;
                default:
                    break;
            }
        }

        private void Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (db != null)
            {
                db.close();
            }
            this.DialogResult = DialogResult.OK;
        }

    }
}
