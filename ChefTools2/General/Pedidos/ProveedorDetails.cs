using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChefTools.Data;
using DevExpress.XtraEditors;

namespace ChefTools.General.Pedidos
{
    public partial class ProveedorDetails : XtraUserControl
    {
        DBHelper database;
        private int id;

        public ProveedorDetails(DBHelper db, int id)
        {
            InitializeComponent();
            this.database = db;
            this.id = id;
        }

        private void displayWhitID(int id)
        {
            DataTable table = database.loadDataWithQuery("SELECT * FROM " + DBHelper.TABLE_PROVEEDORES + " WHERE tbl_Proveedores.id=" + id);
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
        private void ProveedorDetails_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            if (this.id > 0) {
                displayWhitID(this.id);
            }
        }
    }
}
