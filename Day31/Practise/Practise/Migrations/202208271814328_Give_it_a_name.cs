namespace Practise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Give_it_a_name : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customs", "Cname", c => c.String(nullable: false));
            AlterColumn("dbo.Customs", "Caddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customs", "Caddress", c => c.String());
            AlterColumn("dbo.Customs", "Cname", c => c.String());
        }
    }
}
