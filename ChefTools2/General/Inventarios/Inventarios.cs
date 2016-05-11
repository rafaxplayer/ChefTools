using ChefTools.Informes;
using ChefTools.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ChefTools
{
    public partial class Inventarios : XtraForm
    {
        private DBHelper db;
        private int id;
        private DataTable currentInventario;

        public Inventarios()
        {
            InitializeComponent();
            db = new DBHelper();
            id = 0;
            LoadInventarios();
        }

        private void buttonNewInventario_Click(object sender, EventArgs e)
        {
            DialogBase dlg = new DialogBase(db, 0, GlobalUttilities.DIALOGO_NEW_INVENTARIO);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadInventarios();
            }
        }

        private void LoadInventarios()
        {
            gridControl1.BeginUpdate();
            try
            {
                DataTable tbInventarios = db.loadDataWhithTable(DBHelper.TABLE_INVENTARIOS);
                if (tbInventarios != null)
                {
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = tbInventarios;
                    groupInventarios.Text = tbInventarios.Rows.Count > 0 ? "Lista de Inventarios" : "Lista de Inventarios (No hay Inventarios)";
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

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            String str = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns[0]);
            String name = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns[1]);
            this.id = Convert.ToInt32(str);

            displayWithID(this.id, name);
        }

        private void displayWithID(int id, String name)
        {

            gridControlInventario.BeginUpdate();

            try
            {

                gridControlInventario.DataSource = null;
                DataTable dt = db.loadDataWithQuery("SELECT tbl_Inventarios_listas.inventario_id, tbl_Inventarios_listas.producto_id, tbl_Inventarios_listas.Producto_cantidad, tbl_Inventarios_listas.product_formato_id, tbl_Productos.name AS productoname, tbl_Productos_formato.name AS formatoname FROM "
                    + DBHelper.TABLE_INVENTARIOS_LISTAS
                    + " INNER JOIN " + DBHelper.TABLE_PRODUCTOS
                    + " ON tbl_Inventarios_listas.producto_id = tbl_Productos.id"
                    + " INNER JOIN " + DBHelper.TABLE_PRODUCTOS_FORMATO
                    + " ON tbl_Productos_formato.id = tbl_Inventarios_listas.product_formato_id"
                    + " WHERE tbl_Inventarios_listas.inventario_id = " + id);

                gridControlInventario.DataSource = dt;
                gridView4.GroupPanelText = name;
                this.currentInventario = dt;

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

        private void groupBoxDetalle_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            String Caption = e.Button.Properties.Caption;
            switch (Caption)
            {
                case "Edit":
                    if (this.id > 0)
                    {
                        DialogBase dlg = new DialogBase(db, this.id, GlobalUttilities.DIALOGO_NEW_INVENTARIO);

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            LoadInventarios();
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("No has seleccionado niguna inventario");
                    }
                    break;
                case "Delete":
                    if (gridView1.GetSelectedRows().Length > 0)
                    {

                        if (XtraMessageBox.Show("Seguro quieres eliminar este inventario?", "Eliminar " + gridView4.GroupPanelText, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            int index = Convert.ToInt32(gridView1.GetRowCellDisplayText(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
                            if (db.DeleteData(index, DBHelper.TABLE_INVENTARIOS) > 0)
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
                    if (this.id > 0 && currentInventario.Rows.Count>0)
                    {
                        XtraReportInv report = new XtraReportInv(this.db, this.id);
                        ReportPrintTool tool = new ReportPrintTool(report);
                        tool.ShowRibbonPreview();


                    }
                    else
                    {
                        XtraMessageBox.Show("No has seleccionado nigun inventario para Imprimir\r\n o no hay articulos en el.");
                    }
                    break;
                default:
                    break;

            }
        }

        private void Inventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (db != null) {
                db.close();
            }
        }



    }
}
