namespace LTQL_1721050537.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NXSSanPham537 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NXSSanPham537",
                c => new
                    {
                        MaSanPham = c.String(nullable: false, maxLength: 20),
                        TenSanPham = c.String(maxLength: 50),
                        MaNhaCungCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.NhaCungCap537", t => t.MaNhaCungCap, cascadeDelete: true)
                .Index(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NXSSanPham537", "MaNhaCungCap", "dbo.NhaCungCap537");
            DropIndex("dbo.NXSSanPham537", new[] { "MaNhaCungCap" });
            DropTable("dbo.NXSSanPham537");
        }
    }
}
