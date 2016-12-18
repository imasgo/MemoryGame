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
    public partial class HardLevel : Form
    {
        public HardLevel()
        {
            InitializeComponent();
        }

        //private string combodata;


        //public string Combodata
        //{
        //    get { return combodata; }
        //    set { combodata = value; }
        //}


        MenuForm lform = new MenuForm();
        public string ComboData { get; set; }
        //static Form1 lform = new Form1();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboData = comboBox1.Text;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Выберите значение!");
            }
            else
            {
                Form1 lform = new Form1(comboBox1.Text);
                //скрывает менюшку
                this.Hide();
                lform.Show();
                lform.Form1_Load(sender, e);
            }

        }

        public void HardLevel_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Hard");
            comboBox1.Items.Add("Medium");
            comboBox1.Items.Add("Easy");
        }

        private void HardLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            lform.Show();
        }
    }
}
