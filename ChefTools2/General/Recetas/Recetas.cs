
using ChefTools.Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraReports.UI;
using ChefTools;
using System.Net;
using System.IO;
using ChefTools.Informes;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
namespace ChefTools
{
    public partial class Recetas : XtraForm
    {
        DBHelper db;
        int id;
        DataTable currentRecipe;
        public Recetas()
        {
            InitializeComponent();
            id = 0;
            db = new DBHelper();
            LoadRecipesData();

            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            tableLayoutPanel1.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }

        private void buttonNewRecipe_Click(object sender, EventArgs e)
        {

            DialogBase dlg = new DialogBase(db, 0, GlobalUttilities.DIALOGO_NEW_RECIPE);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadRecipesData();

            }
        }

        private void LoadRecipesData()
        {
            gridControl1.BeginUpdate();

            try
            {


                String sQuery = "SELECT tbl_Recetas.id , tbl_Recetas.name, tbl_Recetas.img, tbl_Recetas_categoria.name AS categorianame FROM " + DBHelper.TABLE_RECETAS
                    + " INNER JOIN " + DBHelper.TABLE_RECETAS_CATEGORIA
                    + " ON tbl_Recetas.categoria_id = tbl_Recetas_categoria.id";
                DataTable recipes = db.loadDataWithQuery(sQuery);
                if (recipes != null) {
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = recipes;
                    groupRecetas.Text = recipes.Rows.Count > 0 ? "Lista de recetas" : "Lista de recetas (No hay recetas)";
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

        private void displayWhitID(int id)
        {
            DataTable table = db.loadDataWithQuery("SELECT tbl_Recetas.id , tbl_Recetas.name, tbl_Recetas.img, tbl_Recetas.ingredientes ,tbl_Recetas.elaboracion, tbl_Recetas.url, tbl_Recetas.categoria_id, tbl_Recetas_categoria.name AS categorianame FROM " + DBHelper.TABLE_RECETAS
                + " INNER JOIN " + DBHelper.TABLE_RECETAS_CATEGORIA
                + " ON tbl_Recetas.categoria_id = tbl_Recetas_categoria.id"
                + " WHERE tbl_Recetas.id=" + id);
            if (table != null)
            {
                DataRow row = table.Rows[0];

                if (row["img"].Equals("NULL"))
                {
                    pictureRecipe.Image = ChefTools.Properties.Resources.recipe_placeholder;

                }
                else
                {
                    if (!File.Exists(row["img"].ToString()))
                    {

                        if (row["img"].ToString().Contains("http"))
                        {
                            pictureRecipe.LoadAsync(row["img"].ToString());

                        }
                        else
                        {
                            pictureRecipe.Image = ChefTools.Properties.Resources.recipe_placeholder;
                        }
                    }

                    else
                    {
                        pictureRecipe.LoadAsync(row["img"].ToString());
                    }

                }

                labelRecipeName.Text = row["name"].ToString();
                labelCategoria.Text = db.getDataString(DBHelper.TABLE_RECETAS_CATEGORIA, DBHelper.NAME, Convert.ToInt32(row["categoria_id"]));
                labelIngredientes.Text = row["ingredientes"].ToString();
                labelElaboracion.Text = row["elaboracion"].ToString();
                labelTitleUrl.Visible = row["url"].ToString().Length > 0 ? true : false;
                labelUrl.Text = row["url"].ToString();

                this.currentRecipe = table;
                this.id = id;
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
                        DialogBase dlg = new DialogBase(db, this.id, GlobalUttilities.DIALOGO_NEW_RECIPE);

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            LoadRecipesData();
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("No has seleccionado niguna receta para Imprimir");
                    }
                    break;
                case "Delete":

                    if (gridView1.GetSelectedRows().Length > 0)
                    {

                        if (MessageBox.Show("Seguro quieres eliminar esta receta?", "Eliminar " + labelRecipeName.Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            int index = Convert.ToInt32(gridView1.GetRowCellDisplayText(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
                            if (db.DeleteData(index, DBHelper.TABLE_RECETAS) > 0)
                            {

                                LoadRecipesData();
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

                        XtraReportRecipes report = new XtraReportRecipes();
                        report.DataSource = this.currentRecipe;

                        ReportPrintTool tool = new ReportPrintTool(report);
                        tool.ShowPreview();
                    }
                    else
                    {
                        XtraMessageBox.Show("No has seleccionado niguna receta para Imprimir");
                    }
                    break;
                default:
                    break;

            }
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            String str = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns[0]);
            if (str != null)
                displayWhitID(Convert.ToInt32(str));
        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.id > 0)
            {
                DialogBase dlg = new DialogBase(db, this.id, GlobalUttilities.DIALOGO_NEW_RECIPE);

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadRecipesData();
                }

            }
        }

        private void Recetas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (db != null)
            {
                db.close();
            }
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.Caption == "Imagen")
            {
                try
                {

                    DataRow ro = (gridControl1.DataSource as DataTable).Rows[e.ListSourceRowIndex];
                    String url = ro["img"].ToString();

                    if (url.Contains("NULL"))
                    {

                        e.Value = ChefTools.Properties.Resources.recipe_placeholder;
                        return;
                    }


                    if (url.Contains("http"))
                    {
                        try
                        {
                            var request = WebRequest.Create(url);
                            using (var response = request.GetResponse())
                            {
                                using (var stream = response.GetResponseStream())
                                {

                                    e.Value = Bitmap.FromStream(stream);

                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                            e.Value = ChefTools.Properties.Resources.recipe_placeholder;
                        }


                    }
                    else
                    {
                        if (!File.Exists(url))
                        {

                            e.Value = ChefTools.Properties.Resources.recipe_placeholder;
                            return;
                        }
                        e.Value = Bitmap.FromFile(url);
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }


            }
        }

        private void labelUrl_Click(object sender, EventArgs e)
        {
            try
            {
                String url = ((Label)sender).Text.ToString();
                Process.Start(url);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error :" + ex.Message);
            }
        }


    }
}
