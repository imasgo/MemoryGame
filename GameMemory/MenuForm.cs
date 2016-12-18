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


        static LeaderList lform1 = new LeaderList();
        static HardLevel lform2 = new HardLevel();


        //playbutton click
        private void PlayButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            lform2.Show();            

        }

        //board button click
        private void BoardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lform1.Show();
            //MenuLauncher.LeaderBoard();
        }


        //exit button it really works
        private void ExitButton_Click(object sender, EventArgs e)
        {

            this.Close();

        }


        //exiting after X
        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
;
        }
    }
}
