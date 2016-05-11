using ChefTools.Data;
using ChefTools.General.Proveedores;
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
    public partial class Proveedores : XtraForm
    {
        int id;
        DBHelper db;
        DataTable AllProveedores;
        public Proveedores()
        {
            InitializeComponent();
            db = new DBHelper();
            id = 0;

            LoadProviders();
           
        }

        private void displayWhitID(int id)
        {
            DataTable table = db.loadDataWithQuery("SELECT * FROM " + DBHelper.TABLE_PROVEEDORES + " WHERE tbl_Proveedores.id=" + id);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                labelNombre.Text = row["name"].ToString();
                labelTelefono.Text = row["prov_telefono"].ToString();
                labelEmail.Text = row["prov_email"].ToString();
                labelDireccion.Text = row["prov_direccion"].ToString();
                labelCategoria.Text = row["prov_categoria"].ToString();
                labelComments.Text = row["comentario"].ToString();
                this.id = id;

            }
        }


        private void LoadProviders()
        {
            gridControlProveedores.BeginUpdate();

            try
            {
                DataTable tbProveedores = db.loadDataWhithTable(DBHelper.TABLE_PROVEEDORES);
                if (tbProveedores != null)
                {
                    gridControlProveedores.DataSource = null;
                    gridControlProveedores.DataSource = tbProveedores;
                    this.AllProveedores = tbProveedores;
                    groupBox3.Text = tbProveedores.Rows.Count > 0 ? "Lista de Proveedores" : "Lista de Proveedores (No hay Proveedores)";
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            finally
            {

                gridControlProveedores.EndUpdate();

            }

        }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            String str = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns[0]);

            displayWhitID(Convert.ToInt32(str));
        }

        private void buttonNewProvvedor_Click(object sender, EventArgs e)
        {
            DialogBase dlg = new DialogBase(db, 0, GlobalUttilities.DIALOGO_NEW_PROVEEDOR);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadProviders();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.id > 0)
            {
                DialogBase dlg = new DialogBase(db, this.id, GlobalUttilities.DIALOGO_NEW_PROVEEDOR);

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadProviders();
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
                        DialogBase dlg = new DialogBase(db, this.id, GlobalUttilities.DIALOGO_NEW_PROVEEDOR);

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            LoadProviders();
                        }

                    }
                    break;
                case "Delete":
                    if (gridView1.GetSelectedRows().Length > 0)
                    {

                        if (MessageBox.Show("Seguro quieres eliminar este Proveedor?", "Eliminar " + labelNombre.Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            int idex = Convert.ToInt32(gridView1.GetRowCellDisplayText(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
                            if (db.DeleteData(idex, DBHelper.TABLE_PROVEEDORES) > 0)
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


                    if (this.AllProveedores != null)
                    {

                        XtraReportProveedores rep = new XtraReportProveedores(this.AllProveedores);
                        ReportPrintTool repPrint = new ReportPrintTool(rep);
                        repPrint.ShowRibbonPreview();
                    }
                    else
                    {

                        XtraMessageBox.Show("Ocurrio un error o no hay proveedores en tu base de datos.");
                    }

                    break;
                case "Productos":

                    if(this.id >0)
                    {
                        DialogBase dlg = new DialogBase(db, this.id, GlobalUttilities.DIALOGO_PROVEEDOR_PRODUCTOS);
                        dlg.ShowDialog();

                    }
                    break;
                default:
                    break;

            }
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {
            try {
                String email = ((LabelControl)sender).Text.ToString();
                if (GlobalUttilities.emailValidate(email))
                {
                           
                    Process.Start(string.Format("mailto:{0}", email));
                }
               
                
            }
            catch (Exception ex) {

                XtraMessageBox.Show("Error :"+ex.Message);
            }
        }

        private void Proveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (db != null)
            {
                db.close();
            }
            
        }

   

    }
}
