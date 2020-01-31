namespace InstagramLight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteFieldLikeItAndIsLike : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Posts", "IsLike");
            DropColumn("dbo.Posts", "LikeIt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "LikeIt", c => c.String());
            AddColumn("dbo.Posts", "IsLike", c => c.Boolean(nullable: false));
        }
    }
}
