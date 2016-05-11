
using ChefTools;
using ChefTools.Data;
using ChefTools.Informes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChefTools
{
    public partial class Menus : XtraForm
    {

        DBHelper db;
        int id;
        DataTable currentMenu;
        public Menus()
        {
            InitializeComponent();
            db = new DBHelper();
            id = 0;
            LoadMenus();

        }

        private void listMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listMenus.SelectedItems.Count > 0)
                {
                    ListViewItem item = listMenus.SelectedItems[0];
                    Debug.WriteLine(item.SubItems[3].Text);
                    displayWhitID(Convert.ToInt32(item.SubItems[3].Text));
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error :" + ex.Message);
            }

        }

        private void displayWhitID(int id)
        {
            DataTable table = db.loadDataWithQuery("SELECT * FROM " + DBHelper.TABLE_MENUSCARTAS + " WHERE tbl_Menus_Cartas.id=" + id);
            if (table.Rows.Count > 0)
            {

                DataRow row = table.Rows[0];

                labelNombre.Text = row["name"].ToString();
                labelEntrantes.Text = row["mc_entrantes"].ToString();
                labelPrimeros.Text = row["mc_primeros"].ToString();
                labelSegundos.Text = row["mc_segundos"].ToString();
                labelPostres.Text = row["mc_postres"].ToString();
                labelComments.Text = row["comentario"].ToString();

                currentMenu = table;
                this.id = id;
            }
        }

        private void buttonNewMenu_Click(object sender, EventArgs e)
        {
            //dialog_new_menu dlg = new dialog_new_menu(db, 0);
            DialogBase dlg = new DialogBase(db, 0, GlobalUttilities.DIALOGO_NEW_MENU);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadMenus();
            }
        }

        private void LoadMenus()
        {
            gridControl1.BeginUpdate();
            try
            {
                DataTable tbMenus = db.loadDataWhithTable(DBHelper.TABLE_MENUSCARTAS);
                if (tbMenus != null)
                {
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = tbMenus;
                    groupMenus.Text = tbMenus.Rows.Count > 0 ? "Lista de Menus" : "Lista de Menus (No hay Menus)";
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

            displayWhitID(Convert.ToInt32(str));
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.id > 0)
            {
                DialogBase dlg = new DialogBase(db, this.id, GlobalUttilities.DIALOGO_NEW_MENU);

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadMenus();
                }

            }
        }

        private void groupBox4_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            String Caption = e.Button.Properties.Caption;
            switch (Caption)
            {
                case "Edit":
                    if (this.id > 0)
                    {
                        DialogBase dlg = new DialogBase(db, this.id, GlobalUttilities.DIALOGO_NEW_MENU);

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            LoadMenus();
                        }

                    }
                    break;
                case "Delete":
                    if (gridView1.GetSelectedRows().Length > 0)
                    {

                        if (MessageBox.Show("Seguro quieres eliminar este Menu?", "Eliminar " + labelNombre.Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            int index = Convert.ToInt32(gridView1.GetRowCellDisplayText(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
                            if (db.DeleteData(index, DBHelper.TABLE_MENUSCARTAS) > 0)
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
                    if (this.id > 0)
                    {


                        XtraReportMenus report = new XtraReportMenus(currentMenu);
                        ReportPrintTool tool = new ReportPrintTool(report);
                        tool.ShowPreview();

                    }
                    else
                    {
                        XtraMessageBox.Show("No has seleccionado ningun menu para Imprimir");
                    }
                    break;
                default:
                    break;

            }
        }

        private void Menus_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (db != null)
            {
                db.close();
            }
        }

    }
}
