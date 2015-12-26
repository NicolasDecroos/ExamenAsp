namespace Opdracht2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class competentions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competentions",
                c => new
                {
                    competention_id = c.Int(nullable: false, identity: true),
                    competention = c.String(),
                })
                .PrimaryKey(t => t.competention_id);

            CreateTable(
                "dbo.UserComp",
                c => new
                {
                    uc_id = c.Int(nullable: false, identity: true),
                    fk_user_id = c.Int(nullable: false),
                    fk_cometentions_id = c.Int(nullable: false),

                })
            .PrimaryKey(t => t.uc_id);
            AddForeignKey("dbo.UserComp", "fk_user_id", "dbo.Users", "user_id");
            AddForeignKey("dbo.UserComp", "fk_cometentions_id", "dbo.Competentions", "competention_id");
            //.ForeignKey("dbo.Users", t => t.fk_user_id, cascadeDelete: true)
            //.ForeignKey("dbo.Competentions", t => t.fk_cometentions_id, cascadeDelete: true)
            //.Index(t => t.fk_user_id)
            //.Index(t => t.fk_cometentions_id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.UserComp", "fk_user_id", "dbo.Users");
            DropForeignKey("dbo.UserComp", "fk_competention_id", "dbo.Competentions");
            DropIndex("dbo.UserComp", new[] { "fk_user_id" });
            DropIndex("dbo.UserComp", new[] { "fk_competention_id" });
            DropTable("dbo.Competentions");
            DropTable("dbo.UserComp");
        }
    }
}
