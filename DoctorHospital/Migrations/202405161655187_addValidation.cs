namespace DoctorHospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "name", c => c.String());
        }
    }
}
