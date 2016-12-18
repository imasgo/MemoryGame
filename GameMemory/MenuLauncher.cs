using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMemory
{
    class MenuLauncher
    {
        //static Form1 lform = new Form1();
        
        static LeaderList lform2= new LeaderList();

        //static MenuForm lform2 = new MenuForm();  

        public static void StartGame()
        {
 
            
        }

        public static void LeaderBoard()
        {
            //lform2.Activate();
            lform2.Show();
        }
        public static void ExitG()
        {
            //Application.Exit();
        }
    }
}
