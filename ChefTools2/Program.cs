using DevExpress.LookAndFeel;
using System;
using System.Windows.Forms;

namespace ChefTools
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            if (PrimeraInstancia)
            {
                Application.EnableVisualStyles();
                DevExpress.UserSkins.BonusSkins.Register();
                Application.SetCompatibleTextRenderingDefault(false);
                if (Properties.Settings.Default.SkinName != "") {
                    
                    UserLookAndFeel.Default.SkinName = Properties.Settings.Default.SkinName;
                }
                    
                Application.Run(new Inicio_Form());
            }
            else
            {
                MessageBox.Show("La aplicación ya se esta ejecutando");
                Application.Exit();
            }
        }

        private static bool PrimeraInstancia
        {
            get
            {
                System.Threading.Mutex exmut;
                String nombre_exmut = "ChefTools";
                bool nueva;
                exmut = new System.Threading.Mutex(true, nombre_exmut, out nueva);
                return nueva;
            }
        }
    }
}
