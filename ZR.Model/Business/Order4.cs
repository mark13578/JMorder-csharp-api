
namespace ZR.Model.Business
{
    /// <summary>
    /// Order4
    /// </summary>
    [SugarTable("order_4")]
    public class Order4
    {
        /// <summary>
        /// 流水號 
        /// </summary>
        public int DocEntry { get; set; }

        /// <summary>
        /// 列編號 
        /// </summary>
        public int? Linenum { get; set; }

        /// <summary>
        /// 寄送公司行號 
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// 收件者 
        /// </summary>
        public string Contacts { get; set; }

        /// <summary>
        /// 連絡電話 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 收件地址 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 手機號碼 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 備註 
        /// </summary>
        public string SendComment { get; set; }

        /// <summary>
        /// 代收款 
        /// </summary>
        public int? Agency { get; set; }

        [SugarColumn(IsIgnore = true)]
        public List<Order4> Children { get; set; }
    }
}