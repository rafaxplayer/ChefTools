using System;
using System.Windows.Forms;
using System.Data.SQLite;
using DevExpress.XtraEditors;
using ChefTools.Data;

namespace ChefTools
{
    public partial class DialogoNewProveedor : UserControl
    {
        DBHelper database;
        private int id;
        public DialogoNewProveedor(DBHelper db, int id)
        {
            InitializeComponent();
            this.database = db;
            this.id = id;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text.ToString()))
            {
                XtraMessageBox.Show("Debes Introducir el nombre de tu proveedor");
            }
            else
            {
                if (!(this.id > 0))
                {

                    if (database.checkIfDataExists(DBHelper.TABLE_PROVEEDORES, DBHelper.NAME, textBoxName.Text.ToString()))
                    {
                        XtraMessageBox.Show("Este nombre ya esta en uso , utiliza otro");
                        textBoxName.Text = "";
                        return;
                    }
                }
                if (textEmail.Text.Length > 0) {
                    if (!(GlobalUttilities.emailValidate(textEmail.Text.ToString())))
                    {
                        XtraMessageBox.Show("Formato de Email Invalido, Intentalo de nuevo");
                        textEmail.Text = "";
                        return;
                    }
                }
                
                int ret = database.saveOrUpdateProveedor(this.id, textBoxName.Text.ToString(), textTelefono.Text.ToString(), textEmail.Text.ToString(), textBoxDireccion.Text.ToString(), textCategoria.Text.ToString(), textBoxComentario.Text.ToString());


                if (ret > 0)
                {
                    if (this.id > 0)
                    {
                        XtraMessageBox.Show("OK Proveedor Actualizada");
                        
                        this.FindForm().Close();
                        return;
                    }

                    var res = XtraMessageBox.Show("¿Deseas Crear otra entrada?", "OK Proveedor guardado", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        refresh();
                    }
                    else
                    {

                        this.FindForm().Close();

                    }
                                        

                }

            }
        }

        private void displayWithID(int id)
        {
            
            SQLiteDataReader reader = database.loadDataWithID(DBHelper.TABLE_PROVEEDORES, id);
            if (reader != null)
            {
                while (reader.Read())
                {
                    textBoxName.Text = reader["name"].ToString();
                    textTelefono.Text = reader["prov_telefono"].ToString();
                    textEmail.Text = reader["prov_email"].ToString();
                    textBoxDireccion.Text = reader["prov_direccion"].ToString();
                    textBoxComentario.Text = reader["comentario"].ToString();
                    textCategoria.Text = reader["prov_categoria"].ToString();
                }
                reader.Close();
                reader.Dispose();

            }

        }
        private void refresh()
        {
            textBoxName.Text = "";
            textTelefono.Text = "";
            textEmail.Text = "";
            textBoxDireccion.Text = "";
            textBoxComentario.Text = "";
            textCategoria.Text = "";

        }

        private void DialogoNewProveedor_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            if (this.id > 0)
            {
                displayWithID(this.id);
            }

        }


    }
}
