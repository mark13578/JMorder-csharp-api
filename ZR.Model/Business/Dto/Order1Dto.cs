using ZR.Model.Business;

namespace ZR.Model.Business.Dto
{
    /// <summary>
    /// 建立訂單查询对象
    /// </summary>
    public class Order1QueryDto : PagerInfo 
    {
        public string DocNum { get; set; }
        public DateTime? BeginCreateTime { get; set; }
        public DateTime? EndCreateTime { get; set; }
        public string CustomerName { get; set; }
        public string Casename { get; set; }
    }

    /// <summary>
    /// 建立訂單输入输出对象
    /// </summary>
    public class Order1Dto
    {
        [Required(ErrorMessage = "流水號不能为空")]
        public int DocEntry { get; set; }

        [Required(ErrorMessage = "接件編號不能为空")]
        public string DocNum { get; set; }

        [Required(ErrorMessage = "接件日期不能为空")]
        public DateTime? DocDate { get; set; }

        [Required(ErrorMessage = "系統建立日期不能为空")]
        public DateTime? CreateTime { get; set; }

        public string CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerContact { get; set; }

        public string CustomerPhone { get; set; }

        public string Ps { get; set; }

        public string Casename { get; set; }

        public string Casetype { get; set; }

        public string Caseitem { get; set; }

        public string Print { get; set; }

        public string Paper1 { get; set; }

        public string Paper2 { get; set; }

        public string Paper3 { get; set; }

        public string Paper4 { get; set; }

        public int? Quantity { get; set; }

        public string Unit { get; set; }

        public string Number { get; set; }

        public string StartNum { get; set; }

        public string Tear { get; set; }

        public int? TearQty { get; set; }

        public string Pasty { get; set; }

        public string PastyDirection { get; set; }

        public int? CopyQuantity { get; set; }

        public string Cover { get; set; }

        public string Hole { get; set; }

        public string HoleQuantity { get; set; }

        public string Nail { get; set; }

        public string Thickplate { get; set; }

        public string Preparation { get; set; }

        public string Vendor { get; set; }



        public List<Order2Dto> Order2Nav { get; set; }

        //public List<Order3Dto> Order3Nav { get; set; }

        //public List<Order4Dto> Order4Nav { get; set; }
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
        [ExcelColumn(Name = "撕線數量")]
        public string TearQtyLabel { get; set; }
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