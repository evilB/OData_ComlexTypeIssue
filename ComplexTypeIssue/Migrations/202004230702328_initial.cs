namespace ComplexTypeIssue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description_Fr = c.String(),
                        Description_En = c.String(),
                        Description_De = c.String(),
                        Description_Nl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestModels");
        }
    }
}
