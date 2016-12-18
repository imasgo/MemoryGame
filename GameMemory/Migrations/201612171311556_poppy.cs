namespace GameMemory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poppy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LeaderboardClasses", "GamerTiming", c => c.Int(nullable: false));
            DropColumn("dbo.LeaderboardClasses", "GamerScore");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LeaderboardClasses", "GamerScore", c => c.String());
            DropColumn("dbo.LeaderboardClasses", "GamerTiming");
        }
    }
}
