using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace DungeonVandal
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
      //  [STAThread]
        static void Main()
        {
           // MenuForm new_menu = new MenuForm();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
            
          //  new_menu.Show();
          //  Game.Game game = new Game.Game(new_menu);
          //  game.Run();
            
        }
    }
}
