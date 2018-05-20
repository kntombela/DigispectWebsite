namespace DigispectWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lead",
                c => new
                    {
                        LeadID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LeadID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lead");
        }
    }
}
