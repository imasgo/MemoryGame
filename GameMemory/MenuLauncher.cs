﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMemory
{
    class MenuLauncher
    {
        static Form1 lform = new Form1();
        static LeaderBoardsForm lform2= new LeaderBoardsForm();
        //static MenuForm lform2 = new MenuForm();  

        public static void StartGame()
        {
            //для этого варика надо выносить меню в отдельные проект но можно и так
            //Process.Start("GameMemory.exe");
            lform.Show();
        }
        public static void LeaderBoard()
        {
            lform2.Show();
        }
        public static void ExitG()
        {

        }
    }
}
