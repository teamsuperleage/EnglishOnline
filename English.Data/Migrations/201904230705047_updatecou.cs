namespace English.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecou : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lessons", "Url_Image", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Lessons", "Url_Video", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lessons", "Url_Video", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Lessons", "Url_Image", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
