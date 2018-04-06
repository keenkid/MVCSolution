namespace MySimpleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "JoiningDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "JoiningDate", c => c.String(maxLength: 10));
        }
    }
}
