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
    public partial class LeaderBoardsForm : Form
    {
        public LeaderBoardsForm()
        {
            InitializeComponent();
        }

        public void LeaderBoardsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "leaderboardDataSet.LeaderboardClasses". При необходимости она может быть перемещена или удалена.
            this.leaderboardClassesTableAdapter.Fill(this.leaderboardDataSet.LeaderboardClasses);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
