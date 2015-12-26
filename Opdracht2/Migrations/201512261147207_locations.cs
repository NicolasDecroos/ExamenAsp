namespace Opdracht2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                {
                    location_id = c.Int(nullable: false, identity: true),
                    location_name = c.String(),
                })
            .PrimaryKey(t => t.location_id);

            CreateTable(
                "dbo.UserLoc",
                c => new
                {
                    ul_id = c.Int(nullable: false, identity: true),
                    fk_user_id = c.Int(nullable: false),
                    fk_location_id = c.Int(nullable: false),

                })
            .PrimaryKey(t => t.ul_id);
            AddForeignKey("dbo.UserLoc", "fk_user_id", "dbo.Users", "user_id");
            AddForeignKey("dbo.UserLoc", "fk_location_id", "dbo.Locations", "location_id");
            //.ForeignKey("dbo.Users", t => t.fk_user_id, cascadeDelete: true)
            //.ForeignKey("dbo.Locations", t => t.fk_location_id, cascadeDelete: true)
            //.Index(t => t.fk_user_id)
            //.Index(t => t.fk_location_id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserLoc", "fk_user_id", "dbo.Users");
            DropForeignKey("dbo.UserLoc", "fk_location_id", "dbo.Locations");
            DropIndex("dbo.UserLoc", new[] { "fk_user_id" });
            DropIndex("dbo.UserLoc", new[] { "fk_location_id" });
            DropTable("dbo.Locations");
            DropTable("dbo.UserLoc");
        }
    }
}
