using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ChefTools.Data;
using System.Data.SQLite;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ChefTools
{
    public partial class Ajustes : XtraForm
    {

        DBHelper db;


        public Ajustes()
        {
            InitializeComponent();
            db = new DBHelper();

            iniGrids();

        }
        private void iniGrids()
        {
            DataTable tblcatRecetas = db.loadDataWhithTable(DBHelper.TABLE_RECETAS_CATEGORIA);
            DataTable tblcatProductos = db.loadDataWhithTable(DBHelper.TABLE_PRODUCTOS_CATEGORY);
            DataTable tblFormProductos = db.loadDataWhithTable(DBHelper.TABLE_PRODUCTOS_FORMATO);

            if (tblcatRecetas != null) { gridControlCatRecetas.DataSource = tblcatRecetas; }
            if (tblcatProductos != null) { gridControlCatProductos.DataSource = tblcatProductos; }
            if (tblFormProductos != null) { gridControlFormProductos.DataSource = tblFormProductos; }

        }


        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            ((GridView)sender).SetRowCellValue(e.RowHandle, ((GridView)sender).Columns[0], 0);


        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(((GridView)sender).GetRowCellValue(e.RowHandle, ((GridView)sender).Columns[0]).ToString());
                String name = ((GridView)sender).GetRowCellDisplayText(e.RowHandle, ((GridView)sender).Columns[1]).ToString();

                if (!String.IsNullOrEmpty(name))
                    if (db.saveOrUpdateAjustesTable(id, ((GridView)sender).Tag.ToString(), name.ToString()) > 0)
                    {

                        XtraMessageBox.Show("Ok , Datos Actualizados");

                    }
                    else
                    {

                        XtraMessageBox.Show("Error al insertar datos");
                    }

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void gridView_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Seguro quieres eliminar esta entrada?", "Eliminar Datos?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = Convert.ToInt32(((GridView)sender).GetRowCellValue(e.RowHandle, ((GridView)sender).Columns[0]).ToString());
                    if (db.DeleteData(id, ((GridView)sender).Tag.ToString()) > 0)
                    {
                        XtraMessageBox.Show("Datos eliminados con exito");
                    }
                    else
                    {

                        XtraMessageBox.Show("Ocurrio un error al eliminar los datos");
                    }
                }
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error : " + ex.Message);
            }
        }



    }
}
