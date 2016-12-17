namespace GameMemory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeaderboardClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GamerRating = c.Int(nullable: false),
                        GamerName = c.String(),
                        GamerScore = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LeaderboardClasses");
        }
    }
}
