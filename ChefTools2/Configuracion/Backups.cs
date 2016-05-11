using ChefTools.Data;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChefTools
{
    public partial class Backups : XtraForm
    {
        public Backups()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            DXPopupMenu menu = new DXPopupMenu();
            EventHandler handler = new EventHandler(ItemClick);
            DXMenuItem item1 = new DXMenuItem("Nueva Copia", handler);
            item1.Image = imageCollection1.Images[0];
            DXMenuItem item2 = new DXMenuItem("Eliminar Copia", handler);
            item2.Image = imageCollection1.Images[1];
            DXMenuItem item3 = new DXMenuItem("Restaurar Copia", handler);
            item3.Image = imageCollection1.Images[2];
            menu.Items.Add(item1);
            menu.Items.Add(item2);
            menu.Items.Add(item3);
            dropDownButton1.DropDownControl = getmenu();
            spinEdit1.Value = Properties.Settings.Default.MaxBackups;
            loadBackups();
        }

        void ItemClick(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            switch (item.Caption)
            {
                case "Nueva Copia":
                    createBackup();

                    break;
                case "Eliminar Copia":

                    if (ListBoxBackups.SelectedItems.Count > 0)
                    {
                        if (XtraMessageBox.Show("", "Seguro quieres eliminar las copias selccionadas?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {

                            foreach (var it in ListBoxBackups.SelectedItems)
                            {
                                string filepath = ((ImageListBoxItem)it).Value.ToString();
                                deleteBackup(filepath);
                            }
                            
                            loadBackups();
                        }
                    }
                    break;
                case "Restaurar Copia":

                    if (ListBoxBackups.SelectedItems.Count > 0)
                    {
                        string filepath = (ListBoxBackups.SelectedItems[0] as ImageListBoxItem).Value.ToString();
                        restoreBackup(filepath);

                    }
                    break;
                default:
                    break;
            }
        }
        private DXPopupMenu getmenu(){
            DXPopupMenu menu=new DXPopupMenu();
            try {
                
                EventHandler handler = new EventHandler(ItemClick);
                DXMenuItem item1 = new DXMenuItem("Nueva Copia", handler);
                item1.Image = imageCollection1.Images[0];
                DXMenuItem item2 = new DXMenuItem("Eliminar Copia", handler);
                item2.Image = imageCollection1.Images[1];
                DXMenuItem item3 = new DXMenuItem("Restaurar Copia", handler);
                item3.Image = imageCollection1.Images[2];
                menu.Items.Add(item1);
                menu.Items.Add(item2);
                menu.Items.Add(item3);
                
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            return menu;
            
        }

        private void loadBackups()
        {
            try
            {
                ListBoxBackups.Items.Clear();
                DirectoryInfo diTop = new DirectoryInfo(GlobalUttilities.BACKUPS_PATH);

                foreach (var file in diTop.EnumerateFiles())
                {
                    FileAttributes fa = File.GetAttributes(file.FullName);
                    if (fa.HasFlag(FileAttributes.Directory))
                    {
                        //is directory
                    }
                    else
                    {

                        ImageListBoxItem item = new ImageListBoxItem(file.FullName, "Copia de seguridad creada el : " + file.CreationTime, 3, file.Name);
                        ListBoxBackups.Items.Add(item);
                    }

                }
            }
            catch (Exception e)
            {

                XtraMessageBox.Show(e.Message);
            }

        }

        private void restoreBackup(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    if (XtraMessageBox.Show("Seguro quieres restaurar esta copia de seguridad?" + Environment.NewLine + "Guarde una copia de los datos actuales si quiere consevarlos", "Restaurar Copia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        File.Copy(filepath, DBHelper.DATABASE_NAME, true);
                        XtraMessageBox.Show("Ok , Copia restaurada con exito!"+Environment.NewLine+"Es necesario reiniciar las pagina spara ver los cambios");
                    }

                }

            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }

        }
        private void deleteBackup(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {

                    File.Delete(filepath);
                    
                }

            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }


        }

        private void createBackup()
        {
            try
            {
                if (checkMaxBackups())
                {

                    XtraMessageBox.Show("Has superado el número maximo de copias establecido" + Environment.NewLine + "Elimina alguna o cambia la configuración");
                    return;
                }
                DateTime dat = DateTime.Now;
                String newFile = Path.Combine(GlobalUttilities.BACKUPS_PATH, dat.ToString("dd_MM_yyy_hh_mm_ss") + "_" + DBHelper.DATABASE_NAME);

                File.Copy(DBHelper.DATABASE_NAME, newFile, true);
                if (File.Exists(newFile))
                {
                    loadBackups();
                }

            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }


        }
        private bool checkMaxBackups()
        {
            bool ret = false;
            if (ListBoxBackups.Items.Count >= Properties.Settings.Default.MaxBackups)
            {
                ret = true;
            }
            return ret;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(GlobalUttilities.BACKUPS_PATH))
            {

                Process.Start(GlobalUttilities.BACKUPS_PATH);
            }
        }


        private void spinEdit1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MaxBackups = Convert.ToInt32(spinEdit1.Value);
            Debug.WriteLine(spinEdit1.Value.ToString());
            Properties.Settings.Default.Save();
            Debug.WriteLine(Properties.Settings.Default.MaxBackups);
        }

        private void ListBoxBackups_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    int itemIndex = ListBoxBackups.IndexFromPoint(e.Location);
                    ListBoxBackups.SelectedIndex = itemIndex;
                    MenuManagerHelper.ShowMenu(getmenu(), ListBoxBackups.LookAndFeel, null, ListBoxBackups, ListBoxBackups.PointToClient(MousePosition));
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex.Message);
                }
                
            }
        }
    }


}
