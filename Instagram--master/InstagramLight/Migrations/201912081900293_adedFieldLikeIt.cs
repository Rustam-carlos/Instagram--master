namespace InstagramLight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adedFieldLikeIt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "LikeIt", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "LikeIt");
        }
    }
}
