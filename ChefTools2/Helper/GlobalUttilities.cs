using ChefTools.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;

namespace ChefTools
{
    public class GlobalUttilities
    {
        public const int DIALOGO_NEW_MENU = 4573;
        public const int DIALOGO_NEW_RECIPE = 4574;
        public const int DIALOGO_NEW_INVENTARIO = 4575;
        public const int DIALOGO_NEW_PROVEEDOR = 4576;
        public const int DIALOGO_NEW_PEDIDO = 4577;
        public const int DIALOGO_PROVEEDOR_DETALLE = 4578;
        public const int DIALOGO_PROVEEDOR_PRODUCTOS = 4579;
        public const int DIALOGO_ABOUT = 4580;
        public static string BACKUPS_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ChefTools");

        public static string UppercaseFirst(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public static void checkBackupsFolder()
        {
            try
            {
                if (Directory.Exists(BACKUPS_PATH))
                {
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(BACKUPS_PATH);
                Debug.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(BACKUPS_PATH));
            }
            catch (Exception e)
            {

                Debug.WriteLine(e.Message);
            }

        }
        
        public static bool emailValidate(String email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }



}
