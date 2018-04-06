namespace MySimpleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(maxLength: 60));
            AlterColumn("dbo.Employees", "JoiningDate", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "JoiningDate", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
    }
}
