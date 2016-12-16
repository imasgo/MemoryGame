namespace GameMemory
{
    partial class LeaderBoardsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leaderboardDataSet = new GameMemory.LeaderboardDataSet();
            this.leaderboardClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaderboardClassesTableAdapter = new GameMemory.LeaderboardDataSetTableAdapters.LeaderboardClassesTableAdapter();
            this.gamerRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamerScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardClassesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gamerRatingDataGridViewTextBoxColumn,
            this.gamerNameDataGridViewTextBoxColumn,
            this.gamerScoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leaderboardClassesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(193, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(618, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // leaderboardDataSet
            // 
            this.leaderboardDataSet.DataSetName = "LeaderboardDataSet";
            this.leaderboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaderboardClassesBindingSource
            // 
            this.leaderboardClassesBindingSource.DataMember = "LeaderboardClasses";
            this.leaderboardClassesBindingSource.DataSource = this.leaderboardDataSet;
            // 
            // leaderboardClassesTableAdapter
            // 
            this.leaderboardClassesTableAdapter.ClearBeforeFill = true;
            // 
            // gamerRatingDataGridViewTextBoxColumn
            // 
            this.gamerRatingDataGridViewTextBoxColumn.DataPropertyName = "GamerRating";
            this.gamerRatingDataGridViewTextBoxColumn.HeaderText = "GamerRating";
            this.gamerRatingDataGridViewTextBoxColumn.Name = "gamerRatingDataGridViewTextBoxColumn";
            // 
            // gamerNameDataGridViewTextBoxColumn
            // 
            this.gamerNameDataGridViewTextBoxColumn.DataPropertyName = "GamerName";
            this.gamerNameDataGridViewTextBoxColumn.HeaderText = "GamerName";
            this.gamerNameDataGridViewTextBoxColumn.Name = "gamerNameDataGridViewTextBoxColumn";
            // 
            // gamerScoreDataGridViewTextBoxColumn
            // 
            this.gamerScoreDataGridViewTextBoxColumn.DataPropertyName = "GamerScore";
            this.gamerScoreDataGridViewTextBoxColumn.HeaderText = "GamerScore";
            this.gamerScoreDataGridViewTextBoxColumn.Name = "gamerScoreDataGridViewTextBoxColumn";
            // 
            // LeaderBoardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 645);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LeaderBoardsForm";
            this.Text = "LeaderBoardsForm";
            this.Load += new System.EventHandler(this.LeaderBoardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardClassesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LeaderboardDataSet leaderboardDataSet;
        private System.Windows.Forms.BindingSource leaderboardClassesBindingSource;
        private LeaderboardDataSetTableAdapters.LeaderboardClassesTableAdapter leaderboardClassesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamerScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamerRatingDataGridViewTextBoxColumn;
    }
}