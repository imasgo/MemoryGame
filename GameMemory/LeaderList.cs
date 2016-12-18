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
            string line;
            List<Leader> LeadersDynamic = new List<Leader>();


            System.IO.StreamReader file =
               new System.IO.StreamReader(@"../../../DbDataGame.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {

                string[] newline = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                LeadersDynamic.Add(new Leader { Name = newline[1], Time = int.Parse(newline[0]) });

                
            }
            file.Close();
            var orderedlist = LeadersDynamic.OrderBy(x => x.Time);
            foreach (var item in orderedlist)
            {
                string str = "Name: " + item.Name + "Time:" + item.Time;
                listBox1.Items.Add(str);
            }


          
        }
    }
}
