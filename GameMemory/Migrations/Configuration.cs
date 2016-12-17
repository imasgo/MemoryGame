namespace GameMemory.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameMemory.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GameMemory.Context";
        }

        protected override void Seed(GameMemory.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            // 
            string line;
            
            System.IO.StreamReader file =
               new System.IO.StreamReader(@"C:/Users/Мария/Documents/Visual Studio 2015/Projects/GameMemory/DbDataGame.txt", System.Text.Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                string[] newline = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                context.Leaders.AddOrUpdate(c => c.GamerName, new LeaderboardClass { GamerName = newline[1], GamerRating = 1, GamerScore = newline[0] });

            }
            file.Close();


        }
    }
}
