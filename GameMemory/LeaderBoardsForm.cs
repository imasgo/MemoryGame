using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMemory
{
    public partial class LeaderBoardsForm : Form
    {
        public LeaderBoardsForm()
        {
            InitializeComponent();
        }

        public void LeaderBoardsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "leaderboardDataSet.LeaderboardClasses". При необходимости она может быть перемещена или удалена.
            if (new FileInfo("C:/Users/Мария/Documents/Visual Studio 2015/Projects/GameMemory/Dbstring.txt").Length != 0)
            {
                string line;
                System.IO.StreamReader file =
              new System.IO.StreamReader(@"C:/Users/Мария/Documents/Visual Studio 2015/Projects/GameMemory/DbDataGame.txt", System.Text.Encoding.Default);
                while ((line = file.ReadLine()) != null)
                {
                    string[] newline = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    LeaderboardClass leader = new LeaderboardClass
                    {
                        GamerName = newline[1],
                        GamerRating = int.Parse(newline[0]),
                        GamerScore = "1"


                    };
                    
                }
                file.Close();
                //прописать логику вставления новой записи в дб
               
            }
            else
            {
                this.leaderboardClassesTableAdapter.Fill(this.leaderboardDataSet.LeaderboardClasses);
            }
            this.leaderboardDataSet.AcceptChanges();
            dataGridView1.Update();
            dataGridView1.Refresh();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void leaderboardClassesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.leaderboardClassesTableAdapter.Update(this.leaderboardDataSet);
        }
    }
}
