using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMemory
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }



        private void PlayButton_Click(object sender, EventArgs e)
        {
            //скрывает менюшку
            this.Hide();

            MenuLauncher.StartGame();
            //придумать как потом показывать ее обратно(Form.FormCLosing?)
            //this.Show(); 
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuLauncher.LeaderBoard();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
           this.Close();
           //Application.Exit();
           MenuLauncher.ExitG();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
