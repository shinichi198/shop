namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HocSinhs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LopHocID = c.Int(nullable: false),
                        HoTen = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenLopHoc = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LopHocSinhs",
                c => new
                    {
                        Lop_ID = c.Int(nullable: false),
                        HocSinh_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Lop_ID, t.HocSinh_ID })
                .ForeignKey("dbo.Lops", t => t.Lop_ID, cascadeDelete: true)
                .ForeignKey("dbo.HocSinhs", t => t.HocSinh_ID, cascadeDelete: true)
                .Index(t => t.Lop_ID)
                .Index(t => t.HocSinh_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LopHocSinhs", "HocSinh_ID", "dbo.HocSinhs");
            DropForeignKey("dbo.LopHocSinhs", "Lop_ID", "dbo.Lops");
            DropIndex("dbo.LopHocSinhs", new[] { "HocSinh_ID" });
            DropIndex("dbo.LopHocSinhs", new[] { "Lop_ID" });
            DropTable("dbo.LopHocSinhs");
            DropTable("dbo.Lops");
            DropTable("dbo.HocSinhs");
        }
    }
}
