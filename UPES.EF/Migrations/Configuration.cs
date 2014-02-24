namespace UPES.EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UPES.Core.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UPES.EF.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(UPES.EF.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Faculties.AddOrUpdate(
                    f => f.Code,
                    new Faculty { Code = "SPTD", Name = "Sư phạm thể dục" },
                    new Faculty { Code = "HLTT", Name = "Huấn luyện thể thao" },
                    new Faculty { Code = "YHTT", Name = "Y học thể thao" },
                    new Faculty { Code = "QLTT", Name = "Quản lý thể thao" }
                );

            context.Departments.AddOrUpdate(
                    d => d.Code,
                    new Department { Code = "BMYS", Name = "Bộ môn Y sinh" },
                    new Department { Code = "BMLL", Name = "BM lý luận đại cương" },
                    new Department { Code = "BMTL", Name = "BM Tâm lý – Giáo dục" },
                    new Department { Code = "TTKH", Name = "Trung tâm khoa học" },
                    new Department { Code = "BMLT", Name = "BM lý luận TDTT" },
                    new Department { Code = "KDT", Name = "Khoa Đào tạo" },
                    new Department { Code = "BMQL", Name = "BM Quản lý TDTT" },
                    new Department { Code = "BMBB", Name = "BM Bóng bàn" },
                    new Department { Code = "BMBC", Name = "BM Bóng chuyền" },
                    new Department { Code = "BMBD", Name = "BM Bóng đá" },
                    new Department { Code = "BMBL", Name = "BM Bơi Lội" },
                    new Department { Code = "BMBN", Name = "BM Bóng ném" },
                    new Department { Code = "BMBS", Name = "BM Bắn súng" },
                    new Department { Code = "BMBR", Name = "BM Bóng rổ" },
                    new Department { Code = "BMC", Name = "BM Cờ" },
                    new Department { Code = "BMCL", Name = "BM Cầu lông" },
                    new Department { Code = "BMDK", Name = "BM Điền kinh - Cử Tạ" },
                    new Department { Code = "BMQV", Name = "BM Quần Vợt" },
                    new Department { Code = "BMTD", Name = "BM Thể dục - Thể hình" },
                    new Department { Code = "BMQA", Name = "BM Võ - Quyền Anh" },
                    new Department { Code = "BMV", Name = "BM Vật - Judo" }
            );

            context.Subjects.AddOrUpdate(
                    s => s.Code,
                    new Subject { Code = "GP1", Name = "Giải phẫu người 1", IsTheory = true },
                    new Subject { Code = "GP2", Name = "Giải phẫu người 2", IsTheory = true },
                    new Subject { Code = "SC", Name = "Sinh cơ TDTT", IsTheory = true },
                    new Subject { Code = "SH", Name = "Sinh Hoá TDTT", IsTheory = true },
                    new Subject { Code = "SL1", Name = "Sinh lý TDTT 1", IsTheory = true },
                    new Subject { Code = "SL2", Name = "Sinh lý TDTT 2", IsTheory = true },
                    new Subject { Code = "YH1", Name = "Y học TDTT 1", IsTheory = true },
                    new Subject { Code = "YH2", Name = "Y học TDTT 2", IsTheory = true },
                    new Subject { Code = "NN1", Name = "Ngoại Ngữ 1", IsTheory = true },
                    new Subject { Code = "NN2", Name = "Ngoại Ngữ 2", IsTheory = true },
                    new Subject { Code = "NN3", Name = "Ngoại Ngữ 3", IsTheory = true },
                    new Subject { Code = "NN4", Name = "Ngoại Ngữ 4", IsTheory = true },
                    new Subject { Code = "TTK", Name = "Toán Thống Kê", IsTheory = true },
                    new Subject { Code = "TH", Name = "Tin Học", IsTheory = true },
                    new Subject { Code = "DL1", Name = "Đo lường Thể thao", IsTheory = true },
                    new Subject { Code = "VH1", Name = "Văn hoá Việt Nam", IsTheory = true },
                    new Subject { Code = "NL1", Name = "Những nguyên lý cơ bản của chủ nghĩ mác 1", IsTheory = true },
                    new Subject { Code = "NL2", Name = "Những nguyên lý cơ bản của chủ nghĩ mác 2", IsTheory = true },
                    new Subject { Code = "DM", Name = "Đường lối cách mạng", IsTheory = true },
                    new Subject { Code = "HC", Name = "Tư tưởng Hồ Chí Minh", IsTheory = true },
                    new Subject { Code = "TL1", Name = "Tâm Lý Đại Cương", IsTheory = true },
                    new Subject { Code = "TLT", Name = "Tâm Lý Thể Thao", IsTheory = true },
                    new Subject { Code = "GD1", Name = "Giáo dục học đại cương", IsTheory = true },
                    new Subject { Code = "GDT", Name = "Giáo dục Thể thao", IsTheory = true },
                    new Subject { Code = "CTD", Name = "Công tác đoàn đội", IsTheory = true },
                    new Subject { Code = "GTS", Name = "Giao tiếp sư phạm", IsTheory = true },
                    new Subject { Code = "NC", Name = "Phương pháp nghiên cứu khoa học", IsTheory = true },
                    new Subject { Code = "LL1", Name = "Lý luận TDTT1", IsTheory = true },
                    new Subject { Code = "LL2", Name = "Lý luận TDTT2", IsTheory = true },
                    new Subject { Code = "TTT", Name = "Thể thao Trường học", IsTheory = true },
                    new Subject { Code = "LST", Name = "Lịch sử Thể thao", IsTheory = true },
                    new Subject { Code = "TT1", Name = "Thực Tập nghiệp vụ lần 1", IsTheory = true },
                    new Subject { Code = "TT2", Name = "Thực Tập nghiệp vụ  lần 2", IsTheory = true },
                    new Subject { Code = "QLH", Name = "Quản lý Hành chính nhà nước", IsTheory = true },
                    new Subject { Code = "QLT", Name = "Quản lý TDTT", IsTheory = true },
                    new Subject { Code = "PL", Name = "Pháp luật", IsTheory = true },
                    new Subject { Code = "TLM", Name = "Thi tốt nghiệp Lý luận chính trị", IsTheory = true },
                    new Subject { Code = "TLL", Name = "Thi tốt nghiệp Lý luận TT", IsTheory = true },
                    new Subject { Code = "TSL", Name = "Thi tốt nghiệp Sinh lý TT", IsTheory = true },
                    new Subject { Code = "LV", Name = "Luận văn tốt nghiệp", IsTheory = true },
                    new Subject { Code = "BB1", Name = "Bóng bàn 1", IsTheory = false },
                    new Subject { Code = "BB2", Name = "Bóng bàn 2", IsTheory = false },
                    new Subject { Code = "BC1", Name = "Bóng chuyền 1", IsTheory = false },
                    new Subject { Code = "BC2", Name = "Bóng chuyền 2", IsTheory = false },
                    new Subject { Code = "BD1", Name = "Bóng đá 1", IsTheory = false },
                    new Subject { Code = "BD2", Name = "Bóng đá 2", IsTheory = false },
                    new Subject { Code = "BL1", Name = "Bơi lội 1", IsTheory = false },
                    new Subject { Code = "BL2", Name = "Bơi lội 2", IsTheory = false },
                    new Subject { Code = "BN", Name = "Bóng Ném", IsTheory = false },
                    new Subject { Code = "BS", Name = "Bắn súng", IsTheory = false },
                    new Subject { Code = "BR", Name = "Bóng rổ", IsTheory = false },
                    new Subject { Code = "CV", Name = "Cờ vua", IsTheory = false },
                    new Subject { Code = "CL1", Name = "Cầu lông 1", IsTheory = false },
                    new Subject { Code = "CL2", Name = "Cầu lông 2", IsTheory = false },
                    new Subject { Code = "DK1", Name = "Điền kinh 1", IsTheory = false },
                    new Subject { Code = "DK2", Name = "Điền kinh 2", IsTheory = false },
                    new Subject { Code = "QV", Name = "Quần vợt", IsTheory = false },
                    new Subject { Code = "TD1", Name = "Thể dục 1", IsTheory = false },
                    new Subject { Code = "TD2", Name = "Thể dục 2", IsTheory = false },
                    new Subject { Code = "AN1", Name = "Âm nhạc vũ đạo", IsTheory = false },
                    new Subject { Code = "VO", Name = "Võ thuật", IsTheory = false },
                        new Subject { Code = "VAT", Name = "Vật", IsTheory = false }
                );
        }
    }
}
