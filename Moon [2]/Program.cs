using System;
using System.Windows.Forms;

namespace Moon__2_
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Player player;

            if (args != null && args.Length > 0)
            {
                player = new Player(args[0]);
            }
            else
            {
                player = new Player();
            }

            Application.Run(new Player());


        }
    }
}
