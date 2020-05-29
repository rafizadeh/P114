namespace _22052020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorSocialEdited : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "Facebook", c => c.String(maxLength: 100));
            AlterColumn("dbo.Doctors", "Linkedin", c => c.String(maxLength: 100));
            AlterColumn("dbo.Doctors", "Speciality", c => c.String(maxLength: 200));
            AlterColumn("dbo.Doctors", "ExpertIn", c => c.String(maxLength: 200));
            AlterColumn("dbo.Doctors", "Degree", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Doctors", "Degree", c => c.String());
            AlterColumn("dbo.Doctors", "ExpertIn", c => c.String());
            AlterColumn("dbo.Doctors", "Speciality", c => c.String());
            AlterColumn("dbo.Doctors", "Linkedin", c => c.String());
            AlterColumn("dbo.Doctors", "Facebook", c => c.String());
        }
    }
}
