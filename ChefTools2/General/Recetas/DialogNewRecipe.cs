using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using ChefTools.Data;
using DevExpress.Utils.Menu;
using System.Data.SQLite;
using ChefTools;
using System.Diagnostics;

namespace ChefTools
{
    public partial class DialogNewRecipe : XtraUserControl
    {
        private DBHelper db;
        private string urlimge = "NULL";
        private int id;
        private OpenFileDialog dialog;

        public DialogNewRecipe(DBHelper dbase, int id, OpenFileDialog dlg)
        {
            InitializeComponent();
            this.db = dbase;
            this.dialog = dlg;
            this.id = id;
            DXPopupMenu menu = new DXPopupMenu();
            EventHandler handler = new EventHandler(ItemClick);
            DXMenuItem item1 = new DXMenuItem("Desde Url", handler);
            item1.Image = imageCollection1.Images[1];
            DXMenuItem item2 = new DXMenuItem("Desde Archivo", handler);
            item2.Image = imageCollection1.Images[0];
            menu.Items.Add(item1);
            menu.Items.Add(item2);
            dropDownButton1.DropDownControl = menu;
        }

        private void DialogNewRecipe_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
           

            LoadComBoCategorias();

            if (this.id > 0)
            {
                displayWhitID(id);
            }
        }
        private void LoadComBoCategorias()
        {
            DataTable dt = db.loadDataWhithTable(DBHelper.TABLE_RECETAS_CATEGORIA);
            if (dt != null)
            {
                comboCategorias.DataSource = dt;
                comboCategorias.DisplayMember = DBHelper.NAME;
                comboCategorias.ValueMember = DBHelper.ID;
            }

        }

        private void loadImage(String uri)
        {
            try
            {
                pictureBox1.Load(uri);
                this.urlimge = uri;
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }

        private void refresh()
        {
            textRecipeName.Text = "";
            textIngredientes.Text = "";
            textElaboracion.Text = "";
            textRecipeUrl.Text = "";
            comboCategorias.SelectedIndex = 0;

        }

        private void displayWhitID(int id)
        {
            DataTable table = db.loadDataWithQuery("SELECT * FROM " + DBHelper.TABLE_RECETAS
                + " WHERE tbl_Recetas.id=" + id);

            if (table != null)
            {
                DataRow row = table.Rows[0];

                if (row["img"].ToString().Equals("NULL"))
                {
                    pictureBox1.Image = ChefTools.Properties.Resources.recipe_placeholder;
                    this.urlimge = "NULL";
                }
                else
                {
                    pictureBox1.LoadAsync(row["img"].ToString());
                    this.urlimge = row["img"].ToString();
                }

                textRecipeName.Text = row["name"].ToString();
                comboCategorias.SelectedValue = row["categoria_id"].ToString();
                textElaboracion.Text = row["elaboracion"].ToString();
                textIngredientes.Text = row["ingredientes"].ToString();
                textRecipeUrl.Text = row["url"].ToString();
            }



        }

        void ItemClick(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            switch (item.Caption)
            {
                case "Desde Url":
                    ImgUrlContent control = new ImgUrlContent();
                    if (XtraDialog.Show(control, "Imagen Desde Url") == DialogResult.OK)
                    {

                        if (!String.IsNullOrEmpty(control.textEditUrl.Text.ToString()))
                        {

                            loadImage(control.textEditUrl.Text.ToString());
                            this.urlimge = control.textEditUrl.Text.ToString();

                        }
                    }

                    break;
                case "Desde Archivo":

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {

                        loadImage(dialog.FileName);
                        this.urlimge = dialog.FileName;
                    }

                    break;
                default:
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String name = textRecipeName.Text.ToString();
            //comprobar si esta vacio el campo nombre
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Introduce un nombre para tu receta", "Error");
                return;
            }

            name = GlobalUttilities.UppercaseFirst(name);
            // comprobar si es nueva y no existe ese nombre en la bd
            if (!(this.id > 0))
            {
                if (db.checkIfDataExists(DBHelper.TABLE_RECETAS, DBHelper.NAME, name))
                {
                    textRecipeName.Text = "";
                    MessageBox.Show("El nombre de la receta ya existe, Modificala o intruduce otro nombre", "Error");
                    return;
                }
            }

            String img = this.urlimge;
            String ing = textIngredientes.Text.ToString();
            String ela = textElaboracion.Text.ToString();
            String url = textRecipeUrl.Text.ToString();
            int cat = Convert.ToInt32(comboCategorias.SelectedValue);


            //save or update recipe....
            int ret = db.saveOrUpdateRecipe(this.id, name, img, ing, ela, url, cat);
            if (ret > 0)
            {
                if (this.id > 0)
                {
                    XtraMessageBox.Show("OK receta Actualizada");

                    this.FindForm().Close();
                    return;
                }

                var res = XtraMessageBox.Show("¿Deseas Crear otra receta?", "OK receta guardada", MessageBoxButtons.YesNo);
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
                MessageBox.Show("No se guardo la receta", "Error");
            }
        }

        private void ButtonRecipeUrl_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/");
        }



    }
}
