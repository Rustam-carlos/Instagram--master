namespace InstagramLight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adedFieldIsLike : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "IsLike", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "IsLike");
        }
    }
}
