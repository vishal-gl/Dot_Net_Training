namespace Practise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customs",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(),
                        Caddress = c.String(),
                        Prods_Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cid)
                .ForeignKey("dbo.Prods", t => t.Prods_Pid, cascadeDelete: true)
                .Index(t => t.Prods_Pid);
            
            CreateTable(
                "dbo.Prods",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Pname = c.String(),
                        Price = c.Int(nullable: false),
                        Purchase = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customs", "Prods_Pid", "dbo.Prods");
            DropIndex("dbo.Customs", new[] { "Prods_Pid" });
            DropTable("dbo.Prods");
            DropTable("dbo.Customs");
        }
    }
}
