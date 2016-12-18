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
    public partial class Username : Form
    {
        public Username()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exception fix
            if (textBox1.Text != "")
            {
                MenuForm lform = new MenuForm();
                this.Hide();
                lform.Show();
                //writing name to file
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:/Users/Мария/Documents/Visual Studio 2015/Projects/GameMemory/DbDataGame.txt", true))
                {

                    file.WriteLine(textBox1.Text);

                }
            }
            else
            {

                MessageBox.Show("Введите имя!");
            }

        }


        public void Username_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";

           
        }

        //closing and going back to menu
        private void Username_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm lform = new MenuForm();
            this.Hide();
            lform.Show();
        }
    }
}
