namespace _22052020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentDescriptionEdited : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Description", c => c.String(nullable: false, maxLength: 800));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Description", c => c.String(nullable: false, maxLength: 150));
        }
    }
}
