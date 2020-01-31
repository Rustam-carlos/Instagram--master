namespace InstagramLight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "PhotoPath", c => c.String());
            DropColumn("dbo.Posts", "Path");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Path", c => c.String());
            DropColumn("dbo.Posts", "PhotoPath");
        }
    }
}
