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
    public partial class LeaderList : Form
    {
        MenuForm lform = new MenuForm();
        public LeaderList()
        {
            InitializeComponent();
        }

        private void LeaderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
            e.Cancel = true;
            lform.Show();
        }

        public void LeaderList_Load(object sender, EventArgs e)
        {
           listBox1.Refresh();
        }
    }
}
