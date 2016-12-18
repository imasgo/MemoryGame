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
            this.leaderboardClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaderboardDataSet = new GameMemory.LeaderboardDataSet();
            this.leaderboardClassesTableAdapter = new GameMemory.LeaderboardDataSetTableAdapters.LeaderboardClassesTableAdapter();
            this.leaderboardClassesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamerRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardClassesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gamerNameDataGridViewTextBoxColumn,
            this.GamerRating});
            this.dataGridView1.DataSource = this.leaderboardClassesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 645);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // leaderboardClassesBindingSource
            // 
            this.leaderboardClassesBindingSource.DataMember = "LeaderboardClasses";
            this.leaderboardClassesBindingSource.DataSource = this.leaderboardDataSet;
            this.leaderboardClassesBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.leaderboardClassesBindingSource_AddingNew);
            // 
            // leaderboardDataSet
            // 
            this.leaderboardDataSet.DataSetName = "LeaderboardDataSet";
            this.leaderboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaderboardClassesTableAdapter
            // 
            this.leaderboardClassesTableAdapter.ClearBeforeFill = true;
            // 
            // leaderboardClassesBindingSource1
            // 
            this.leaderboardClassesBindingSource1.DataMember = "LeaderboardClasses";
            this.leaderboardClassesBindingSource1.DataSource = this.leaderboardDataSet;
            // 
            // gamerNameDataGridViewTextBoxColumn
            // 
            this.gamerNameDataGridViewTextBoxColumn.DataPropertyName = "GamerName";
            this.gamerNameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.gamerNameDataGridViewTextBoxColumn.Name = "gamerNameDataGridViewTextBoxColumn";
            // 
            // GamerRating
            // 
            this.GamerRating.DataPropertyName = "GamerRating";
            this.GamerRating.HeaderText = "GamerRating";
            this.GamerRating.Name = "GamerRating";
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
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardClassesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LeaderboardDataSet leaderboardDataSet;
        private System.Windows.Forms.BindingSource leaderboardClassesBindingSource;
        private LeaderboardDataSetTableAdapters.LeaderboardClassesTableAdapter leaderboardClassesTableAdapter;
        private System.Windows.Forms.BindingSource leaderboardClassesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamerRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamerNameDataGridViewTextBoxColumn;
    }
}