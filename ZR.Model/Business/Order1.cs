using ZR.Model.Business;

namespace ZR.Model.Business
{
    /// <summary>
    /// 建立訂單
    /// </summary>
    [SugarTable("order_1")]
    public class Order1
    {
        /// <summary>
        /// 流水號 
        /// </summary>
        [SugarColumn(IsPrimaryKey = false, IsIdentity = true)]
        public int DocEntry { get; set; }

        /// <summary>
        /// 接件編號 
        /// </summary>
        public string DocNum { get; set; }

        /// <summary>
        /// 接件日期 
        /// </summary>
        public DateTime? DocDate { get; set; }

        /// <summary>
        /// 系統建立日期 
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 客戶編號 
        /// </summary>
        public string CustomerID { get; set; }

        /// <summary>
        /// 客戶名稱 
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// 聯絡人 
        /// </summary>
        public string CustomerContact { get; set; }

        /// <summary>
        /// 連絡電話 
        /// </summary>
        public string CustomerPhone { get; set; }

        /// <summary>
        /// 是否留板 
        /// </summary>
        public string Ps { get; set; }

        /// <summary>
        /// 案件名稱 
        /// </summary>
        public string Casename { get; set; }

        /// <summary>
        /// 選擇類別 
        /// </summary>
        public string Casetype { get; set; }

        /// <summary>
        /// 選擇項目 
        /// </summary>
        public string Caseitem { get; set; }

        /// <summary>
        /// 印墨顏色 
        /// </summary>
        public string Print { get; set; }

        /// <summary>
        /// 第一聯紙色 
        /// </summary>
        public string Paper1 { get; set; }

        /// <summary>
        /// 第二聯紙色 
        /// </summary>
        public string Paper2 { get; set; }

        /// <summary>
        /// 第三聯紙色 
        /// </summary>
        public string Paper3 { get; set; }

        /// <summary>
        /// 第四聯紙色 
        /// </summary>
        public string Paper4 { get; set; }

        /// <summary>
        /// 發印數量 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// 單位 
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 號碼 
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 起號 
        /// </summary>
        public string StartNum { get; set; }

        /// <summary>
        /// 撕線 
        /// </summary>
        public string Tear { get; set; }

        /// <summary>
        /// 撕線數量 
        /// </summary>
        public int? TearQty { get; set; }

        /// <summary>
        /// 糊頭 
        /// </summary>
        public string Pasty { get; set; }

        /// <summary>
        /// 糊頭方向 
        /// </summary>
        public string PastyDirection { get; set; }

        /// <summary>
        /// 每本份數 
        /// </summary>
        public int? CopyQuantity { get; set; }

        /// <summary>
        /// 牛皮 
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// 打洞 
        /// </summary>
        public string Hole { get; set; }

        /// <summary>
        /// 打洞數量 
        /// </summary>
        public string HoleQuantity { get; set; }

        /// <summary>
        /// 打釘製本 
        /// </summary>
        public string Nail { get; set; }

        /// <summary>
        /// 厚板 
        /// </summary>
        public string Thickplate { get; set; }

        /// <summary>
        /// 備紙尺寸 
        /// </summary>
        public string Preparation { get; set; }

        /// <summary>
        /// 備紙廠商 
        /// </summary>
        public string Vendor { get; set; }

        [Navigate(NavigateType.OneToMany, nameof(Order2.DocEntry), nameof(DocEntry))] //自定义关系映射
        public List<Order2> Order2Nav { get; set; }

        //[Navigate(NavigateType.OneToMany, nameof(Order3.DocEntry), nameof(DocEntry))] //自定义关系映射
        //public List<Order3> Order3Nav { get; set; }

        //[Navigate(NavigateType.OneToMany, nameof(Order4.DocEntry), nameof(DocEntry))] //自定义关系映射
        //public List<Order4> Order4Nav { get; set; }
    }
}