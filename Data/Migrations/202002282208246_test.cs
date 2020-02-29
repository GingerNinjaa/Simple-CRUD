namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbltest",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        test = c.String(maxLength: 10, fixedLength: true),
                        FirstName = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbltest");
        }
    }
}
