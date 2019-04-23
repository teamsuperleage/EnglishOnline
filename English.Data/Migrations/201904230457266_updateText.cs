namespace English.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Id_Text", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Texts", "Id_Course", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Texts", "Courses_ID", c => c.String(maxLength: 50));
            CreateIndex("dbo.Texts", "Courses_ID");
            AddForeignKey("dbo.Texts", "Courses_ID", "dbo.Courses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Texts", "Courses_ID", "dbo.Courses");
            DropIndex("dbo.Texts", new[] { "Courses_ID" });
            DropColumn("dbo.Texts", "Courses_ID");
            DropColumn("dbo.Texts", "Id_Course");
            DropColumn("dbo.Courses", "Id_Text");
        }
    }
}
