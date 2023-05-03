namespace CelilCavus.cryptop.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreated2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "Description", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "Description", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
