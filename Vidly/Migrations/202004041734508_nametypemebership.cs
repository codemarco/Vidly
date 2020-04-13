namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nametypemebership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "NameMembershipType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "NameMembershipType");
        }
    }
}
