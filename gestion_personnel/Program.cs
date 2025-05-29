using System;
using System.Windows.Forms;

namespace gestion_personnel
{
    /// <summary>
    ///  Point d'entrée principal de l'application.
    /// </summary>
    internal class NamespaceDoc
    {

    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new view.FrmAuthentification());
        }
    }
}