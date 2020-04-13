namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nametypemebership50char : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "NameMembershipType", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "NameMembershipType", c => c.String());
        }
    }
}
