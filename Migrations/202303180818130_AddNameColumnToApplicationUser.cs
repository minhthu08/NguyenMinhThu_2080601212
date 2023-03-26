namespace NguyenMinhThu_2080601212.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Courses", "DataTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DataTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "Name");
            DropColumn("dbo.Courses", "DateTime");
        }
    }
}
