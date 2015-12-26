namespace Opdracht2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class users : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        password = c.String(),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.user_id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
