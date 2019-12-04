namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diems",
                c => new
                    {
                        masv = c.String(nullable: false, maxLength: 10),
                        maMonHoc = c.String(nullable: false, maxLength: 10),
                        diem = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.masv, t.maMonHoc })
                .ForeignKey("dbo.MonHocs", t => t.maMonHoc, cascadeDelete: true)
                .ForeignKey("dbo.SinhViens", t => t.masv, cascadeDelete: true)
                .Index(t => t.masv)
                .Index(t => t.maMonHoc);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        maMonHoc = c.String(nullable: false, maxLength: 10),
                        tenMonHoc = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.maMonHoc);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        masv = c.String(nullable: false, maxLength: 10),
                        name = c.String(nullable: false, maxLength: 50),
                        dateOfBirth = c.DateTime(nullable: false),
                        gender = c.Boolean(nullable: false),
                        maLop = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.masv)
                .ForeignKey("dbo.Lops", t => t.maLop)
                .Index(t => t.maLop);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        maLop = c.String(nullable: false, maxLength: 10),
                        tenLop = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.maLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "maLop", "dbo.Lops");
            DropForeignKey("dbo.Diems", "masv", "dbo.SinhViens");
            DropForeignKey("dbo.Diems", "maMonHoc", "dbo.MonHocs");
            DropIndex("dbo.SinhViens", new[] { "maLop" });
            DropIndex("dbo.Diems", new[] { "maMonHoc" });
            DropIndex("dbo.Diems", new[] { "masv" });
            DropTable("dbo.Lops");
            DropTable("dbo.SinhViens");
            DropTable("dbo.MonHocs");
            DropTable("dbo.Diems");
        }
    }
}
