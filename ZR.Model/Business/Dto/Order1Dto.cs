using ZR.Model.Business;

namespace ZR.Model.Business.Dto
{
    /// <summary>
    /// 建立工單查询对象
    /// </summary>
    public class Order1QueryDto : PagerInfo 
    {
    }

    /// <summary>
    /// 建立工單输入输出对象
    /// </summary>
    public class Order1Dto
    {
        [Required(ErrorMessage = "流水號不能为空")]
        [ExcelColumn(Name = "流水號")]
        [ExcelColumnName("流水號")]
        public int DocEntry { get; set; }

        [Required(ErrorMessage = "接件編號不能为空")]
        [ExcelColumn(Name = "接件編號")]
        [ExcelColumnName("接件編號")]
        public string DocNum { get; set; }

        [Required(ErrorMessage = "接件日期不能为空")]
        [ExcelColumn(Name = "接件日期", Format = "yyyy-MM-dd HH:mm:ss", Width = 20)]
        [ExcelColumnName("接件日期")]
        public DateTime? DocDate { get; set; }

        [Required(ErrorMessage = "系統建立日期不能为空")]
        [ExcelColumn(Name = "系統建立日期", Format = "yyyy-MM-dd HH:mm:ss", Width = 20)]
        [ExcelColumnName("系統建立日期")]
        public DateTime? CreateTime { get; set; }

        [ExcelColumn(Name = "客戶編號")]
        [ExcelColumnName("客戶編號")]
        public string CustomerID { get; set; }

        [ExcelColumn(Name = "客戶名稱")]
        [ExcelColumnName("客戶名稱")]
        public string CustomerName { get; set; }

        [ExcelColumn(Name = "聯絡人")]
        [ExcelColumnName("聯絡人")]
        public string CustomerContact { get; set; }

        [ExcelColumn(Name = "連絡電話")]
        [ExcelColumnName("連絡電話")]
        public string CustomerPhone { get; set; }

        [ExcelColumn(Name = "是否留板")]
        [ExcelColumnName("是否留板")]
        public string Ps { get; set; }

        [ExcelColumn(Name = "案件名稱")]
        [ExcelColumnName("案件名稱")]
        public string Casename { get; set; }

        [ExcelColumn(Name = "選擇類別")]
        [ExcelColumnName("選擇類別")]
        public string Casetype { get; set; }

        [ExcelColumn(Name = "選擇項目")]
        [ExcelColumnName("選擇項目")]
        public string Caseitem { get; set; }

        [ExcelColumn(Name = "印墨顏色")]
        [ExcelColumnName("印墨顏色")]
        public string Print { get; set; }

        [ExcelColumn(Name = "第一聯紙色")]
        [ExcelColumnName("第一聯紙色")]
        public string Paper1 { get; set; }

        [ExcelColumn(Name = "第二聯紙色")]
        [ExcelColumnName("第二聯紙色")]
        public string Paper2 { get; set; }

        [ExcelColumn(Name = "第三聯紙色")]
        [ExcelColumnName("第三聯紙色")]
        public string Paper3 { get; set; }

        [ExcelColumn(Name = "第四聯紙色")]
        [ExcelColumnName("第四聯紙色")]
        public string Paper4 { get; set; }

        [ExcelColumn(Name = "發印數量")]
        [ExcelColumnName("發印數量")]
        public int? Quantity { get; set; }

        [ExcelColumn(Name = "單位")]
        [ExcelColumnName("單位")]
        public string Unit { get; set; }

        [ExcelColumn(Name = "號碼")]
        [ExcelColumnName("號碼")]
        public string Number { get; set; }

        [ExcelColumn(Name = "起號")]
        [ExcelColumnName("起號")]
        public string StartNum { get; set; }

        [ExcelColumn(Name = "撕線")]
        [ExcelColumnName("撕線")]
        public string Tear { get; set; }

        [ExcelColumn(Name = "撕線數量")]
        [ExcelColumnName("撕線數量")]
        public int? TearQty { get; set; }

        [ExcelColumn(Name = "糊頭")]
        [ExcelColumnName("糊頭")]
        public string Pasty { get; set; }

        [ExcelColumn(Name = "糊頭方向")]
        [ExcelColumnName("糊頭方向")]
        public string PastyDirection { get; set; }

        [ExcelColumn(Name = "每本份數")]
        [ExcelColumnName("每本份數")]
        public int? CopyQuantity { get; set; }

        [ExcelColumn(Name = "牛皮")]
        [ExcelColumnName("牛皮")]
        public string Cover { get; set; }

        [ExcelColumn(Name = "打洞")]
        [ExcelColumnName("打洞")]
        public string Hole { get; set; }

        [ExcelColumn(Name = "打洞數量")]
        [ExcelColumnName("打洞數量")]
        public string HoleQuantity { get; set; }

        [ExcelColumn(Name = "打釘製本")]
        [ExcelColumnName("打釘製本")]
        public string Nail { get; set; }

        [ExcelColumn(Name = "厚板")]
        [ExcelColumnName("厚板")]
        public string Thickplate { get; set; }

        [ExcelColumn(Name = "備紙尺寸")]
        [ExcelColumnName("備紙尺寸")]
        public string Preparation { get; set; }

        [ExcelColumn(Name = "備紙廠商")]
        [ExcelColumnName("備紙廠商")]
        public string Vendor { get; set; }



        [ExcelIgnore]
        public List<Order2Dto> Order2Nav { get; set; }

        [ExcelIgnore]
        public List<Order3Dto> Order3Nav { get; set; }

        [ExcelIgnore]
        public List<Order4Dto> Order4Nav { get; set; }
        [ExcelColumn(Name = "選擇類別")]
        public string CasetypeLabel { get; set; }
        [ExcelColumn(Name = "選擇項目")]
        public string CaseitemLabel { get; set; }
        [ExcelColumn(Name = "印墨顏色")]
        public string PrintLabel { get; set; }
        [ExcelColumn(Name = "第一聯紙色")]
        public string Paper1Label { get; set; }
        [ExcelColumn(Name = "第二聯紙色")]
        public string Paper2Label { get; set; }
        [ExcelColumn(Name = "第三聯紙色")]
        public string Paper3Label { get; set; }
        [ExcelColumn(Name = "第四聯紙色")]
        public string Paper4Label { get; set; }
        [ExcelColumn(Name = "單位")]
        public string UnitLabel { get; set; }
        [ExcelColumn(Name = "撕線")]
        public string TearLabel { get; set; }
        [ExcelColumn(Name = "糊頭方向")]
        public string PastyDirectionLabel { get; set; }
        [ExcelColumn(Name = "牛皮")]
        public string CoverLabel { get; set; }
        [ExcelColumn(Name = "打洞")]
        public string HoleLabel { get; set; }
        [ExcelColumn(Name = "打釘製本")]
        public string NailLabel { get; set; }
        [ExcelColumn(Name = "厚板")]
        public string ThickplateLabel { get; set; }
    }
}