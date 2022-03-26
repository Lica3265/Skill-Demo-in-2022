namespace BackendDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookMarkSerno : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookmark",
                c => new
                    {
                        SerNo = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        FBUrl = c.String(),
                    })
                .PrimaryKey(t => t.SerNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bookmark");
        }
    }
}
