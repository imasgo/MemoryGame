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

        static Form1 lform = new Form1();
        //static LeaderBoardsForm lform1 = new LeaderBoardsForm();
        static LeaderList lform1 = new LeaderList();

        private void PlayButton_Click(object sender, EventArgs e)
        {
            //скрывает менюшку
            this.Hide();
            lform.Show();
            lform.Form1_Load(sender, e);
            
            //MenuLauncher.StartGame();
            //придумать как потом показывать ее обратно(Form.FormCLosing?)
            //this.Show(); 
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lform1.Show();
            //lform1.LeaderList_Load(sender,e);
            //this.Hide();
            //MenuLauncher.LeaderBoard();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //MenuLauncher.ExitG();
            this.Close();
            //Application.Exit();
           
           
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
    }
}
