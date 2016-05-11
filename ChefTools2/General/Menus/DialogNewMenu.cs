using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChefTools.Data;
using System.Data.SQLite;

namespace ChefTools
{
    public partial class DialogNewMenu : UserControl
    {
        private DBHelper db;

        private int id;
        public DialogNewMenu(DBHelper dbase, int id)
        {
            InitializeComponent();
            this.db = dbase;

            this.id = id;
        }

        private void refresh()
        {
            textBoxName.Text = "";
            textBoxEntrantes.Text = "";
            textBoxPrimeros.Text = "";
            textBoxSegundos.Text = "";
            textBoxPostres.Text = "";

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text.ToString();
            //comprobar si esta vacio el campo nombre
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Introduce un nombre para tu menú", "Error");
                return;
            }

            name = GlobalUttilities.UppercaseFirst(name);
            // comprobar si es nueva y no existe ese nombre en la bd
            if (!(this.id > 0))
            {
                if (db.checkIfDataExists(DBHelper.TABLE_MENUSCARTAS, DBHelper.NAME, name))
                {
                    textBoxName.Text = "";
                    MessageBox.Show("El nombre del menú ya existe, Modificala o intruduce otro nombre", "Error");
                    return;
                }
            }


            String entrantes = textBoxEntrantes.Text.ToString();
            String primeros = textBoxPrimeros.Text.ToString();
            String segundos = textBoxSegundos.Text.ToString();
            String postres = textBoxPostres.Text.ToString();
            String comment = textBoxComment.Text.ToString();

            //save or update recipe....
            int ret = db.saveOrUpdateMenus(this.id, name, entrantes, primeros, segundos, postres, comment);
            if (ret > 0)
            {
                if (this.id > 0)
                {
                    MessageBox.Show("OK menú Actualizado");
                    ParentForm.DialogResult = DialogResult.OK;
                    this.FindForm().Close();
                    return;
                }

                var res = MessageBox.Show("¿Deseas Crear otro menú?", "OK receta guardada", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    refresh();
                }
                else
                {

                    this.FindForm().Close();

                }

            }
            else
            {
                MessageBox.Show("No se guardo el menú", "Error");
            }

        }


        private void dialog_new_menu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            if (this.id > 0)
            {
                displayWhitID(id);
            }
        }

        private void displayWhitID(int id)
        {

            DataTable table = db.loadDataWithQuery("SELECT * FROM " + DBHelper.TABLE_MENUSCARTAS
                + " WHERE tbl_Menus_Cartas.id=" + id);

            if (table.Rows.Count > 0)
            {

                DataRow row = table.Rows[0];
                textBoxName.Text = row["name"].ToString();
                textBoxEntrantes.Text = row["mc_entrantes"].ToString();
                textBoxPrimeros.Text = row["mc_primeros"].ToString();
                textBoxSegundos.Text = row["mc_segundos"].ToString();
                textBoxPostres.Text = row["mc_postres"].ToString();


            }
        }
    }
}
